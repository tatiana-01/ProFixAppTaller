namespace Dominio;

    public class CompraProveedor:EntidadGenericaInt
    {
        public Persona Persona {get;set;}
        public string IdProveedor {get;set;}
        public DateTime Fecha {get;set;}
        public decimal Total {get;set;}
        public ICollection<ProductoCompra> ProductosCompras {get;set;}
    }
