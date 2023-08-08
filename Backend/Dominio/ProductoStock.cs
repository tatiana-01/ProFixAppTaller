namespace Dominio;

    public class ProductoStock:EntidadGenericaInt
    {
        public Producto Producto {get;set;}
        public int IdProducto {get;set;}
        public decimal Cantidad {get;set;}
        public string Unidad {get;set;}
        public decimal PrecioCompra {get;set;}
        public decimal Ganancia {get;set;}
        public decimal PrecioVenta {get;set;}
        public Sucursal Sucursal {get;set;}
        public int IdSucursal {get;set;}
        public string Descripcion {get;set;}
    }
