namespace Dominio;

    public class Especialidad:EntidadGenericaA
    {
        public ICollection<Empleado> Empleados {get;set;}
        public Cargo Cargo {get;set;}
        public int IdCargo {get;set;}
    }
