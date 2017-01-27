using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using EntitiesLayer;
using BusinessLayer;

namespace PokemonTournamentWPF
{
    /// <summary>
    /// Logique d'interaction pour ModifStade.xaml
    /// </summary>
    public partial class ModifStade : Window
    {
        private BusinessManager BManager;
        public ModifStade()
        {
            InitializeComponent();
            BManager = new BusinessManager();
        }

        private void valider_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RetourMenu_Click(object sender, RoutedEventArgs e)
        {
            Menu win = new PokemonTournamentWPF.Menu();
            win.Show();
            this.Close();
        }
    }
}
