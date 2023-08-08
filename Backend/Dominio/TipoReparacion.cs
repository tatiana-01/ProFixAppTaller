namespace Dominio;

    public class TipoReparacion:EntidadGenericaA
    {
        public ICollection<Reparacion> Reparaciones {get;set;}
    }
