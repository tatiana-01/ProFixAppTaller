namespace Dominio;

    public class MarcaProducto:EntidadGenericaA
    {
        public ICollection<Producto> Productos {get;set;}
    }
