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

            // Setze das aktuelle Datum standardmäßig ein
            Loaded += Tagesausgaben_Loaded;
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

            Datum = DatumPicker.SelectedDate.Value.ToShortDateString();
            Betrag = betrag;

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
