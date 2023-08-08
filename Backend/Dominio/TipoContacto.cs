namespace Dominio;

    public class TipoContacto:EntidadGenericaA
    {
        public ICollection<Contacto> Contactos {get;set;}
    }
