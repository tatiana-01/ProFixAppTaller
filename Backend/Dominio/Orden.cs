namespace Dominio;
    public class Orden:EntidadGenericaInt
    {
        public string Detalles {get;set;}
        public Visita Visita {get;set;}
        public int IdVisita {get;set;}
        public Estado Estado {get;set;}
        public int IdEstado {get;set;}
        public ICollection<Reparacion> Reparaciones {get;set;}
    }
