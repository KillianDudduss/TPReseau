using BusinessLayer;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PokemonTournamentWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            _manager = new BusinessManager();
        }

        BusinessLayer.BusinessManager _manager;


        private void connect_Click(object sender, RoutedEventArgs e)
        {
            if (_manager.CheckConnexionUser(log.Text.ToString(), pass.Password))
            {
                MainWindow win = new MainWindow();
                win.Show();
                this.Close();
            }
        }
  
    }
}
