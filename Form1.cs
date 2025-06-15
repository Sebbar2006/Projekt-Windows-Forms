using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektv6
{
    public partial class Form1 : Form
    {
        private List<string> talia;
        private List<string> RękaGracza;
        private List<string> RękaKrupiera;
        private Random rng = new Random();

        private decimal żetony = 1000;
        private decimal KursWymiany = 1.0m;
        private string WybranaWaluta = "PLN";
        private readonly string[] waluty = { "PLN", "USD", "EUR" };

        public Form1()
        {
            InitializeComponent();
            InitializeCustomControls();
            LoadExchangeRateAsync(WybranaWaluta).Wait();
            Gra();
        }

        private void InitializeCustomControls()
        {
            comboCurrency.Items.AddRange(waluty);
            comboCurrency.SelectedItem = WybranaWaluta;
            comboCurrency.SelectedIndexChanged += async (s, e) =>
            {
                WybranaWaluta = comboCurrency.SelectedItem.ToString();
                await LoadExchangeRateAsync(WybranaWaluta);
                UpdateBalanceLabels();
            };

            numericBet.Minimum = 10;
            numericBet.Maximum = żetony;
            numericBet.Value = 10;
        }

        private async Task<decimal> GetEuroFromNBPAsync()
        {
            using (var client = new HttpClient())
            {
                string url = "https://api.nbp.pl/api/exchangerates/rates/a/eur/?format=json";
                string json = await client.GetStringAsync(url);

                using (var doc = JsonDocument.Parse(json))
                {
                    var rates = doc.RootElement.GetProperty("rates");
                    var mid = rates[0].GetProperty("mid").GetDecimal();
                    return mid; // Kurs 1 EUR w PLN
                }
            }
        }

        private async Task<decimal> GetUsdFromNBPAsync()
        {
            using (var client = new HttpClient())
            {
                string url = "https://api.nbp.pl/api/exchangerates/rates/a/usd/?format=json";
                string json = await client.GetStringAsync(url);

                using (var doc = JsonDocument.Parse(json))
                {
                    var rates = doc.RootElement.GetProperty("rates");
                    var mid = rates[0].GetProperty("mid").GetDecimal();
                    return mid; // Kurs 1 USD w PLN
                }
            }
        }

        // Zaktualizuj metodę pobierania kursów walut:
        private async Task LoadExchangeRateAsync(string waluta)
        {
            try
            {
                if (waluta == "PLN")
                {
                    KursWymiany = 1.0m;
                    lblCurrencyRate.Text = "Kurs: 1 PLN";
                }
                else if (waluta == "EUR")
                {
                    decimal kursEuro = await GetEuroFromNBPAsync();
                    KursWymiany = 1m / kursEuro; // 1 PLN = X EUR
                    lblCurrencyRate.Text = $"Kurs: 1 PLN = {KursWymiany:0.0000} EUR (NBP)";
                }
                else if (waluta == "USD")
                {
                    decimal kursUsd = await GetUsdFromNBPAsync();
                    KursWymiany = 1m / kursUsd; // 1 PLN = X USD
                    lblCurrencyRate.Text = $"Kurs: 1 PLN = {KursWymiany:0.0000} USD (NBP)";
                }
                else
                {
                    KursWymiany = 1.0m;
                    lblCurrencyRate.Text = "Brak kursu ";
                }
            }
            catch
            {
                KursWymiany = 1.0m;
                lblCurrencyRate.Text = "Brak kursu ";
            }
            UpdateBalanceLabels();
        }
        private void Gra()
        {
            talia = GenerateTalia();
            RękaGracza = new List<string>();
            RękaKrupiera = new List<string>();
            RękaGracza.Add(DobierzKartę());
            RękaGracza.Add(DobierzKartę());
            RękaKrupiera.Add(DobierzKartę());
            RękaKrupiera.Add(DobierzKartę());

            UpdateUI();
            btnHit.Enabled = btnStand.Enabled = true;
            lblResult.Text = "";
            numericBet.Maximum = żetony;
            if (numericBet.Value > żetony)
                numericBet.Value = numericBet.Maximum;
        }

        private List<string> GenerateTalia()
        {
            string[] suits = { "♠", "♥", "♦", "♣" };
            string[] values = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            var talia = new List<string>();
            foreach (var suit in suits)
                foreach (var value in values)
                    talia.Add($"{value}{suit}");
            return talia.OrderBy(x => rng.Next()).ToList();
        }

        private string DobierzKartę()
        {
            if (talia.Count == 0)
                talia = GenerateTalia();
            var karta = talia[0];
            talia.RemoveAt(0);
            return karta;
        }

        private int LiczWartoscReki(List<string> hand)
        {
            int value = 0, asy = 0;
            foreach (var karta in hand)
            {
                string v = karta.Substring(0, karta.Length - 1);
                if (v == "A") { value += 11; asy++; }
                else if (v == "K" || v == "Q" || v == "J") value += 10;
                else value += int.Parse(v);
            }
            while (value > 21 && asy > 0)
            {
                value -= 10;
                asy--;
            }
            return value;
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            RękaGracza.Add(DobierzKartę());
            UpdateUI();
            if (LiczWartoscReki(RękaGracza) > 21)
                EndGame();
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            while (LiczWartoscReki(RękaKrupiera) < 17)
                RękaKrupiera.Add(DobierzKartę());
            EndGame();
        }

        private void EndGame()
        {
            btnHit.Enabled = btnStand.Enabled = false;
            int playerScore = LiczWartoscReki(RękaGracza);
            int dealerScore = LiczWartoscReki(RękaKrupiera);
            decimal bet = numericBet.Value;
            string result;

            if (playerScore > 21)
            {
                result = "Przebiłeś, przegrywasz :(";
                żetony -= bet;
            }
            else if (dealerScore > 21)
            {
                result = "Krupier przebił, Wygrywasz!!";
                żetony += bet;
            }
            else if (playerScore > dealerScore)
            {
                result = "Wygrałeś!!!";
                żetony += bet;
            }
            else if (playerScore < dealerScore)
            {
                result = "Porażka :(";
                żetony -= bet;
            }
            else
            {
                result = "Remis";
            }

            lblResult.Text = $"Wynik: {result}";
            lblDealerCards.Text = "Krupier: " + string.Join(", ", RękaKrupiera) + $" (Wartość: {dealerScore})";
            UpdateBalanceLabels();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (żetony < 10)
            {
                MessageBox.Show("Nie masz już żetonów! Restart gry.");
                żetony = 1000;
                UpdateBalanceLabels();
            }
            Gra();
        }

        private void UpdateUI()
        {
            lblPlayerCards.Text = "Gracz: " + string.Join(", ", RękaGracza) + $" (Wartość: {LiczWartoscReki(RękaGracza)})";
            lblDealerCards.Text = "Krupier: " + RękaKrupiera[0] + ", ??";
        }

        private void UpdateBalanceLabels()
        {
            lblChips.Text = $"Żetony: {żetony}";
            decimal waluta = żetony * KursWymiany;
            lblBalance.Text = $"Saldo: {waluta:0.00} {WybranaWaluta}";
            numericBet.Maximum = Math.Max(10, żetony);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblChips_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayerCards_Click(object sender, EventArgs e)
        {

        }
    }
}