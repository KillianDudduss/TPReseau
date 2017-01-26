using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer {
	public class Dresseur : EntityObject {
		private String _nom;
		private String Nom {
			get {
				return _nom;
			}
			set {
				_nom = Nom;
			}
		}
		private int Score;

		public Dresseur(String nom) {
			_nom = nom;
			Score = 0;
		}

		public override string ToString() {
			return "Dresseur : " + Nom + " | score : " + Score + " points";
		}
	}
}
