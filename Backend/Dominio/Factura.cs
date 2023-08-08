namespace Dominio;

    public class Factura:EntidadGenericaInt
    {
        public decimal ValorTotalRepuestos {get;set;}
        public decimal ValorTotalManoObra {get;set;}
        public decimal ValorTotalReparacion {get;set;}
        public DateTime FechaSalida {get;set;}
        public MetodoDePago MetodoDePago {get;set;}
        public int IdMetodoDePago {get;set;}
        public Estado Estado {get;set;}
        public int IdEstado {get;set;}
        public Orden Orden {get;set;}
        public int IdOrden {get;set;}
    }
