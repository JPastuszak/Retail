using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;


using Commerce.Models.Entities;
using Commerce.Models.Entities.PreDefines;
using Commerce.Models.Entities.Finance;


namespace Commerce.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base(DatabaseConfig.ConnectionString)
        {
            Database.SetInitializer(new
                DropCreateDatabaseIfModelChanges<DatabaseContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Não cria uma tabela de metadados
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            // Não cria tabelas com nomes pluralizados das entidades
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Add<PluralizingTableNameConvention>();
            // Registra a classe Address como tipo complexo
            //modelBuilder.ComplexType<Address>();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Customer> Customers { get; set; }
        // Dados Pré Definidos do Sistema
        // Aqui estão as classes que fazem parte do Pacote de PréDefinição do sistema
        public DbSet<SBank> SBanks { get; set; }
        public DbSet<SFlagCard> SFlagCards { get; set; }
        public DbSet<SPostalCode> SPostalCodes { get; set; }
        public DbSet<SCity> SCities { get; set; }
        public DbSet<SCountry> SCountries { get; set; }
        public DbSet<SState> SStates { get; set; }

        // Dados Finanças e Apoio
        // Dados das tabelas financeiras e de apoio
        public DbSet<CBankAccount> CBankAccounts { get; set; }


        /************ New Classes 

        public DbSet<Seguranca> ACESSOS { get; set; }
        public DbSet<ALIQUOTA> ALIQUOTA { get; set; }*/
    }

}