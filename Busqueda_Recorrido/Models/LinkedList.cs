namespace EmptyBlazorApp1.Models
{
    public class Nodo
    {
        public int Valor { get; set; }
        public Nodo? Siguiente { get; set; }

        public Nodo(int valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }

    public class LinkedList
    {
        public Nodo? PrimerNodo { get; set; }

        public void Agregar(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            if (PrimerNodo == null)
            {
                PrimerNodo = nuevoNodo;
            }
            else
            {
                Nodo actual = PrimerNodo;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
        }

        // Método para recorrer la lista recursivamente y devolver los valores
        public List<int> RecorridoRecursivo(Nodo? nodo)
        {
            if (nodo == null) return new List<int>();
            var result = RecorridoRecursivo(nodo.Siguiente);
            result.Add(nodo.Valor); // Insertar al inicio para mantener orden
            return result;
        }

        // Método para búsqueda recursiva de un elemento
        public bool BusquedaRecursiva(Nodo? nodo, int objetivo)
        {
            if (nodo == null) return false;
            if (nodo.Valor == objetivo) return true;
            return BusquedaRecursiva(nodo.Siguiente, objetivo);
        }
    }
}