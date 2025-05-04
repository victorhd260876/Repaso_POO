
using System.Runtime.CompilerServices;

namespace ClassSample.Models
{
    public class Persona
    {
        private int _id;
        public int identificacion
        {
            get => _id; 
            set => _id = value;
        }
        private string _name;
        public string nombre
        {
            get => _name;
            set => _name = value;
        }
        private int _depart;
        public int departamento
        {
            get => _depart;
            set => _depart = value;
        }


        public Persona(int identificacion, string  name, int departamento)
        {
            _id = identificacion;
            _name = name;
            _depart = departamento;
        }
    }
}
