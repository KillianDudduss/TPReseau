using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer {
	public class Pokemon : EntityObject {
		public int[] Caracteristiques { get; }
		public ETypeElement TypeElement { get; set; }
		public String Nom { get; }

		public Pokemon(String nom, ETypeElement elem) {
			Caracteristiques = new int[Enum.GetNames(typeof(ECaracteristique)).Length];
			foreach(int i in Caracteristiques) {
				Caracteristiques[i] = 42;
			}
			Nom = nom;
			TypeElement = elem;
			//Caracteristiques[(int)ECaracteristique.VIE]
		}

		public override String ToString() {
			return "Je m'appelle " + Nom + " et je suis de type " + TypeElement + ". Mon identifiant est " + ID;
		}
	}
}
