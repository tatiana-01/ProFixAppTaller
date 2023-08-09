namespace Dominio;
    public class Vehiculo:EntidadGenericaInt
    {
        public MarcaVehiculo MarcaVehiculo {get;set;}
        public int IdMarcaVehiculo {get;set;}
        public string Placa {get;set;}
        public string Modelo {get;set;}
        public string Color {get;set;}
        public decimal Kilometraje {get;set;}
        public Persona Persona {get;set;}
        public string IdPersona {get;set;}
        public ICollection<Visita> Visitas {get;set;}

    }
