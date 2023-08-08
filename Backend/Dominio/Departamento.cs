
namespace Dominio;

    public class Departamento:EntidadGenericaA
    {
        public ICollection<Ciudad> Ciudades {get;set;}
    }
