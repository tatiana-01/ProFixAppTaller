namespace Dominio;

    public class TipoEstado:EntidadGenericaA
    {
        public ICollection<Estado> Estados {get;set;}
    }
