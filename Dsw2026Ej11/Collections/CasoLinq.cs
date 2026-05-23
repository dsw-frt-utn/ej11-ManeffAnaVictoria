using Dsw2026Ej11.Domain;
using System.Timers;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private readonly List<Libro> listaLibros = Libro.CrearLista();
    
    //Metodo para obtener el primer libro
    public Libro GetPrimero() => listaLibros.First();
    
    //Metodo para obtener el último libro
    public Libro GetUltimo() => listaLibros.Last();

    //Metodo para obtener la suma de precios de los libros
    public decimal GetTotalPrecios() => listaLibros.Sum(l => l.Precio);
    
    //Metodo para obtener el promedio de precios de los libros
    public decimal GetPromedioPrecios() => listaLibros.Average(l => l.Precio);

    //Metodo para obtener la lista de libros con Id mayor a 15
    public IEnumerable<Libro> GetListById() => listaLibros.Where(l => l.Id > 15);

    //Metodo para obtener una lista de cada libro con su título y precio en formato moneda
    public IEnumerable<String> GetLibros() => listaLibros.Select(l => $"{l.Titulo} - {l.Precio:C}");

    //Metodo para obtener el libro con el precio más alto
    public Libro GetMayorPrecio() => listaLibros.OrderBy(l => l.Precio).Last();

    //Metodo para obtener el libro con el precio más bajo
    public Libro GetMenorPrecio() => listaLibros.OrderBy(l => l.Precio).First();

    //Metodo para obtener los libros cuyo precio sea mayor al promedio
    public IEnumerable<Libro> GetMayorPromedio()
    {
        var promedio = GetPromedioPrecios();
        return listaLibros.Where(l => (l.Precio > promedio));
    }

    //Metodo para obtener los libros ordenados por título de forma descendente
    public IEnumerable<Libro> GetLibrosOrdenadosDescendente() => listaLibros.OrderByDescending(l => l.Titulo);

}
