using System.ComponentModel.DataAnnotations;

namespace WebAppInstaCoreMVC.Models
{
    public class Client
    {
        public int ID { get; set; }
        [Required]
        public string? RCS { get; set; }
  
        public string? Adresse { get; set; }
        public string? Tel   { get; set; }

        [Required(ErrorMessage ="L'email est obligatoire")]
        public string? Email  { get; set; }
    }




}
