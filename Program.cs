namespace ruleta;
using Figgle;


class Program  {
    public static ManejarArchivos manegador = new ManejarArchivos();
    public static Menu miMenu = new Menu();

    static int NumeroAlAzar(int minimo, int maximo){
        Random numeroRandom = new Random();
        return numeroRandom.Next(minimo, maximo);
    }

    static string SeleccionarEstudianteAlazar(int indice){
        manegador.Ruta = "./src/csv/estudiantes.csv";
        string[] lista = manegador.ArrayDeEstudiantes();

        return lista[indice];   
    }

    static void MostrarListaDeRoles(){
        manegador.Ruta = "./src/csv/roles.csv";
        string[] lista = manegador.ArrayDeRoles();

        for (int i = 0; i < lista.Length; i++){
            Console.WriteLine(FiggleFonts.Small.Render($"{i+1}. {lista[i]}"));
        }
    }
    static void MostrarListaDeEstudiantes(){
        manegador.Ruta = "./src/csv/estudiantes.csv";
        string[] lista = manegador.ArrayDeEstudiantes();

        for (int i = 0; i < lista.Length; i++){
            Console.WriteLine(FiggleFonts.Small.Render($"{i+1}. {lista[i]}"));
        }
    }

    static void Main(string[] args) {  
        string[] opciones = {miMenu.primerOpcion, miMenu.segundaOpcion, miMenu.terceraOpcion};
        int seleccion = 0;
    
        ConsoleKey key;
        do{
            Console.Clear();
            miMenu.MensajeDeBienvenida();
            for (int i = 0; i < opciones.Length; i++){
                if (i == seleccion){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"\n{opciones[i]}\n");
                    Console.ResetColor();
                }else{
                    Console.WriteLine($"   {opciones[i]}");
                }
            }

            key = Console.ReadKey(true).Key;
            
            if (key == ConsoleKey.UpArrow)
                seleccion = (seleccion == 0) ? opciones.Length - 1 : seleccion - 1;
            else if (key == ConsoleKey.DownArrow)
                seleccion = (seleccion == opciones.Length - 1) ? 0 : seleccion + 1;
        } while (key != ConsoleKey.Enter);

        Console.Clear();
        Console.WriteLine($"Has seleccionado: {opciones[seleccion]}");
        if(opciones[seleccion] == opciones[0]){
            MostrarListaDeEstudiantes();
        }else if(opciones[seleccion] == opciones[1]){
            MostrarListaDeRoles();
        }else if(opciones[seleccion] == opciones[2]){
            manegador.Ruta = "./src/csv/estudiantes.csv";
            NumeroAlAzar(0,manegador.TotalItemsCSV());
        }
    }
}
