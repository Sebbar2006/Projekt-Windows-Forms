# 🃏 Blackjackv2 – Gra Windows Forms w C#

## 📝 Opis Projektu

**Blackjackv2** to rozbudowana aplikacja desktopowa stworzona w technologii **Windows Forms (C#)**, której celem jest odwzorowanie klasycznej gry **Blackjack (oczko)** w prostym, intuicyjnym interfejsie graficznym.

Projekt umożliwia grę jednego gracza przeciwko komputerowi (dealerowi), z pełnym zestawem funkcji: dobieraniem kart, oceną wyniku, mechaniką żetonów, obstawianiem oraz dynamicznym przelicznikiem walut opartym o **oficjalne dane z API Narodowego Banku Polskiego (NBP)**.

Aplikacja została zrealizowana jako ćwiczenie z tworzenia aplikacji graficznych w języku C#

Celem było stworzenie przyjemnej, działającej gry karcianej z elementami ekonomii i dynamicznej interakcji użytkownika 


## 🎮 Funkcje gry

| Funkcja                         | Opis                                                                     |
|--------------------------------|---------------------------------------------------------------------      |
| 🎴 Dobieranie kart              | Gracz może dobrać kartę (`Dobierz`) lub spasować (`Pass`)               |
| 🧠 AI Dealera                   | Krupier dobiera karty do min. 17 punktów                                |
| 💰 System żetonów              | Startujesz z 1000 żetonów                                                |
| 🪙 Obstawianie                 | Możliwość ustawienia stawki (min. 10)                                    |
| 🌐 Przelicznik walut           | Przeliczanie żetonów na **PLN / EUR / USD** z użyciem **NBP API**        |
| 🔄 Restart                     | Możliwość restartu, jeśli skończą się żetony                             |
| 🖼️ Prosty interfejs            | Intuicyjny GUI oparty na `Label`, `Button`, `ComboBox` i `NumericUpDown` |

## 🗺️ Struktura projektu
├── Form1.cs               // Główna logika gry
├── Form1.Designer.cs      // Definicja elementów GUI
├── Program.cs             // Punkt startowy aplikacji
├── Resources.resx         // Zasoby GUI
└── README.md              // Dokumentacja projektu
