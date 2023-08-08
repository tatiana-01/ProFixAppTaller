
namespace Dominio;

    public class Sucursal:EntidadGenericaA
    {
        public Ciudad Ciudad {get;set;}
        public int IdCiudad {get;set;}
        public ICollection<Empleado> Empleados {get;set;}
        public ICollection<ProductoStock> ProductosStocks {get;set;}
    }
