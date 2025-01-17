using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace BudgetPlaner
{
    public partial class TagesausgabenAnzeigen : Window
    {
        private Profil _aktivesProfil;

        public TagesausgabenAnzeigen(Profil aktivesProfil)
        {
            InitializeComponent();
            _aktivesProfil = aktivesProfil;

            // Filter-Optionen laden
            LadeFilterOptionen();

            // Zeige Tagesausgaben
            Filter_Changed(null, null);
        }

        private void LadeFilterOptionen()
        {
            // Monate (1 bis 12)
            MonatFilter.ItemsSource = Enumerable.Range(1, 12).Select(m => m.ToString("D2"));
            MonatFilter.SelectedIndex = DateTime.Now.Month - 1;

            // Jahre (letzte 5 Jahre bis nächstes Jahr)
            JahrFilter.ItemsSource = Enumerable.Range(DateTime.Now.Year - 5, 6).Select(y => y.ToString());
            JahrFilter.SelectedItem = DateTime.Now.Year.ToString();
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            // Aktuellen Monat und Jahr aus den Filtern holen
            if (MonatFilter.SelectedItem == null || JahrFilter.SelectedItem == null)
                return;

            string ausgewählterMonat = MonatFilter.SelectedItem.ToString();
            string ausgewähltesJahr = JahrFilter.SelectedItem.ToString();

            // Filtere Tagesausgaben basierend auf Monat und Jahr
            var gefilterteAusgaben = _aktivesProfil.Tagesausgaben
                .Where(kvp =>
                {
                    DateTime datum;
                    if (DateTime.TryParse(kvp.Key, out datum))
                    {
                        return datum.ToString("yyyy") == ausgewähltesJahr && datum.ToString("MM") == ausgewählterMonat;
                    }
                    return false;
                })
                .ToList();

            // Liste der Tagesausgaben aktualisieren
            TagesausgabenListe.ItemsSource = gefilterteAusgaben.Select(kvp =>
                $"{kvp.Key}: {kvp.Value:F2} €");

            // Gesamtausgaben für den gefilterten Zeitraum berechnen
            ZeigeMonatlicheGesamtausgaben(gefilterteAusgaben);
        }

        private void ZeigeMonatlicheGesamtausgaben(IEnumerable<KeyValuePair<string, decimal>> ausgaben)
        {
            decimal gesamtausgaben = ausgaben.Sum(kvp => kvp.Value);
            GesamtausgabenTextBlock.Text = $"Gesamtausgaben im Monat: {gesamtausgaben:F2} €";
        }

        private void Filter_Changed(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
