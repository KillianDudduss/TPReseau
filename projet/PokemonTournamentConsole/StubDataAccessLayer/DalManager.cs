using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;

namespace StubDataAccessLayer
{
	public class DalManager {
		public List<Pokemon> LsPokemon { get; set; }
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
			LsPokemon = new List<Pokemon>();
            LsPokemon.Add(new Pokemon("Pika", ETypeElement.Electrique)); //ajoute pokemon temporaire pour test
            LsPokemon.Add(new Pokemon("Samlaleche", ETypeElement.Feu));
            LsPokemon.Add(new Pokemon("Carapute", ETypeElement.Insecte));
            LsDresseur = new List<Dresseur>();
            LsDresseur.Add(new Dresseur("Freddy"));
			LsMatch = new List<Match>();
            LsMatch.Add(new Match(new Pokemon("Pika", ETypeElement.Electrique), new Pokemon("raichu", ETypeElement.Electrique), EPhaseTournoi.DemiFinale));
			LsStade = new List<Stade>();
            LsStade.Add(new Stade(200, "Ligue"));
            LsCaractéristique = new List<ECaracteristique>();
		}

        public Utilisateur GetUtilisateurByLogin(String plogin)
        {
            var query = from user in LsUtilisateur
                        where user.getLogin() == plogin
                        select user;
            return (Utilisateur)query;
        }
    }
}
