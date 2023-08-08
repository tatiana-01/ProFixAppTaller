namespace Dominio;

    public class Reparacion:EntidadGenericaInt
    {
        public string Descripcion {get;set;}
        public decimal Tiempo {get;set;}
        public ProductoStock ProductoStock {get;set;}
        public int IdProductoStock {get;set;}
        public decimal Cantidad {get;set;}
        public string Unidad {get;set;}
        public decimal ValorTotal {get;set;}
        public MomentoReparacion MomentoReparacion {get;set;}
        public int IdMomento {get;set;}
        public TipoReparacion TipoReparacion {get;set;}
        public int IdTipo {get;set;}
        public Estado Estado {get;set;}
        public int IdEstado {get;set;}
        public Orden Orden {get;set;}
        public int IdOrden {get;set;}

    }
