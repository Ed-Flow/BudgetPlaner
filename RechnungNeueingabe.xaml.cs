using System.Windows;

namespace BudgetPlaner
{
    public partial class RechnungNeueingabe : Window
    {
        public Rechnung ErstellteRechnung { get; private set; }

        public RechnungNeueingabe(Rechnung rechnung = null)
        {
            InitializeComponent();
            ErstellteRechnung = rechnung ?? new Rechnung();
            DataContext = ErstellteRechnung;
        }

        private void Speichern_Click(object sender, RoutedEventArgs e)
        {
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
