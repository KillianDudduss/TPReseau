using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer {
	public class Match : EntityObject {
		private int IdPokemonVainqueur;
		EPhaseTournoi PhaseTournoi;
		private Pokemon Pokemon1;
		private Pokemon Pokemon2;
		private Stade Arene;

		//Obligé de surcharger le constructeur si on veut faire
		// Match match = new Match(new Pokemon(...), new Pokemon(...)) ?
		public Match(ref Pokemon pokemon1, ref Pokemon pokemon2, EPhaseTournoi phase = EPhaseTournoi.QuartFinale) {
			PhaseTournoi = phase;
			Pokemon1 = pokemon1;
			Pokemon2 = pokemon2;
		}
		public Match(Pokemon pokemon1, Pokemon pokemon2, EPhaseTournoi phase = EPhaseTournoi.QuartFinale) {
			PhaseTournoi = phase;
			Pokemon1 = pokemon1;
			Pokemon2 = pokemon2;
		}

		public override String ToString() {
			return "Match : " + Pokemon1.Nom + " VS " + Pokemon2.Nom + " . ID = " + ID;
		}
	}
}
