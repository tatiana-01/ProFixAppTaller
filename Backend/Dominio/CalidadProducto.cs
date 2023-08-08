namespace Dominio;

    public class CalidadProducto:EntidadGenericaA
    {
        public ICollection<Producto> Productos {get;set;}
    }
