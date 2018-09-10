using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using EInvoice.Models;
            
namespace EInvoice
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Item> Item { get; set; }
        //public DbSet<Customer> Customers { get; set; }
        //public DbSet<Access> Access { get; set; }
        //public DbSet<AccessDetail> AccessDetail { get; set; }
        //public DbSet<Account> Account { get; set; }
        //public DbSet<Certificate> Certificate { get; set; }
        //public DbSet<CertificateDetail> CertificateDetail { get; set; }
        //public DbSet<Company> Company { get; set; }
        //public DbSet<Config> Config { get; set; }
        //public DbSet<ConfigDetail> ConfigDetail { get; set; }
        //public DbSet<Database> DatabaseDB { get; set; }
        //public DbSet<Invoice> Invoice { get; set; }
        //public DbSet<InvoiceDetail> InvoiceDetail { get; set; }
        //public DbSet<InvoiceFormPublish> InvoiceFormPublish { get; set; }
        //public DbSet<Mail> Mail { get; set; }
        //public DbSet<NotifyPublishInvoice> NotifyPublishInvoice { get; set; }
        
    }
}
