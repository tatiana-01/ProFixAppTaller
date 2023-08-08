
using System.ComponentModel.DataAnnotations;

namespace Dominio;

    public class EntidadGenericaA:EntidadGenericaInt
    {
        [MaxLength(50),Required]
        public string Nombre {get; set;}
    }
