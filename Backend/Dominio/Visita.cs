namespace Dominio;
    public class Visita:EntidadGenericaInt
    {
        public Vehiculo Vehiculo {get;set;}
        public int IdVehiculo {get;set;}
        public DateTime FechaEntrada {get;set;}
        public Sucursal Sucursal {get;set;}
        public int IdSucursal {get;set;}
        public Empleado Empleado {get;set;}
        public int IdEmpleadoResponsable {get;set;}
        public Estado Estado {get;set;}
        public int IdEstado {get;set;}
        public string Recomendaciones {get;set;}
    }
