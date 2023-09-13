using System.Text.Json.Serialization;
using System.Xml;
using Ejercicio.Entiiens;
using Newtonsoft.Json;

namespace Boletin;

    public class MisFunciones
    {
        public static byte MenuNotas(){
            Console.WriteLine("1. REGISTRO DE QUICES");
            Console.WriteLine("2. REGISTRO DE TRABAJOS");
            Console.WriteLine("3. REGISTRO DE PARCIALES");
            Console.WriteLine("0. REGRESAR AL MENU PRINCIPAL");
            Console.Write("Opcion: ");
            return Convert.ToByte(Console.ReadLine());
        }
        public static byte Reportes (){
            Console.WriteLine("1. NOTAS DEL GRUPO");
            Console.WriteLine("2. NOTAS FINALES");
            Console.WriteLine("0. REGRESAR AL MENU PRINCIPAL");
            Console.Write("Opcion: ");
            return Convert.ToByte(Console.ReadLine());
        }
        public static void SaveData(List<Estudiante> lstListado)
        {
            string json = JsonConverter.SerializeObject(lstListado, Formatting.Indented);
            File.WriteAllText("boletin.json", json);
        }
         public static List<Estudiante> LoadData()
    {
        using (StreamReader reader = new StreamReader("boletin.json"))
        {
            string json = reader.ReadToEnd();
            return System.Text.Json.JsonSerializer
            .Deserialize<List<Estudiante>>(json, new System.Text.Json.JsonSerializerOptions()
            { PropertyNameCaseInsensitive = true }) ?? new List<Estudiante>();
        }
    }
        public static byte MenuPrincipal() {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("         MENU PRINCIPAL.             ");
            Console.WriteLine("          MATEMATICAS.               ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1.        registrar estudiante:      ");
            Console.WriteLine("2.        Registro de las notas:     ");
            Console.WriteLine("3.            Ver notas              ");
            Console.WriteLine("4.               Salir               ");
            Console.WriteLine("Ingrese una opcion: ");
            return Convert.ToByte(Console.ReadLine());

        }
        

    }