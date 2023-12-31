using System.Collections;
using Ejercicio;

namespace Ejercicio.Entiiens
{
    public class Estudiante:Boletin
    {
        private string code;
        private string nombre;
        private string email;
        private string direccion;
        private byte edad;

        public Estudiante():base()
        {
        }

        public Estudiante(string Id, string Nombre, string Email, string Direccion, byte Edad, 
        List<float> quices, List<float>  trabajos, List<float> parciales):base(quices, trabajos, parciales)
        {
            this.code = Id;
            this.nombre = Nombre;
            this.email = Email;
            this.direccion = Direccion;
            this.edad = Edad;
            this.Quices = quices;
            this.Trabajos = trabajos;
            this.Parciales = parciales;
        }

        public string Code { get => code; set => code = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public byte Edad { get => edad; set => edad = value; }
    public void InfoEstudiante(List<Estudiante> estudiantes){
        Estudiante estudiante = new Estudiante();
        Console.Write("Codigo: ");
        estudiante.Code = Console.ReadLine();
        Console.Write("Nombre: ");
        estudiante.Nombre = Console.ReadLine();
        Console.Write("Direccion: ");
        estudiante.Direccion = Console.ReadLine();
        Console.Write("Edad: ");
        estudiante.Edad = Convert.ToByte(Console.ReadLine());
        estudiante.Quices = new List<float>();
        estudiante.Trabajos = new List<float>();
        estudiante.Parciales = new List<float>();
        estudiantes.Add(estudiante);
    }

    public void RegistroNota(List<Estudiante> estudiantes, int opcion){
        Console.WriteLine("Ingrese el codigo del estudiante: ");
        string studenCode = Console.ReadLine();
        // Estudiante alumno =  new Estudiante();
        Estudiante alumno = estudiantes.FirstOrDefault(x=>x.Code.Equals(studenCode));
        Console.WriteLine("Por favor ingrese la nota: ");
        switch (opcion)
        {
            case 1:
                alumno.Quices.Add(float.Parse(Console.ReadLine()));
                break;
            case 2:
                alumno.Trabajos.Add(float.Parse(Console.ReadLine()));
                break;
            case 3:
                alumno.Parciales.Add(float.Parse(Console.ReadLine()));
                break;
            default:
                Console.WriteLine("Opcion no valida");
                Console.ReadKey();
                break;
        }
        int idx = estudiantes.FindIndex(p=>p.Code.Equals(studenCode));
        estudiantes[idx] = alumno;
    }
        
    }

}


