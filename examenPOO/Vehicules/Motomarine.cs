using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenPOO
{
    internal class Motomarine : vehiculeMotorise
    {
        private string type;

        public Motomarine(string nom, string marque, int prix, Moteur moteur, string type = "SeaDoo") : base(nom, marque, prix, moteur)
        {
            this.type = type;
        }

        public override string ToString()
        {
            string Motomarine = "";
            Motomarine += $"Motomarine \n   Le prix d'une Motomarine est de : {prix}. \n Sa marque est : {marque}. \n Son nom est : {nom} \n Son moteur est : {moteur} \n Son type est : {type}";
            return Motomarine;
        }
    }
}
