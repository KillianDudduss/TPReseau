using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;
using StubDataAccessLayer;

namespace BusinessLayer
{
    public class BusinessManager
    {
		DalManager Manager;

        public BusinessManager()
        {
            Manager = new DalManager();
        }

        public List<String> getStade() {
			var query = from stade in Manager.LsStade
						select stade.Nom;
			return query.ToList();
		}

		public List<String> getPokemonByElem(ETypeElement elem) {
			var query = from pokemonElem in Manager.getPokemonByElement(elem)
						select pokemonElem.Nom;
			return query.ToList();
		}

		public List<String> getPokemonForceVie() {
            //var query = from pokemon in Manager.LsPokemon
            //			where pokemon.Caracteristiques[(int)ECaracteristique.VIE] > 50 &&
            //				  pokemon.Caracteristiques[(int)ECaracteristique.FORCE] > 3
            //			select pokemon.Nom;

            var query = from pokemon in Manager.LsPokemon
                        select pokemon.Nom;

            return query.ToList();
		}


        public List<String> getMatch()
        {
            var query = from Match in Manager.LsMatch
                        select Match.ToString();
            return query.ToList();
        }


        public List<String> getCara()
        {
            var query = from Pokemon in Manager.LsPokemon
                        select Pokemon.Caracteristiques;
            return query.ToList();
        }


        public List<String> getBonus()
        {
            var query = from Pokemon in Manager.LsPokemon
                        select Pokemon.TypeElement;
            return query.ToList();
        }


        public bool CheckConnexionUser(string name, string password)
        {
            bool verif=false;
            Utilisateur user = Manager.GetUtilisateurByLogin(login);
            if (user!=null)
            {
                if(user.getPassword()==password)
                {
                    verif = true;
                }
            }
            return verif;
        }


        public bool Add_Stade(String name, int number)
        {
            Stade = new Stade(int number, String name)
        }
}
