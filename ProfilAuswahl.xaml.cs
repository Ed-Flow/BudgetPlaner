using System.Windows;

namespace BudgetPlaner
{
    public partial class ProfilAuswahl : Window
    {
        private List<Profil> Profile;

        public ProfilAuswahl()
        {
            InitializeComponent();
            LadeProfile();
        }

        private void LadeProfile()
        {
            Profile = ProfilSpeicher.LadeProfile();
            ProfileListe.ItemsSource = Profile;
        }

        private void ProfilAuswaehlen_Click(object sender, RoutedEventArgs e)
        {
            if (ProfileListe.SelectedItem is Profil ausgewähltesProfil)
            {
                ProfilSpeicher.SpeichereZuletztVerwendetesProfil(ausgewähltesProfil.Name);

                var mainWindow = new MainWindow(ausgewähltesProfil);
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie ein Profil aus.", "Fehler", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ProfilLoeschen_Click(object sender, RoutedEventArgs e)
        {
            if (ProfileListe.SelectedItem is Profil ausgewähltesProfil)
            {
                if (MessageBox.Show($"Möchten Sie das Profil '{ausgewähltesProfil.Name}' wirklich löschen?", "Bestätigung",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Profile.Remove(ausgewähltesProfil);
                    ProfilSpeicher.SpeichereProfile(Profile);
                    LadeProfile();
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie ein Profil aus, um es zu löschen.", "Fehler", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void NeuesProfilErstellen_Click(object sender, RoutedEventArgs e)
        {
            var neuesProfilFenster = new ProfilErstellen();
            if (neuesProfilFenster.ShowDialog() == true)
            {
                Profile.Add(neuesProfilFenster.ErstelltesProfil);
                ProfilSpeicher.SpeichereProfile(Profile);
                LadeProfile();
            }
        }

        private void ProfilBearbeiten_Click(object sender, RoutedEventArgs e)
        {
            if (ProfileListe.SelectedItem is Profil ausgewähltesProfil)
            {
                var bearbeitungsFenster = new ProfilBearbeiten(ausgewähltesProfil);
                if (bearbeitungsFenster.ShowDialog() == true)
                {
                    // Nach der Bearbeitung das Profil aktualisieren
                    ProfilSpeicher.AktualisiereProfil(ausgewähltesProfil);
                    LadeProfile(); // Profil-Liste neu laden
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie ein Profil aus, um es zu bearbeiten.", "Fehler", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

    }
}
