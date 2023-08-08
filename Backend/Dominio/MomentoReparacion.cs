namespace Dominio;

    public class MomentoReparacion:EntidadGenericaA
    {
        public ICollection<Reparacion> Reparaciones {get;set;}
    }
