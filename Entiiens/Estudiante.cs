

namespace Ejercicio.Entiiens
{
    public class Estudiante
    {
        private string codigo;
        private string nombre;
        private string email;
        private int edad;
        private string direccion;
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public int notaquices;

        private int notatrabajos;

        private int notaparciales;


        public int notaQuices
        {
            get { return notaquices; }
            set { notaquices = value; }
        }

        public int notaTrabajos
        {
            get { return notatrabajos; }
            set { notaTrabajos = value; }
        }

        public int notaParciales
        {
            get { return notaparciales; }
            set { notaparciales = value; }
        }



        

        
    }

}

