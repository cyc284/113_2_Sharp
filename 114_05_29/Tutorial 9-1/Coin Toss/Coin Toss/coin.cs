using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Toss
{
    internal class coin
    {
        private string sideUp;
        Random rand = new Random();
        public coin()
        {
            // Initialize the coin to "Heads".
            sideUp = "正面";
        }
        public void toss()
        {



            if (rand.Next(2) == 0)
            {
                sideUp = "正面";
            }

            else
            {
                sideUp = "反面";
            }
        }
            public string GetSideUp()
            {
               
                return sideUp;
            }
        }
    }

