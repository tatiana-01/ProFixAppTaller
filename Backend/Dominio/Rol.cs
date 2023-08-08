namespace Dominio;

    public class Rol:EntidadGenericaA
    {
        public string Permisos {get;set;}
        public ICollection<RolPersona> RolesPersonas {get;set;}
    }
