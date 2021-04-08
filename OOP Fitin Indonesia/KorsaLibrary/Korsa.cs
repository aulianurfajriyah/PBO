using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorsaLibrary
{
    public class Korsa
    {
        public int EstimatePrice(int JumlahItem,int JumlahTitik, string Bahan)
        {
            int harga = 0;
            if (Bahan == "Nagata")
            {
                if (JumlahTitik == 3)
                {
                    harga = JumlahItem * 100000;
                }
                else if (JumlahTitik == 4)
                {
                    harga = JumlahItem * 105000;
                }
                else if (JumlahTitik == 5)
                {
                    harga = JumlahItem * 110000;
                }

            }
            else if (Bahan == "American")
            {
                if (JumlahTitik == 3)
                {
                    harga = JumlahItem * 105000;
                }
                else if (JumlahTitik == 4)
                {
                    harga = JumlahItem * 110000;
                }
                else if (JumlahTitik == 5)
                {
                    harga = JumlahItem * 115000;
                }
            }
            return harga;
        }
    }
}
