using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenPOO.Clientele
{
    public static class Factory
    {
        private static string[] Noms = { "Alice", "Bob", "Charlie", "David", "Eve" };

        private static Random random = new Random();

        public static Client CreerClient()
        {
            string nom = Noms[random.Next(Noms.Length)];
            double montantArgent = (double)random.Next(5000, 50000);

            return new Client
            {
                nom = nom,
                montant = montantArgent
            };
        }
    }
}
