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

namespace PokemonTournamentWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BusinessLayer.BusinessManager _manager;

        public MainWindow()
        {
            InitializeComponent();
            _manager = new BusinessLayer.BusinessManager();

       }

        private void Poke_Click(object sender, RoutedEventArgs e)
        {
            ListResults.DataContext = _manager.getPokemonForceVie();
        }

        private void Stade_Click(object sender, RoutedEventArgs e)
        {
            ListResults.DataContext = _manager.getStade();
        }
    }
}
