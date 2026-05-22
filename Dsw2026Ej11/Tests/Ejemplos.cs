using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        var a1 = new Alumno(123, "Mario", 9.52);
        var a2 = new Alumno(456, "Lourdes", 8.50);
        var a3 = new Alumno(789, "Juan", 5.20);

        CasoList casoList = new CasoList();

        casoList.AgregarAlumno(a1);
        casoList.AgregarAlumno(a2);
        casoList.AgregarAlumno(a3);

        //Listar por consola los alumnos
        Console.WriteLine("\nAlumnos Cargados:");
        foreach(var alumno in casoList.ObtenerAlumnosLista())
        {
            Console.WriteLine(alumno);
        }
        Console.WriteLine("\n\t---------");

        //Buscar por nombre un alumno que exista y mostrar por consola
        Console.WriteLine("\nBuscamos un alumno: Mario");
        var encontrado = casoList.BuscarAlumno("Mario");
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "El alumno no existe");
        Console.WriteLine("\n\t---------");

        //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
        Console.WriteLine("\nBuscamos un alumno: Natalia");
        var noEncontrado = casoList.BuscarAlumno("Natalia");
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "El alumno no existe");
        Console.WriteLine("\n\t---------");

        //Eliminar un alumno y listar por consola los alumnos
        Console.WriteLine("\nEliminamos un alumno: Mario");
        casoList.EliminarAlumno(a1);
        Console.WriteLine("Listamos Alumnos: ");
        foreach (var alumno in casoList.ObtenerAlumnosLista())
        {
            Console.WriteLine(alumno);
        }
        Console.WriteLine("\n\t---------");

        //Eliminar el primer elemento de la lista y listar por consola los alumnos
        Console.WriteLine("\nEliminamos el primer alumno");
        casoList.EliminarAlumnoPosicion(0);
        Console.WriteLine("Listamos Alumnos: ");
        foreach (var alumno in casoList.ObtenerAlumnosLista())
        {
            Console.WriteLine(alumno);
        }
        Console.WriteLine("\n\t---------");
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var a1 = new Alumno(123, "Mario", 9.52);
        var a2 = new Alumno(456, "Lourdes", 8.50);
        var a3 = new Alumno(789, "Juan", 5.20);

        CasoDictionary casoDiccin = new CasoDictionary();

        casoDiccin.AgregarAlumnoDiccionario(a1);
        casoDiccin.AgregarAlumnoDiccionario(a2);
        casoDiccin.AgregarAlumnoDiccionario(a3);

        //Listar por consola los alumnos
        Console.WriteLine("\nListar Diccionario");
        foreach(KeyValuePair<int, Alumno> k in casoDiccin.ObtenerDiccionario())
        {
            Console.WriteLine($"{k.Key} - {k.Value}");
        }
        Console.WriteLine("\n\t---------");

        //Buscar un alumno por clave y mostrar por consola
        Console.WriteLine("\nBuscar -> Clave: 123");
        var encontrado = casoDiccin.BuscarAlumnoDiccionario(123);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "El alumno no existe");
        Console.WriteLine("\n\t---------");

        //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
        Console.WriteLine("\nBuscar -> Clave: 222");
        var noEncontrado = casoDiccin.BuscarAlumnoDiccionario(222);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "El alumno no existe");
        Console.WriteLine("\n\t---------");

        //Eliminar un alumno por clave y listar por consola los alumnos
        Console.WriteLine("\nEliminar -> Clave: 123");
        casoDiccin.EliminarAlumnoDiccionario(123);
        foreach(var k in casoDiccin.ObtenerDiccionario())
        {
            Console.WriteLine($"{k.Key} - {k.Value}");
        }
        Console.WriteLine("\n\t---------");
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        // 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros)
        Console.WriteLine("\nLista Libros: \n");
        foreach (var libro in casoLinq.GetLibros())
        {
            Console.WriteLine($"- {libro}\n");
        }
        Console.WriteLine("\n\t---------");

        // 1. Obtener el primer libro (GetPrimero)
        Console.WriteLine($"\nPrimer Libro: {casoLinq.GetPrimero().Titulo}");
        Console.WriteLine("\n\t---------");

        // 2. Obtener el último libro (GetUltimo)
        Console.WriteLine($"\nUltimo Libro: {casoLinq.GetUltimo().Titulo}");
        Console.WriteLine("\n\t---------");

        // 3. Obtener la suma de precios (GetTotalPrecios)
        Console.WriteLine($"\nTotal precio de libros: {casoLinq.GetTotalPrecios():C}");
        Console.WriteLine("\n\t---------");

        // 4. Obtener el promedio de precios (GetPromedioPrecios)
        Console.WriteLine($"\nPromedio precio de libros: {casoLinq.GetPromedioPrecios():C}");
        Console.WriteLine("\n\t---------");

        // 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
        Console.WriteLine("\nLibros con ID mayor a 15: \n");
        foreach(var libro in casoLinq.GetListById())
        {
            Console.WriteLine($"- {libro.Id} : {libro.Titulo}\n");
        }
        Console.WriteLine("\n\t---------");

        // 7. Obtener el libro con el precio más alto (GetMayorPrecio)
        Console.WriteLine($"\nLibro mas caro: {casoLinq.GetMayorPrecio().Titulo} - {casoLinq.GetMayorPrecio().Precio:C}");
        Console.WriteLine("\n\t---------");

        // 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
        Console.WriteLine($"\nLibro mas barato: {casoLinq.GetMenorPrecio().Titulo} - {casoLinq.GetMenorPrecio().Precio:C}");
        Console.WriteLine("\n\t---------");

        // 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
        Console.WriteLine("\nLibros cuyos precios son mayor al promedio: \n");
        foreach(var libro in casoLinq.GetMayorPromedio())
        {
            Console.WriteLine($"- {libro.Titulo}: {libro.Precio:C}\n");
        }
        Console.WriteLine("\n\t---------");

        // 10. Obtener los libros ordenados por título de forma descendente
        Console.WriteLine("\nLibros ordenados de forma decendente (Z - A): \n");
        foreach (var libro in casoLinq.GetLibrosOrdenadosDescendente())
        {
            Console.WriteLine($"- {libro.Titulo}\n");
        }
        Console.WriteLine("\n\t---------");
    }
}
