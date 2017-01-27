using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using BusinessLayer;
using EntitiesLayer;

namespace PokemonTournamentWPF
{
    /// <summary>
    /// Logique d'interaction pour Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public BusinessManager BManager;
        public Menu()
        {
            InitializeComponent();
            BManager = new BusinessManager();
        }

        private void DDeconnection_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }

        private void GestionStades_Click(object sender, RoutedEventArgs e)
        {
            GestionStades win = new GestionStades();
            win.Show();
            this.Close();
        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Pokemons.IsSelected)
                dataGridPokemon.ItemsSource = BManager.getPokemon();

            if (Stades.IsSelected)
                dataGridStades.ItemsSource = BManager.getStade();

            if (Matchs.IsSelected)
            {
                dataGridMatchs.ItemsSource = BManager.getMatch();
            }
        }
    }
}
