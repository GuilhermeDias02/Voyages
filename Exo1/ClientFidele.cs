using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{
    public class ClientFidele : Client
    {
        private static int reduc = 10;

        public ClientFidele(int unId, string unNom, string unPrenom, string uneAdresse, string unMail) : base(unId, unNom, unPrenom, uneAdresse, unMail)
        {
            
        }
    }
}
