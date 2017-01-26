using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;

namespace StubDataAccessLayer
{
	public class DalManager {
		public List<Pokemon> LsPokemon { get; }
		public List<Dresseur> LsDresseur { get; }
		public List<Match> LsMatch { get; }
		public List<Stade> LsStade { get; }
		public List<ECaracteristique> LsCaractéristique { get; }
        public List<Utilisateur> LsUtilisateur { get; }

		public IList<Pokemon> getPokemonByElement(ETypeElement elem) {
			var query = from pokemon in LsPokemon
						where pokemon.TypeElement == elem
						select pokemon;
			return query.ToList();
		}

		public DalManager() {
			List<Pokemon> LsPokemon = new List<Pokemon>();
			List<Dresseur> LsDresseur = new List<Dresseur>();
			List<Match> LsMatch = new List<Match>();
			List<Stade> LsStade = new List<Stade>();
			List<ECaracteristique> LsCaractéristique = new List<ECaracteristique>();
		}

        public Utilisateur GetUtilisateurByLogin(string login)
        {
            var query = from user in LsUtilisateur
                        where user.getLogin() == login
                        select user;
            return (Utilisateur)query;
        }
    }
}
