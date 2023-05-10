using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenPOO.Clientele
{
    internal class Facture
    {
        private DateTime dateFacturation;
        private vehiculeMotorise voiture;


        public Facture()
        {

        }

        public DateTime DateFacturation
        {
            get { return dateFacturation; }
        }

        public override string ToString()
        {
            string info = dateFacturation.ToShortDateString();
            info += $"le client est : {Factory.CreerClient()} et le véhicule est {voiture.ToString()}";
            return info;
        }

    }
}
