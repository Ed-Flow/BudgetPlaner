using System.Linq;
using System.Windows;

namespace BudgetPlaner
{
    public partial class FixkostenBearbeiten : Window
    {
        private Profil _aktivesProfil;

        public FixkostenBearbeiten(Profil aktivesProfil)
        {
            InitializeComponent();
            _aktivesProfil = aktivesProfil;
            FixkostenListe.ItemsSource = _aktivesProfil.Rechnungen;
        }

        private void Hinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            var eingabeFenster = new RechnungNeueingabe();
            if (eingabeFenster.ShowDialog() == true)
            {
                _aktivesProfil.Rechnungen.Add(eingabeFenster.ErstellteRechnung);
                FixkostenListe.ItemsSource = null;
                FixkostenListe.ItemsSource = _aktivesProfil.Rechnungen;
            }
        }

        private void Bearbeiten_Click(object sender, RoutedEventArgs e)
        {
            if (FixkostenListe.SelectedItem is Rechnung ausgewählteRechnung)
            {
                var eingabeFenster = new RechnungNeueingabe(ausgewählteRechnung);
                if (eingabeFenster.ShowDialog() == true)
                {
                    FixkostenListe.ItemsSource = null;
                    FixkostenListe.ItemsSource = _aktivesProfil.Rechnungen;
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Rechnung aus, um sie zu bearbeiten.", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Loeschen_Click(object sender, RoutedEventArgs e)
        {
            if (FixkostenListe.SelectedItem is Rechnung ausgewählteRechnung)
            {
                _aktivesProfil.Rechnungen.Remove(ausgewählteRechnung);
                FixkostenListe.ItemsSource = null;
                FixkostenListe.ItemsSource = _aktivesProfil.Rechnungen;
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Rechnung aus, um sie zu löschen.", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Speichern_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
