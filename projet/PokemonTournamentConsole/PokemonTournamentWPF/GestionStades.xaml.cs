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
    /// Logique d'interaction pour GestionStades.xaml
    /// </summary>
    public partial class GestionStades : Window
    {
        private BusinessManager BManager;
        public GestionStades()
        {
            InitializeComponent();
            BManager = new BusinessManager();
        }

        private void AddStade_Click(object sender, RoutedEventArgs e) {
            AddStade win = new AddStade();
            win.Show();
            this.Close();
        }

        private void ModifStade_Click(object sender, RoutedEventArgs e) {
            ModifStade win = new ModifStade();
            win.Show();
            this.Close();
        }

        private void DeleteStade_Click(object sender, RoutedEventArgs e)
        {
            DeleteStade win = new DeleteStade();
            win.Show();
            this.Close();
        }
    }
}
