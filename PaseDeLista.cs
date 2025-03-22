namespace ruleta; 
using Figgle;

class PaseListaMenu {
    public static ManejarArchivos manegador = new ManejarArchivos();

    static void PaseDeLista() {
        manegador.Ruta = "./src/csv/estudiantes.csv";
        string[] estudiantes = manegador.ArrayDeEstudiantes();
        string[] asistencia = new string[estudiantes.Length];

        Console.Clear();
        Console.WriteLine(FiggleFonts.Isometric3.Render("Pase de Lista"));

        foreach (string estudiante in estudiantes) {
            int seleccion = 0;
            string[] opciones = { "Presente", "Ausente" };
            ConsoleKey key;

            do {
                Console.Clear();
                Console.WriteLine(FiggleFonts.Small.Render($"{estudiante}"));
                Console.WriteLine(FiggleFonts.Small.Render("¿Está presente?"));

                for (int i = 0; i < opciones.Length; i++) {
                    if (i == seleccion) {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(FiggleFonts.Small.Render($"> {opciones[i]} <"));
                        Console.ResetColor();
                    } else {
                        Console.WriteLine(FiggleFonts.Small.Render($"  {opciones[i]}"));
                    }
                }

                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow || key == ConsoleKey.DownArrow) {
                    seleccion = (seleccion == 0) ? 1 : 0;
                }
            } while (key != ConsoleKey.Enter);

            asistencia[Array.IndexOf(estudiantes, estudiante)] = $"{estudiante} - {opciones[seleccion]}";
        }

        // Guardar la asistencia en un archivo CSV
        File.WriteAllLines("./src/csv/asistencia.csv", asistencia);
        Console.WriteLine(FiggleFonts.Small.Render("Pase de lista completado y guardado en 'asistencia.csv'"));
    }

    public static void MostrarMenuPaseLista() {
        string[] opciones = { "Iniciar Pase de Lista", "Ver Registro de Asistencia", "Volver al Menú Principal" };
        int seleccion = 0;
        ConsoleKey key;

        do {
            Console.Clear();
            Console.WriteLine(FiggleFonts.Larry3d.Render("Pase de Lista"));

            for (int i = 0; i < opciones.Length; i++) {
                if (i == seleccion) {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(FiggleFonts.Small.Render($"> {opciones[i]} <"));
                    Console.ResetColor();
                } else {
                    Console.WriteLine(FiggleFonts.Small.Render($"  {opciones[i]}"));
                }
            }

            key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.UpArrow) {
                seleccion = (seleccion == 0) ? opciones.Length - 1 : seleccion - 1;
            } else if (key == ConsoleKey.DownArrow) {
                seleccion = (seleccion == opciones.Length - 1) ? 0 : seleccion + 1;
            } else if (key == ConsoleKey.Enter) {
                switch (seleccion) {
                    case 0:
                        PaseDeLista();
                        break;
                    case 1:
                        MostrarRegistroDeAsistencia();
                        break;
                    case 2:
                        return;
                }
            }
        } while (true);
    }

    public static void MostrarRegistroDeAsistencia() {
        if (!File.Exists("./src/csv/asistencia.csv")) {
            Console.WriteLine(FiggleFonts.Larry3d.Render("No hay registros de asistencia disponibles."));
        } else {
            string[] asistencia = File.ReadAllLines("./src/csv/asistencia.csv");
            Console.Clear();
            Console.WriteLine(FiggleFonts.Larry3d.Render("Registro de Asistencia"));
            foreach (string linea in asistencia) {
                Console.WriteLine(FiggleFonts.Small.Render(linea));
            }
        }
        Console.WriteLine(FiggleFonts.Larry3d.Render("\nPresiona cualquier tecla para regresar..."));
        Console.ReadKey();
    }
}
