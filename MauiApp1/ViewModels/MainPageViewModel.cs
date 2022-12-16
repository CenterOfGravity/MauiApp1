using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    internal class MainPageViewModel
    {
        public string Suma(string A, string B)
        {
            string Resultado = (Int64.Parse(A) + Int64.Parse(B)).ToString();
            return Resultado;
        }

        public string Resta(string A, string B)
        {
            string Resultado = (Int64.Parse(A) - Int64.Parse(B)).ToString();
            return Resultado;
        }
    }
}
