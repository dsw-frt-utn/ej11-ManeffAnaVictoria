using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private readonly List<Alumno> listaAlumnos = new List<Alumno>();

    //metodo para agregar alumnos a la lista
    public void AgregarAlumno(Alumno alumno)
    {
        if(alumno != null)
        {
            listaAlumnos.Add(alumno);
        }
    }
    //metodo para obtener lista de alumnos
    public List<Alumno> ObtenerAlumnosLista()
    {
        return listaAlumnos;
    }

    //método para buscar un alumno por nombre
    public Alumno BuscarAlumno(string nombre)
    {
        Alumno encontrado = listaAlumnos.Find(a => a.Nombre == nombre);
        return encontrado;
    }
    
    //Metodo para eliminar un alumno
    public void EliminarAlumno(Alumno alumno)
    {
        if(alumno != null)
        {
            listaAlumnos.Remove(alumno);
        }
    }

    //Metodo para eliminar alumno segun la posicion
    public void EliminarAlumnoPosicion(int pos)
    {
        if(pos >= 0 && pos < listaAlumnos.Count)
        {
            listaAlumnos.RemoveAt(pos);
        }
    }

}
