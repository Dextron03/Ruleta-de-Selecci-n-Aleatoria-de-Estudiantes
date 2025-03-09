using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ruleta;

public class ManejarArchivos {
    public string Ruta="";

    public void GuardarEstudiateRol(string estudiante, string rol){
        using (StreamWriter escritor = new StreamWriter("./src/cvs_db/db.csv", true)) { // `true` para agregar sin borrar
            escritor.WriteLine($"{estudiante}-{rol}");
        }
    }

    public int TotalItemsCSV(){
        int total= 0;
        using (StreamReader lector = new StreamReader(this.Ruta)) {
            while (!lector.EndOfStream) {
                string linea = lector.ReadLine()!;
                total++;
            }
        }
        return total;
    }

    public string[] ArrayDeEstudiantes(){
        string[] arrayEstudiaentes = new string[TotalItemsCSV()];
        int contador = 0;

        using (StreamReader lector = new StreamReader(this.Ruta)) {
            while (!lector.EndOfStream) {
                string linea = lector.ReadLine()!;
                arrayEstudiaentes[contador] = linea;
                contador++;
            }
        }

        return arrayEstudiaentes;
    }

    public string[] ArrayDeRoles(){
        string[] arrayRoles = new string[TotalItemsCSV()];
        int contador = 0;

        using (StreamReader lector = new StreamReader(this.Ruta)) {
            while (!lector.EndOfStream) {
                string linea = lector.ReadLine()!;
                arrayRoles[contador] = linea;
                contador++;
            }
        }

        return arrayRoles;
    }

}

