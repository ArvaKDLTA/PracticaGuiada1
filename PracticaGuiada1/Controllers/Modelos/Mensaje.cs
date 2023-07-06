namespace PracticaGuiada1.Controllers.Modelos
{
    public class Mensaje
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Mensaje(string Nombre, int Edad)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
        }
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
    }

    public class PersonaPuesto:Persona 
    {
        public double Sueldo { get; set; }
        public int PersonaId { get; set; }
    }

    public class Animal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get;set; }

        public Animal(string Nombre, int Edad, string Genero)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Genero = Genero;
        }
    }

    public class Perro : Animal 
    {
        public string Raza { get; set; }
        public string ColorPelo { get; set; }

        public Perro(string Nombre, int Edad, string Genero, string Raza, string ColorPelo) : base (Nombre, Edad, Genero)
        {
            this.Raza = Raza;
            this.ColorPelo = ColorPelo;
        }
    }
}
