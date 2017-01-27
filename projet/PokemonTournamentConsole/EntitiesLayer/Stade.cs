using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer {
	public class Stade : EntityObject {
        public int[] Caracteristiques { get; set; }
        public int NbPlaces { get; set; }
        public String Nom { get; }

		public Stade(int pnbPlaces, String pnom) {
			Caracteristiques = new int[Enum.GetNames(typeof(ECaracteristique)).Length];
			foreach (int i in Caracteristiques) {
				Caracteristiques[i] = 0;
			}
			NbPlaces = pnbPlaces;
			Nom = pnom;
		}

		public Stade(int pnbPlaces, String pnom, ECaracteristique pcarac, int pbonus) {
			Caracteristiques = new int[Enum.GetNames(typeof(ECaracteristique)).Length];
			foreach (int i in Caracteristiques) {
				Caracteristiques[i] = 0;
			}
			Caracteristiques[(int)pcarac] = pbonus;
			NbPlaces = pnbPlaces;
			Nom = pnom;
		}

		public void addCaracteristique(ECaracteristique pcarac, int pbonus) {
			Caracteristiques[(int)pcarac] += pbonus;
		}

		public override string ToString() {
			return ("Stade " + Nom + " " + NbPlaces + " places");
		}
	}
}
