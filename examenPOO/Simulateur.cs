using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examenPOO.Clientele;

namespace examenPOO
{
    public static class Simulateur
    {
        private static Random random = new Random();
        private static Concessionaire monConcessionaire = new Concessionaire();

        public void Simuler()
        {

        }

        public void SimulerTransaction(List<Client> clients)
        {
            
        }

        public List<Client> GenererClient()
        {
            List<Client> clientList = new List<Client>();
            int nombreClients = random.Next(2, 6);
            for (int i = 0; i<nombreClients; i++ )
            {
                Client client = new Client();
                Factory.CreerClient();
            }

            return clientList;
        }

    }
}
