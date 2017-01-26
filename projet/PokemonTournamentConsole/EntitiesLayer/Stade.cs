using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer {
	public class Stade : EntityObject {
		private int[] Caracteristiques; // Acces aux éléments via l'enum
		private int NbPlaces;
		public String Nom { get; }

		public Stade(int nbPlace, String nom) {
			Caracteristiques = new int[Enum.GetNames(typeof(ECaracteristique)).Length];
			//Stade sans effet particulier par defaut
			foreach (int i in Caracteristiques) {
				Caracteristiques[i] = 0;
			}
			NbPlaces = nbPlace;
			Nom = nom;
		}

		public Stade(int nbPlace, String nom, ECaracteristique caract, int value) {
			Caracteristiques = new int[Enum.GetNames(typeof(ECaracteristique)).Length];
			//Stade sans effet particulier par defaut
			foreach (int i in Caracteristiques) {
				Caracteristiques[i] = 0;
			}
			Caracteristiques[(int)caract] = value;
			NbPlaces = nbPlace;
			Nom = nom;
		}

		public void addCaracteristique(ECaracteristique caract, int value) {
			Caracteristiques[(int)caract] += value;
		}

		public override string ToString() {
			return "Stade : " + Nom + " disposant de " + NbPlaces + " places";
		}
	}
}
