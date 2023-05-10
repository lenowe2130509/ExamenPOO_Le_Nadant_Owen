using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenPOO
{
    internal class VTT : vehiculeMotorise
    {
        private Roue roue = new Roue();

        public VTT(string nom, string marque, int prix, Moteur moteur) : base( nom,  marque,  prix, moteur)
        {
            roue = new Roue("Mavic", 20);
        }

        public VTT(Roue roue)
        {
            this.roue = roue;
        }

        public override string ToString()
        {
            string VTT = base.ToString();
            VTT += $"VTT \n   Le VTT est constitué de {roue}. \n Son prix est de : {prix}. \n Sa marque est : {marque}. \n Son nom est : {nom} \n Son moteur est : {moteur}" + roue.ToString();
            return VTT;
        }
    }
}
