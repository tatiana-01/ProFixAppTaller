
namespace Dominio;

    public class Persona
    {
        public string Id {get; set;}
        public string Nombre {get; set;}
        public string Direccion {get; set;}
        public ICollection<RolPersona> RolesPersonas {get;set;}
        public ICollection<PersonaContacto> PersonasContactos {get;set;}
        public ICollection<CompraProveedor> ComprasProveedores {get;set;}
        public ICollection<Vehiculo> Vehiculos {get;set;}
        public ICollection<Usuario> Usuarios {get;set;}
    }
