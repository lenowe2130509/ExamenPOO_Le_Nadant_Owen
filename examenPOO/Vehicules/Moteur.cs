using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenPOO
{
    enum refroidissement
    {
        air,
        liquide,
        vapeur,
        autres
    }
    internal class Moteur
    {
        private string marque { get; set; }
        private int force { get; set; }
        refroidissement refroidissement { get; set; }

        public Moteur()
        {
            marque = "Yamaha";
            force = 50;
            refroidissement = refroidissement.air;
        }

        public Moteur(string marque, int force,  refroidissement refroidissement)
        {
            this.marque = marque;
            this.force = force;
            this.refroidissement = refroidissement;
        }

        public static bool operator >(Moteur moteur1, Moteur moteur2)
        {
            return moteur1.force > moteur2.force;
        }

        public static bool operator <(Moteur moteur1, Moteur moteur2)
        {
            return moteur1.force< moteur2.force;
        }

        public override string ToString()
        {
            string moteur = $" Informations sur le moteur :     marque : {marque} \n force : {force} \n refroidissement : {refroidissement}";
            return moteur;

        }
    }
}
