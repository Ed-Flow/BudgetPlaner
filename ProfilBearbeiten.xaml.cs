using System.Windows;

namespace BudgetPlaner
{
    public partial class ProfilBearbeiten : Window
    {
        private Profil _aktuellesProfil;

        public ProfilBearbeiten(Profil profil)
        {
            InitializeComponent();
            _aktuellesProfil = profil;

            // Lade bestehende Werte in die Eingabefelder
            NameTextBox.Text = _aktuellesProfil.Name;
            GehaltTextBox.Text = _aktuellesProfil.Gehalt.ToString("F2");
            FixkostenTextBox.Text = _aktuellesProfil.Rechnungen?.Sum(r => r.Betrag).ToString("F2");
        }

        private void Speichern_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                !decimal.TryParse(GehaltTextBox.Text, out var neuesGehalt) ||
                !decimal.TryParse(FixkostenTextBox.Text, out var neueFixkosten))
            {
                MessageBox.Show("Bitte geben Sie gültige Werte für Name, Gehalt und Fixkosten ein.", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Aktualisiere den Namen des Profils
            _aktuellesProfil.Name = NameTextBox.Text;

            // Aktualisiere das Gehalt
            _aktuellesProfil.Gehalt = neuesGehalt;

            // Aktualisiere die Fixkosten
            if (_aktuellesProfil.Rechnungen == null)
                _aktuellesProfil.Rechnungen = new System.Collections.Generic.List<Rechnung>();

            // Lösche alte Fixkosten und füge die neuen hinzu
            _aktuellesProfil.Rechnungen.Clear();
            _aktuellesProfil.Rechnungen.Add(new Rechnung { Beschreibung = "Fixkosten Gesamt", Betrag = neueFixkosten });

            // Speichere das geänderte Profil
            ProfilSpeicher.AktualisiereProfil(_aktuellesProfil);

            // Schließe das Fenster mit Erfolg
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
