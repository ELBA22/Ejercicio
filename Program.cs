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
using Ejercicio.Entiiens;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Estudiantes>LstCalse = new List<Estudiantes>();

        while (true)
        {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("         MENU PRINCIPAL.             ");
        Console.WriteLine("          MATEMATICAS.               ");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("{0, -10}", "1. registrar estudiante:");
        Console.WriteLine("{0, -10}", "2. Ingresar las notas: ");
        Console.WriteLine("{0, -10}", "3. Ver notas");
        Console.WriteLine("{0, -10}", "4. Salir");
        Console.WriteLine("Ingrese una opcion: ");
        string opcion =  Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Estudiantes(LstCalse);
                    break;

                case "2":
                    Console.WriteLine("{0,-36} {1, -30} {2,-10} {3,-7} {4, -20}", "codigo. Estudiante", "Nombre ", "Email", "Edad", "Direccion");
                    for (int j=0;j<LstCalse.Count;j++)
                    {
                    Console.WriteLine("{0,-36} {1,-30} {2,-10} {3, -7} {4, -20}", LstCalse[j].Codigo, LstCalse[j].Nombre, LstCalse[j].Email, LstCalse[j].Edad, LstCalse[j].Direccion);
                    }
                    Console.ReadKey();
                    break;
                case "3":
                    
                    break;
                case "4":
                    
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
    }

    public static void Estudiantes(List<Estudiantes>LstCalse)
    {
            Estudiantes estudiantes = new Estudiantes();
            estudiantes.Codigo = verificarDatos("", 15, "Codigo");
            estudiantes.Nombre = verificarDatos("", 30, "Nombre");
            estudiantes.Email = verificarDatos("", 40, "Email");
            estudiantes.Edad = Convert.ToInt16(verificarDatos("", 4, "Edad"));
            estudiantes.Direccion = verificarDatos("", 40, "Direccion");
            LstCalse.Add(estudiantes);
            Console.Write("Estudiante Agregado correctamente");
            Console.ReadKey();
            Console.Clear();
    }

public static void ingresoNotas()
    {
        Console.WriteLine("Ingrese el codigo del estudiante: ");
        string codigoEstu = Console.ReadLine();
        Estudiantes estudiantes = estudiantes.Find(i => i.codigo == codigoEstu);

        if (estudiantes == null)
        {
            Console.WriteLine("No se ha encontrado ningun estudiante con ese codigo.");
            return;
        }

        Console.WriteLine("Nota de quices (q1, q2, q3, q4):");
        string[]notaQuices = Console.ReadLine().Split();
        foreach(string nota in notaQuices)
        {
            estudiantes.notaQuices.Add(double.Parse(nota));
        }
        Console.WriteLine("Notas de trabajos (t1, t2):");
        string[] notaTrabajos = Console.ReadLine().Split();
        foreach(string nota in notaTrabajos)
        {
            estudiantes.notaTrabajos.Add(double.Parse(nota));
        }

}

    public static string verificarDatos(string data, int lenData, string palabra){
    bool contVeri = true;
    while (contVeri)
    {
        Console.WriteLine($"Ingrese el {palabra} del estudiante: ");
        data = Console.ReadLine();
        if ((data.Length <= lenData) && (data.Length != 0)){
            contVeri = false;
        } else {
            Console.WriteLine($"Ingrese los parametros correctos para {palabra}:");
        }
    }
    return data;
}

/*    public static void verEstudiantes(){
    Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0,-36} {1, -30} {2,-10} {3,-7} {4, -20}", "codigo. Estudiante", "Nombre ", "Email", "Edad", "Direccion");
            for (int j=0;j<LstCalse.Count;j++)
            {
                Console.WriteLine("{0,-36} {1,-30} {2,-10} {3, -7} {4, -20}", LstCalse[j].Codigo, LstCalse[j].Nombre, LstCalse[j].Email, LstCalse[j].Edad, LstCalse[j].Direccion);
            }

            foreach (Estudiantes est in LstCalse){
            Console.WriteLine("{0, 36} {1, -30} {2,-36} {3, 2} {4, -30}", est.Codigo, est.Nombre, est.Email, est.Edad, est.Direccion);
            
   } */



}

