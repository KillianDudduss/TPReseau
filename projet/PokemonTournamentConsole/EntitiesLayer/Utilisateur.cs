using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    public class Utilisateur
    {
        private string nom;
        private string prenom;
        private string login;
        private string password;

        public Utilisateur(string nom, string prenom, string login, string password)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.password = password;
        }

        public string getNom()
        {
            return nom;
        }

        public string getPrenom()
        {
            return prenom;
        }

        public string getLogin()
        {
            return login;
        }

        public string getPassword()
        {
            return password;
        }
    }
}
