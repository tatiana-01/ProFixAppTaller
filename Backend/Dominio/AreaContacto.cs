namespace Dominio;

    public class AreaContacto:EntidadGenericaA
    {
        public ICollection<Contacto> Contactos {get;set;}
    }
