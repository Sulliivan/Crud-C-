using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AvisFormationCore.WebUi.Models
{
    public class LaisserUnAvisViewModel
    {
        [StringLength(5)]
        public string Commentaire { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Note { get; set; }
        [Required]
        public string idFormation { get; set; }

        public string NomFormation { get; set; }
    }
}
