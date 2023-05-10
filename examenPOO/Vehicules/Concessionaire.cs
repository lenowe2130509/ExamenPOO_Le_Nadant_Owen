using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenPOO
{
    internal class Concessionaire
    {
        private string nom { get; set; }
        private List<vehiculeMotorise> vehicules = new List<vehiculeMotorise>();
        private double MontantArgent { get; set; }

        public Concessionaire()
        {

        }

        public void AjouterVehicule(vehiculeMotorise vehicule)
        {
            foreach(vehiculeMotorise vehiculeMotorise in vehicules)
            {
                vehicules.Add(vehicule);
            }
        }

        public void VendreVehicule(vehiculeMotorise vehicule)
        {

        }

        public void RemplirInventaire()
        {
            //MOTOMARINE
            vehicules.Add(new Motomarine("Spark", "BRP", 12000, new Moteur()));
            vehicules.Add(new Motomarine("Spark GTI", "BRP", 16000, new Moteur()));
            vehicules.Add(new Motomarine("renault", "Yamaha", 14000, new Moteur()));
            vehicules.Add(new Motomarine("GEGE", "League", 18000, new Moteur("V", 50, refroidissement.air)));
            vehicules.Add(new Motomarine("Over", "Yamaha", 14500, new Moteur("X", 150, refroidissement.liquide)));
            vehicules.Add(new Motomarine("Vincent", "Blizzard", 5000, new Moteur()));

            //VTT
            vehicules.Add(new VTT("Spark", "BP", 12000, new Moteur()));
            vehicules.Add(new VTT("olivier", "Carglass", 12000, new Moteur("Meilleur", 5000, refroidissement.autres)));
            vehicules.Add(new VTT("Spar", "B", 12000, new Moteur()));
            vehicules.Add(new VTT("Spa", "R", 12000, new Moteur("pour", 100, refroidissement.air)));
            vehicules.Add(new VTT("Sp", "P", 12000, new Moteur()));
            vehicules.Add(new VTT("S", "BR", 12000, new Moteur("aie", 5, refroidissement.vapeur)));
            vehicules.Add(new VTT("Jo", "RP", 12000, new Moteur()));
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
