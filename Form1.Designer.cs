namespace projektv6
{
    partial class Form1
    {
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblPlayerCards;
        private System.Windows.Forms.Label lblDealerCards;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblChips;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.ComboBox comboCurrency;
        private System.Windows.Forms.Label lblCurrencyRate;
        private System.Windows.Forms.NumericUpDown numericBet;
        private System.Windows.Forms.Label lblBet;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblPlayerCards = new System.Windows.Forms.Label();
            this.lblDealerCards = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblChips = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.comboCurrency = new System.Windows.Forms.ComboBox();
            this.lblCurrencyRate = new System.Windows.Forms.Label();
            this.numericBet = new System.Windows.Forms.NumericUpDown();
            this.lblBet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericBet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(44, 265);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(117, 58);
            this.btnHit.TabIndex = 0;
            this.btnHit.Text = "dobierz";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(200, 265);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(120, 58);
            this.btnStand.TabIndex = 1;
            this.btnStand.Text = "pass";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(367, 265);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(115, 58);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblPlayerCards
            // 
            this.lblPlayerCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPlayerCards.Location = new System.Drawing.Point(375, 29);
            this.lblPlayerCards.Name = "lblPlayerCards";
            this.lblPlayerCards.Size = new System.Drawing.Size(266, 24);
            this.lblPlayerCards.TabIndex = 3;
            this.lblPlayerCards.Text = "Gracz:";
            this.lblPlayerCards.Click += new System.EventHandler(this.lblPlayerCards_Click);
            // 
            // lblDealerCards
            // 
            this.lblDealerCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDealerCards.Location = new System.Drawing.Point(375, 85);
            this.lblDealerCards.Name = "lblDealerCards";
            this.lblDealerCards.Size = new System.Drawing.Size(266, 29);
            this.lblDealerCards.TabIndex = 4;
            this.lblDealerCards.Text = "Krupier:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(26, 85);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 5;
            // 
            // lblChips
            // 
            this.lblChips.AutoSize = true;
            this.lblChips.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblChips.Location = new System.Drawing.Point(378, 150);
            this.lblChips.Name = "lblChips";
            this.lblChips.Size = new System.Drawing.Size(104, 20);
            this.lblChips.TabIndex = 6;
            this.lblChips.Text = "Żetony: 1000";
            this.lblChips.Click += new System.EventHandler(this.lblChips_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBalance.Location = new System.Drawing.Point(488, 150);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(135, 20);
            this.lblBalance.TabIndex = 7;
            this.lblBalance.Text = "Saldo: 1000 PLN";
            // 
            // comboCurrency
            // 
            this.comboCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCurrency.FormattingEnabled = true;
            this.comboCurrency.Location = new System.Drawing.Point(345, 352);
            this.comboCurrency.Name = "comboCurrency";
            this.comboCurrency.Size = new System.Drawing.Size(66, 24);
            this.comboCurrency.TabIndex = 8;
            // 
            // lblCurrencyRate
            // 
            this.lblCurrencyRate.AutoSize = true;
            this.lblCurrencyRate.Location = new System.Drawing.Point(428, 355);
            this.lblCurrencyRate.Name = "lblCurrencyRate";
            this.lblCurrencyRate.Size = new System.Drawing.Size(75, 16);
            this.lblCurrencyRate.TabIndex = 9;
            this.lblCurrencyRate.Text = "Kurs: 1 PLN";
            // 
            // numericBet
            // 
            this.numericBet.Location = new System.Drawing.Point(126, 222);
            this.numericBet.Name = "numericBet";
            this.numericBet.Size = new System.Drawing.Size(59, 22);
            this.numericBet.TabIndex = 10;
            // 
            // lblBet
            // 
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBet.Location = new System.Drawing.Point(26, 223);
            this.lblBet.Margin = new System.Windows.Forms.Padding(3);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(75, 21);
            this.lblBet.TabIndex = 11;
            this.lblBet.Text = "Stawka: ";
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(653, 440);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.numericBet);
            this.Controls.Add(this.lblCurrencyRate);
            this.Controls.Add(this.comboCurrency);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblChips);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDealerCards);
            this.Controls.Add(this.lblPlayerCards);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Name = "Form1";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}