using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrudAspNetMvc.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        private DateTime DateNow = DateTime.Now;
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Documento")]
        public string Documento { get; set; }


        [Required]
        public string Telefone { get; set; }

        
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data
        {
            get
            {
                return DateNow;
            }
            set
            {
                // DateNow = value;
            }
        }

            [Required]
        public char Tipo { get; set; }
    }
}