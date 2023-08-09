namespace Dominio;

    public class Producto:EntidadGenericaA
    {
        public TipoProducto TipoProducto {get;set;}
        public int IdTipoProducto {get;set;}
        public MarcaProducto MarcaProducto {get;set;}
        public int IdMarcaProducto {get;set;}
        public CalidadProducto CalidadProducto {get;set;}
        public int IdCalidadProducto {get;set;}
        public ICollection<ProductoStock> ProductosStocks {get;set;}
        public ICollection<ProductoCompra> ProductosCompras {get;set;}
    }
