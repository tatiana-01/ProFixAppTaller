using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio;
    public class ProductoStockReparacion
    {
        public ProductoStock ProductoStock {get;set;}
        public int IdProductoStock {get;set;}
        public Reparacion Reparacion {get;set;}
        public int IdReparacion {get;set;}
    }
