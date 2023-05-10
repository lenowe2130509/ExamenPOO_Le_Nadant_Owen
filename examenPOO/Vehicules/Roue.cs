using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenPOO
{
    internal class Roue
    {
        private string marque { get; set; }
        private int grandeur { get; set; }

        public Roue()
        {

        }

        public Roue(string marque, int grandeur)
        {
            this.marque = marque;
            this.grandeur = grandeur;
        }

        public override string ToString()
        {
            string roue = $"La marque des roues est : {marque}. \n La grandeur est de: {grandeur}";
            return roue;

        }
    }
}
