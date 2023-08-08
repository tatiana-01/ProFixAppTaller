namespace Dominio;
    public class Estado:EntidadGenericaA
    {
        public TipoEstado TipoEstado {get;set;}
        public int IdTipoEstado {get;set;}
        public ICollection<Factura> Facturas {get;set;}
        public ICollection<Orden> Ordenes {get;set;}
        public ICollection<Reparacion> Reparaciones {get;set;}
        public ICollection<Visita> Visitas {get;set;}
    }
