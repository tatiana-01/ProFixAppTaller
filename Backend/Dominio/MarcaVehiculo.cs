namespace Dominio;
    public class MarcaVehiculo:EntidadGenericaA
    {
        public ICollection<Vehiculo> Vehiculos {get;set;}
    }
