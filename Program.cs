/* El profesor del area de matematicas necesita generar un programa
que le permita registrar los estudiantes que se enncuentran matriculados, la informacion
del docente que posee de cada estudiante es la siguiente:
codigo del estudiante con una longitud maxima de 15 caracteres.
nombre del estudiante con una longitud maxima de 40 caracteres.
correo electronico del estudiante con una cantidad maxima de 40 caracteres.
edad del estudiate.
y direccion con una longitu de 35 caracteres.

No se conoce la cantidad de estudiantes que se registraron en la asignatura.
La universidad tiene como norma que cada estudiante debe presentar 4 quices, 2 trabajos y 3 parciales.
Las notas de los quices equivalen al 25%
los trabajos equivalen al 15%
y los parciales al 60%
el programa debe permitirle al profesor generar los siguientes reportes: 
Listado general de notas del grupo.
paginado por id del estudiante.

----------------------------------------------------------------
codigo  nombre       quices         trabajos   parciales
                    q1  q2 q3 q4     t1 t2     p1 p2 p3
----------------------------------------------------------------
Notas finales.
codigo- nombre - def quices - def trabajos - def praciales - nota final
--------------------------------------------------------------------------
el programa debe permitirle al docente realizar todo el proceso de de registro de notas de quices,
trabajos y parciales.
 */


using System.Xml.Serialization;
using Boletin;
using Ejercicio.Entiiens;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Estudiante>estudiantes = new List<Estudiante>();
        Estudiante student = new Estudiante();
        bool cicloMenu = true;
        while (cicloMenu)
        {
            
            byte opcion= MisFunciones.MenuPrincipal();
            switch (opcion){

                case 1:
                    student.InfoEstudiante(estudiantes);
                    break;

                case 2:
                    bool cicloNotas = true;
                    while (cicloNotas){
                        Console.Clear();
                    byte opcionNotas = MisFunciones.MenuNotas();
                    if(opcionNotas != 0)
                        student.RegistroNota(estudiantes,opcionNotas);
                    }
                    break;
                case 3:
                    bool cicloReportes = true;
                    while (cicloReportes){
                        Console.Clear();
                        byte opcionRegistro = MisFunciones.Reportes();
                        switch (opcionRegistro){
                        case 1:
                            Console.Clear();
                            break;
                        case 2:
                            Console.Clear();
                            break;
                        case 0:
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Opcion invalida");
                            Console.Write("Presione Enter para volver a intentarlo: ");
                            Console.ReadKey();
                            break;

                        }
                    }
                    
                    break;
                case 4:
                    cicloMenu = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    Console.Write("Presecione Enter para volver a ingresar: ");
                    Console.ReadKey();
                    break;
            }
        }
    }

/*   public static void Estudiante(List<Estudiante>LstCalse)
    {
            Estudiante estudiante = new Estudiante();
            estudiante.Codigo = verificarDatos("", 15, "Codigo");
            estudiante.Nombre = verificarDatos("", 30, "Nombre");
            estudiante.Email = verificarDatos("", 40, "Email");
            estudiante.Edad = Convert.ToInt16(verificarDatos("", 4, "Edad"));
            estudiante.Direccion = verificarDatos("", 40, "Direccion");
            LstCalse.Add(estudiante);
            Console.Write("Estudiante Agregado correctamente");
            Console.ReadKey();
            Console.Clear();
    } */

    


/*    public static void verEstudiante(){
    Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0,-36} {1, -30} {2,-10} {3,-7} {4, -20}", "codigo. Estudiante", "Nombre ", "Email", "Edad", "Direccion");
            for (int j=0;j<LstCalse.Count;j++)
            {
                Console.WriteLine("{0,-36} {1,-30} {2,-10} {3, -7} {4, -20}", LstCalse[j].Codigo, LstCalse[j].Nombre, LstCalse[j].Email, LstCalse[j].Edad, LstCalse[j].Direccion);
            }

            foreach (Estudiante est in LstCalse){
            Console.WriteLine("{0, 36} {1, -30} {2,-36} {3, 2} {4, -30}", est.Codigo, est.Nombre, est.Email, est.Edad, est.Direccion);
            
   } */


}

