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
			var query = from pokemon in Manager.LsPokemon
						where pokemon.Caracteristiques[(int)ECaracteristique.VIE] > 50 &&
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
    }
}
