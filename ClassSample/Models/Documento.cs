using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample.Models
{
    public class Documento
    {
        public string _tipo { get; set; }
        public string _correlativo {  get; set; }
        public double _valor {  get; set; }


        public Documento(string tipo, string correlativo, double valor)
        {
            _tipo = tipo;
            _correlativo = correlativo;
            _valor = valor;
        }
    }
}
