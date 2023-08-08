namespace Dominio;

    public class Cargo:EntidadGenericaA
    {
        public ICollection<Especialidad> Especialidades {get;set;}
    }