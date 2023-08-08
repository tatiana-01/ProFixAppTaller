namespace Dominio;

    public class Contacto:EntidadGenericaInt
    {
        public string ContactoPersona {get;set;}
        public TipoContacto TipoContacto {get;set;}
        public int IdTipoContacto {get;set;}
        public AreaContacto AreaContacto {get;set;}
        public int IdAreaContacto {get;set;}
        public ICollection<PersonaContacto> PersonasContactos {get;set;}
    }
