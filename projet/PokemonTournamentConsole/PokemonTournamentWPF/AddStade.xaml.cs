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

using BusinessLayer;
using EntitiesLayer;

namespace PokemonTournamentWPF
{
    /// <summary>
    /// Logique d'interaction pour AddStade.xaml
    /// </summary>
    public partial class AddStade : Window
    {
        private BusinessManager BManager;
        public AddStade()
        {
            InitializeComponent();
            BManager = new BusinessManager();
        }

        private void RetourMenu1_Click(object sender, RoutedEventArgs e)
        {
            Menu win = new Menu();
            win.Show();
            this.Close();
        }

        private void Valider_Click(object sender, RoutedEventArgs e) {

            String Valeur_nom = nomStade.Text;
            String Nbr_places = nbrPlaces.Text;
            String Cara1 = Carac1.Text;
            String Cara2 = Carac2.Text;

            try
            {
                int Places = Convert.ToInt32(Nbr_places);
                int Caracteristique1 = Convert.ToInt32(Cara1);
                int Caracteristique2 = Convert.ToInt32(Cara2);

                BManager.ajouter_stade(Places, Valeur_nom);

                textBlock.Text = ("Insertion effectuée.");



            } catch(FormatException er) { textBlock.Text=("Le format des données n'est pas valide."); }


        }


    }
}
