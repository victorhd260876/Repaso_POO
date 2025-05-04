using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    public class Vivienda
    {
    //parametros
        private string _tipo;
        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        private string _direccion;
        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        
        private string _distrito;
        public string distrito
        {
            get { return _distrito; }
            set { _distrito = value; }
        }

        //constructor
        public Vivienda(string direccion, string distrito)
        {
            _tipo = tipo;
            _direccion = direccion;
            _distrito = distrito;

        }

    }
}
