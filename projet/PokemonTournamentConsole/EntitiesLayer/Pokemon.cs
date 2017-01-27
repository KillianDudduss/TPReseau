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

		public Pokemon(String pnom, ETypeElement pelem) {

            Caracteristiques = new int[Enum.GetNames(typeof(ECaracteristique)).Length];
			foreach(int i in Caracteristiques) {
                Caracteristiques[i] = 50;
			}
			Nom = pnom;
			TypeElement = pelem;
		}

		public override String ToString() {
			return ("Pokemon " + TypeElement + " " + Nom + " ; ID " + ID);
		}
	}
}
