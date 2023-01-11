using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoEMC.Indece
{
    internal class IndiceIMC
    {
        public IndiceIMC()
        {
            Grau3 = "Obesidade grau 3";
            Grau2 = "Obesidade grau 2";
            Grau1 = "Obesidade grau 1";
            Sobpeso = "Excessso de peso";
            PesoNormal = "Peso normal";
            AbaixoPeso = "Abaixo do peso normal";      
        }
        public string Grau3 { get; set; }
        public string Grau2 { get; set; }
        public string Grau1 { get; set; }
        public string Sobpeso { get; set; }
        public string PesoNormal { get; set; }
        public string AbaixoPeso { get; set; }
    }
}
