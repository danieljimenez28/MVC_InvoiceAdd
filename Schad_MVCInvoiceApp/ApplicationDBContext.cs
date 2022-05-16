using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Schad_MVCInvoiceApp.Entitades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schad_MVCInvoiceApp
{
    public class ApplicationDBContext : DbContext
    {
		public ApplicationDBContext()
		{

		}
		public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=LAPTOP-FQ6SCOUQ;Initial Catalog=Test_Invoice;Integrated Security=True")
				.EnableSensitiveDataLogging(true)
				.UseLoggerFactory(MyLoggerFactory);
		}

		public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder =>
		{
			builder
			   .AddFilter((category, level) =>
				   category == DbLoggerCategory.Database.Command.Name
				   && level == LogLevel.Information)
			   .AddConsole();
		});

		public DbSet<CustomerType> CustomerTypes { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Invoice> Invoices { get; set; }
		public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
		public DbSet<Vw_SalesDetail> Vw_SalesDetail { get; set; }
	}
}
