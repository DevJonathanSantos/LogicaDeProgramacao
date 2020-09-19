using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LogicaDeProgramacao
{
    public static class Logica
    {
        public static int BuscarSeculoPorAno(int ano)
        {
            var seculo = 0;

            while (ano>=1)
            {
                seculo++;
                ano -= 100;
            }

            return seculo;
        }
        public static List<string> GeradorDeCartelas()
        {
            Random random = new Random();
            List<string> validaor = new List<string>();
            int numero = 0, repetir = 0;
            string vl1 = "", vl2 = "", vl3 = "", vl4 = "", vl5 = "", vl6 = "";

            while (repetir < 20)
            {
                for (int i = 0; i < 6; i++)
                {
                    numero = random.Next(1, 61);

                    if (string.IsNullOrEmpty(vl1)) { vl1 = numero.ToString(); }
                    else if (string.IsNullOrEmpty(vl2)) { vl2 = numero.ToString(); }
                    else if (string.IsNullOrEmpty(vl3)) { vl3 = numero.ToString(); }
                    else if (string.IsNullOrEmpty(vl4)) { vl4 = numero.ToString(); }
                    else if (string.IsNullOrEmpty(vl5)) { vl5 = numero.ToString(); }
                    else if (string.IsNullOrEmpty(vl6)) { vl6 = numero.ToString(); }

                }
                validaor.Add($"Cartela {repetir + 1}: {vl1}-{vl2}-{vl3}-{vl4}-{vl5}-{vl6}  ||");
                vl1 = ""; vl2 = ""; vl3 = ""; vl4 = ""; vl5 = ""; vl6 = "";

                repetir++;
            }
            return validaor;
        }
    }
}
