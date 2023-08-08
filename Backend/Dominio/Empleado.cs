namespace Dominio;

    public class Empleado:EntidadGenericaInt
    {
       public EPS Eps {get;set;}
       public int IdEPS {get;set;} 
       public ARL Arl {get;set;}
       public int IdARL {get;set;} 
       public Persona Persona {get;set;}
       public string IdPersona {get;set;} 
       public Sucursal Sucursal {get;set;}
       public int IdSucursal {get;set;} 
       public decimal Salario {get;set;}
       public Especialidad Especialidad {get;set;}
       public int IdEspecialidad {get;set;}

    }
