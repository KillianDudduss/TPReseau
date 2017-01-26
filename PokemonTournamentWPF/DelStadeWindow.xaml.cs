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
    /// Logique d'interaction pour DelStadeWindow.xaml
    /// </summary>
    public partial class DelStadeWindow : Window
    {
        BusinessLayer.BusinessManager _manager;

        public DelStadeWindow()
        {
            InitializeComponent();
        }


        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }



    }
}
