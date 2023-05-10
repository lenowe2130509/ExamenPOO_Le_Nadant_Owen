using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenPOO
{
    internal class Enfant
    {
        private vehiculeMotorise vehicule = new vehiculeMotorise();
        
        public Enfant()
        {
            vehiculeMotorise vehicule = new vehiculeMotorise();
        }

        public override string ToString()
        {
            string enfant = "";
            enfant += "Voici le véhicule ! " + vehicule.ToString() ;
            return enfant;
        }
    }
}
