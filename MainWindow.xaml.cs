using System;
using System.Linq;
using System.Windows;

namespace BudgetPlaner
{
    public partial class MainWindow : Window
    {
        public Profil AktivesProfil { get; private set; }

        public string MonatlicheFixkosten =>
            AktivesProfil?.Rechnungen?.Sum(r => r.Betrag).ToString("N2") + " €" ?? "0.00 €";

        public string VerfügbaresMonatsbudget
        {
            get
            {
                var fixkosten = AktivesProfil?.Rechnungen?.Sum(r => r.Betrag) ?? 0;

                // Nur Tagesausgaben des aktuellen Monats berücksichtigen
                var tagesausgaben = AktivesProfil?.Tagesausgaben?
                    .Where(kvp => IstImAktuellenMonat(kvp.Key))
                    .Sum(kvp => kvp.Value) ?? 0;

                var verbleibendesBudget = (AktivesProfil?.Gehalt ?? 0) - fixkosten - tagesausgaben;

                return verbleibendesBudget.ToString("N2") + " €";
            }
        }

        public string Tagesbudget
        {
            get
            {
                var fixkosten = AktivesProfil?.Rechnungen?.Sum(r => r.Betrag) ?? 0;

                // Nur Tagesausgaben des aktuellen Monats berücksichtigen
                var tagesausgaben = AktivesProfil?.Tagesausgaben?
                    .Where(kvp => IstImAktuellenMonat(kvp.Key))
                    .Sum(kvp => kvp.Value) ?? 0;

                var verbleibendesBudget = (AktivesProfil?.Gehalt ?? 0) - fixkosten - tagesausgaben;
                var tageImMonat = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

                return (verbleibendesBudget / tageImMonat).ToString("N2") + " €";
            }
        }

        public string Ueberschrift { get; private set; }

        public MainWindow()
        {
            InitializeComponent();

            // Dynamische Überschrift mit Monat und Jahr setzen
            var aktuellesDatum = DateTime.Now;
            Ueberschrift = $"Budgetübersicht – {aktuellesDatum:MMMM yyyy}";

            // Versuche, das zuletzt verwendete Profil zu laden
            var letzterProfilName = ProfilSpeicher.LadeZuletztVerwendetesProfil();
            if (!string.IsNullOrEmpty(letzterProfilName))
            {
                var alleProfile = ProfilSpeicher.LadeProfile();
                AktivesProfil = alleProfile.Find(p => p.Name == letzterProfilName);
            }

            // Falls kein Profil gefunden wurde, starte mit einer Auswahl
            if (AktivesProfil == null)
            {
                var profilAuswahl = new ProfilAuswahl();
                profilAuswahl.Show();
                this.Close();
            }
            else
            {
                AktualisiereAnzeige();
            }
        }

        public MainWindow(Profil profil) : this()
        {
            AktivesProfil = profil;

            // Speichere das aktive Profil als zuletzt verwendet
            ProfilSpeicher.SpeichereZuletztVerwendetesProfil(profil.Name);

            AktualisiereAnzeige();
        }

        private void AktualisiereAnzeige()
        {
            DataContext = null; // Datenbindung neu setzen
            DataContext = this;
        }

        private bool IstImAktuellenMonat(string datumString)
        {
            if (DateTime.TryParse(datumString, out var datum))
            {
                return datum.Year == DateTime.Now.Year && datum.Month == DateTime.Now.Month;
            }
            return false;
        }

        private void TagesausgabenHinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            var fenster = new Tagesausgaben();
            if (fenster.ShowDialog() == true)
            {
                if (AktivesProfil.Tagesausgaben.ContainsKey(fenster.Datum))
                {
                    AktivesProfil.Tagesausgaben[fenster.Datum] += fenster.Betrag;
                }
                else
                {
                    AktivesProfil.Tagesausgaben[fenster.Datum] = fenster.Betrag;
                }

                ProfilSpeicher.AktualisiereProfil(AktivesProfil);

                AktualisiereAnzeige();
            }
        }

        private void TagesausgabenAnzeigen_Click(object sender, RoutedEventArgs e)
        {
            var anzeigenFenster = new TagesausgabenAnzeigen(AktivesProfil);
            anzeigenFenster.ShowDialog();
        }

        private void ZurueckZurProfilAuswahl_Click(object sender, RoutedEventArgs e)
        {
            var profilAuswahl = new ProfilAuswahl();
            profilAuswahl.Show();
            this.Close();
        }
    }
}
