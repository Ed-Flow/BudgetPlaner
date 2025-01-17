using System.Windows;

namespace BudgetPlaner
{
    public partial class ProfilErstellen : Window
    {
        public Profil ErstelltesProfil { get; private set; }

        public ProfilErstellen()
        {
            InitializeComponent();
        }

        private void Erstellen_Click(object sender, RoutedEventArgs e)
        {
            // Validierung der Eingaben
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("Bitte geben Sie einen gültigen Namen ein.", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!decimal.TryParse(MonatsgehaltTextBox.Text, out var monatsgehalt) || monatsgehalt <= 0)
            {
                MessageBox.Show("Bitte geben Sie ein gültiges Monatsgehalt ein.", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!decimal.TryParse(FixkostenTextBox.Text, out var fixkosten) || fixkosten < 0)
            {
                MessageBox.Show("Bitte geben Sie gültige Fixkosten ein.", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Neues Profil erstellen
            ErstelltesProfil = new Profil
            {
                Name = NameTextBox.Text,
                Gehalt = monatsgehalt,
                Rechnungen = new System.Collections.Generic.List<Rechnung>
                {
                    new Rechnung { Beschreibung = "Fixkosten Gesamt", Betrag = fixkosten }
                }
            };

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
