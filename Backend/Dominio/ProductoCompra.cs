namespace Dominio;

    public class ProductoCompra
    {
        public Producto Producto {get;set;}
        public int IdProducto {get;set;}
        public CompraProveedor CompraProveedor {get;set;}
        public int IdCompraProveedor {get;set;}
        public decimal Cantidad {get;set;}
        public string Unidad {get;set;}
        public decimal ValorUnitario {get;set;}
        public decimal ValorTotal {get;set;}
        
    }
