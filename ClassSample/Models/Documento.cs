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
        private string _tipo;
        public string tipo
        { 
            get => _tipo; 
            set => _tipo = value; 
        }
        private string _correlat;
        public string correlativo
        {
            get => _correlat;
            set => _correlat = value;
        }
        private double _valor;
        public  double valor
        {
            get => _valor; 
            set => _valor = value;
        }


        public Documento(string tipo, string correlativo, double valor)
        {
            _tipo = tipo;
            _correlat = correlativo;
            _valor = valor;
        }
    }
}
