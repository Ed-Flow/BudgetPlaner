using System;
using System.Windows;

namespace BudgetPlaner
{
    public partial class Tagesausgaben : Window
    {
        public string Datum { get; private set; }
        public decimal Betrag { get; private set; }

        public Tagesausgaben()
        {
            InitializeComponent();
            Loaded += Tagesausgaben_Loaded; // sicherstellen, dass UI geladen ist
        }

        private void Tagesausgaben_Loaded(object sender, RoutedEventArgs e)
        {
            if (DatumPicker.SelectedDate == null) // Nur setzen, wenn noch kein Datum ausgewählt ist
            {
                DatumPicker.SelectedDate = DateTime.Now;
            }
        }

        private void Speichern_Click(object sender, RoutedEventArgs e)
        {
            if (DatumPicker.SelectedDate == null || !decimal.TryParse(BetragTextBox.Text, out var betrag))
            {
                MessageBox.Show("Bitte geben Sie ein gültiges Datum und einen Betrag ein.", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Setze das Datum und den Betrag
            Datum = DatumPicker.SelectedDate.Value.ToShortDateString();
            Betrag = betrag;

            // Konvertiere die Werte, falls nötig
            // DatumPicker.SelectedDate = DateTime.Parse(datum); // Beispiel für das Parsen des Datums
            // BetragTextBox.Text = betrag.ToString("F2"); // Formatierung des Betrags

            DialogResult = true;
            Close();
        }

        private void Abbrechen_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
