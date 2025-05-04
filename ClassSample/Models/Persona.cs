
namespace ClassSample.Models
{
    public class Persona
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public int _departamento { get; set; }


        public Persona(int id, string name, int departamento)
        {
            _id = id;
            _name = name;
            _departamento = departamento;
        }
    }
}
