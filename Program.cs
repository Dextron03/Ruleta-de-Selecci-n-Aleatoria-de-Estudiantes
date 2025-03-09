namespace ruleta;
using Figgle;
using System.Diagnostics;

class Program  {
    public static ManejarArchivos manegador = new ManejarArchivos();
    public static Menu miMenu = new Menu();

    static int NumeroAlAzar(int minimo, int maximo){
        Random numeroRandom = new Random();
        return numeroRandom.Next(minimo, maximo);
    }
    
    static void Speak(string phrase){
        if (string.IsNullOrWhiteSpace(phrase)) return;

        string comando = "Add-Type -AssemblyName System.Speech; " +
                         "$speak = New-Object System.Speech.Synthesis.SpeechSynthesizer; " +
                         "$speak.Speak('" + phrase + "')";

        Process.Start(new ProcessStartInfo{
            FileName = "powershell",
            Arguments = $"-Command \"{comando}\"",
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        });
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

    static bool ExisteCombinacion(string[] combinaciones, string nuevaCombinacion) {
        foreach (string combinacion in combinaciones) {
            if (combinacion == nuevaCombinacion) {
                return true;
            }
        }
        return false;
    }

    static void Main(string[] args) {  
        string[] opciones = {miMenu.primerOpcion, miMenu.segundaOpcion, miMenu.terceraOpcion, miMenu.cuartaOpcion};
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
            else if (key == ConsoleKey.Enter) {
                Console.Clear();
                Console.WriteLine(FiggleFonts.Larry3d.Render("Has seleccionado:"));
                Console.WriteLine(opciones[seleccion]);

                if(opciones[seleccion] == opciones[0]){
                    MostrarListaDeEstudiantes();
                }else if(opciones[seleccion] == opciones[1]){
                    MostrarListaDeRoles();
                }else if(opciones[seleccion] == opciones[2]){
                    manegador.Ruta = "./src/csv/estudiantes.csv";
                    string[] estudiantes = manegador.ArrayDeEstudiantes();
                    manegador.Ruta = "./src/csv/roles.csv";
                    string[] roles = manegador.ArrayDeRoles();

                    string[] combinacionesUsadas = File.ReadAllLines("./src/cvs_db/db.csv");
                    
                    if (combinacionesUsadas.Length >= estudiantes.Length * roles.Length){
                        Console.WriteLine(FiggleFonts.Larry3d.Render("\nTodos los estudiantes han sido asignados a un rol. No hay más combinaciones disponibles."));
                        Speak("Todos los estudiantes han sido asignados a un rol.");
                    } else {
                        string estudianteSeleccionado;
                        string rolSeleccionado;
                        string combinacion;

                        do {
                            int indiceEstudiante = NumeroAlAzar(0, estudiantes.Length);
                            int indiceRol = NumeroAlAzar(0, roles.Length);
                            estudianteSeleccionado = estudiantes[indiceEstudiante];
                            rolSeleccionado = roles[indiceRol];
                            combinacion = $"{estudianteSeleccionado}-{rolSeleccionado}";
                        } while (ExisteCombinacion(combinacionesUsadas, combinacion)); // Usamos la función para verificar repeticiones

                        manegador.GuardarEstudiateRol(estudianteSeleccionado, rolSeleccionado);
                        Speak($"El estudiante seleccionado es {estudianteSeleccionado} - Rol: {rolSeleccionado}");
                        Console.WriteLine(FiggleFonts.Doom.Render($"El estudiante seleccionado es {estudianteSeleccionado} - {rolSeleccionado}"));
                    }
                } 
                else if (opciones[seleccion] == opciones[3]){
                    break;
                }

                Console.WriteLine(FiggleFonts.Larry3d.Render("\nPresiona cualquier tecla para continuar..."));
                Console.ReadKey();
            }
        } while (true);
    }
}
