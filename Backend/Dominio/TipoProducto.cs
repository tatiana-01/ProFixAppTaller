namespace Dominio;

    public class TipoProducto:EntidadGenericaA
    {
        public ICollection<Producto> Productos {get;set;}
    }
