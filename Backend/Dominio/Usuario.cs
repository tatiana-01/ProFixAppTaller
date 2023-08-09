namespace Dominio;
    public class Usuario:EntidadGenericaInt
    {
        public string UsuarioPersona {get;set;}
        public string Contraseña {get;set;}
        public Persona Persona {get;set;}
        public string IdPersona {get;set;}
    }
