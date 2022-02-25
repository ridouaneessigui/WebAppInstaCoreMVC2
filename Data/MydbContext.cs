using Microsoft.EntityFrameworkCore;
using WebAppInstaCoreMVC.Models;

namespace WebAppInstaCoreMVC.Data
{
    public class MydbContext : DbContext
    {
        public MydbContext(DbContextOptions<MydbContext> options)
        : base(options)
        {
        }

        public DbSet<Client> Client { get; set; }
        public DbSet<Produit> Produit { get; set; }
        public DbSet<Commande> Commande { get; set; }
    }
}

