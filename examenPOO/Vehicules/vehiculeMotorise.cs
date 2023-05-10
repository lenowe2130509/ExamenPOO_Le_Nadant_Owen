using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenPOO
{
    internal class vehiculeMotorise
    {
        protected string nom { get; set; }
        protected string marque { get; set; }
        protected int prix { get; set; }
        public Moteur moteur = new Moteur();

        public vehiculeMotorise(string nom, string marque, int prix, Moteur moteur)
        {
            this.nom = nom;
            this.marque = marque;
            this.prix = prix;
            this.moteur = moteur;
        }

        public vehiculeMotorise()
        {
            
        }

        public override string ToString()
        {
            string vehicule = "";
            vehicule += base.ToString();
            vehicule += $"Le nom : {nom}, la marque {marque} et le prix {prix} \n" ;
            return vehicule;
        }

        public void comparaisonMoteur()
        {
            
        }
    } 
}
