
namespace Dominio;

    public class Ciudad:EntidadGenericaA
    {
        public ICollection<Sucursal> Sucursales {get;set;}
        public Departamento Departamento {get;set;}
        public int IdDepartamento {get;set;}
    }
