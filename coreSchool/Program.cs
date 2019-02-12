using System;

namespace coreSchool
{
    class School
    {
        public string nombre;
        public string direccion;
        public int añoFundacion;
        public string ceo;

        public void Timbrar()
        {
            Console.Beep(10000, 3000);
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School();
            school.nombre="Platzi";
            school.direccion="Address";
            school.añoFundacion=2012;
            Console.WriteLine("TIMBRAR");
            //school.Timbrar();
        }
    }
}
