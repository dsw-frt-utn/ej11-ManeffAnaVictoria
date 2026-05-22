using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private readonly Dictionary<int, Alumno> diccionarioAlumno = new Dictionary<int, Alumno>();

    //Método para agregar un alumno al diccionario
    public void AgregarAlumnoDiccionario(Alumno alumno)
    {
        if(alumno != null)
        {
            diccionarioAlumno.Add(alumno.Id, alumno);
        }
    }

    //Método para buscar un alumno utilizando la clave
    public Alumno BuscarAlumnoDiccionario(int legajo)
    {
        if(diccionarioAlumno.ContainsKey(legajo))
        {
            return diccionarioAlumno[legajo];
        }

        return null;
    }

    //Método para retornar el diccionario
    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return diccionarioAlumno;
    }

    //Método para eliminar un alumno utilizando la clave
    public void EliminarAlumnoDiccionario(int legajo)
    {
        diccionarioAlumno.Remove(legajo);
    }
}
