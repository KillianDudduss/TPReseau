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
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        BusinessLayer.BusinessManager _manager;

        public Window1()
        {
            InitializeComponent();
        }

        private void Ajout_Stade_Click(object sender, RoutedEventArgs e)
        {
            AddStadeWindow win = new AddStadeWindow();
            win.Show();
        }

        private void Modif_Stade_Click(object sender, RoutedEventArgs e)
        {
            ModStadeWindow win = new ModStadeWindow();
            win.Show();
        }

        private void Suppr_Stade_Click(object sender, RoutedEventArgs e)
        {
            DelStadeWindow win = new DelStadeWindow();
            win.Show();
        }
    }
}
