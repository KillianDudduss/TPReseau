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
        public DalManager Manager { get; set; }

        public BusinessManager() {
            Manager = new DalManager();
        }

        public List<Pokemon> getPokemon() {
            return Manager.LsPokemon;
        }

        public List<Stade> getStade() {
                return Manager.LsStade;
        }

        public List<Match> getMatch() {
            return Manager.LsMatch;
        }

        public List<String> getPokemonByElem(ETypeElement elem) {
			var query = from pokemonElem in Manager.getPokemonByElement(elem)
						select pokemonElem.Nom;
			return query.ToList();
		}

		public List<String> getPokemonForceVie() {
			var query = from pokemon in Manager.LsPokemon
						where pokemon.Caracteristiques[(int)ECaracteristique.VIE] > 30 &&
							  pokemon.Caracteristiques[(int)ECaracteristique.FORCE] > 3
						select pokemon.Nom;
			return query.ToList();
		}

        public bool CheckConnexionUser(string login, string password)
        {
            bool verif=false;
            try
            {
                Utilisateur user = Manager.GetUtilisateurByLogin(login);
                if (user != null)
                {
                    if (user.getPassword() == password)
                    {
                        verif = true;
                    }
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

            return verif;
        }

        public void ajouter_stade(int nbr, String name)
        {
            Manager.LsStade.Add(new Stade(nbr, name));
        }
    }
}
