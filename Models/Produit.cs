using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppInstaCoreMVC.Models
{
   
    public class Produit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string? Reference { get; set; }
        public string? Libelle { get; set; }
        public decimal? Prix { get; set; }
        public int? Quantite { get; set; }

    }
}
