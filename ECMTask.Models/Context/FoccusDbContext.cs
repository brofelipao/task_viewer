using ECMTask.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECMTask.Models.Context
{
    public class FoccusDbContext : DbContext
    {
        public FoccusDbContext() { }
        public FoccusDbContext(DbContextOptions<FoccusDbContext> options) : base(options)
        {

        }

        public virtual DbSet<ecmdocumento> ecmdocumento { get; set; }
        public virtual DbSet<ecmdocumentotarefa> ecmdocumentotarefa { get; set; }
        public virtual DbSet<ecmtramite> ecmtramite { get; set; }
        public virtual DbSet<empresa> empresa { get; set; }
        public virtual DbSet<pessoa> pessoa { get; set; }
        public virtual DbSet<setor> setor { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<setorarea> setorarea { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ecmdocumentotarefa>().HasOne(e => e.setorarea).WithMany(e => e.ecmdocumentotarefa).HasForeignKey(e => e.setorareaid);
            modelBuilder.Entity<setor>().HasMany(e => e.setorarea).WithOne(e => e.setor).HasForeignKey(e => e.setorid);
            modelBuilder.Entity<ecmdocumento>().HasMany(e => e.ecmtramite).WithOne(e => e.ecmdocumento).HasForeignKey(e => e.ecmdocumentoid);
            modelBuilder.Entity<ecmdocumento>().HasOne(e => e.pessoaautor).WithMany(e => e.ecmdocumentoautor).HasForeignKey(e => e.pessoaidautor);
            modelBuilder.Entity<ecmdocumento>().HasOne(e => e.setordemandante).WithMany(e => e.ecmdocumentodemandante).HasForeignKey(e => e.setoridinteressado);
            modelBuilder.Entity<empresa>().HasMany(e => e.ecmtramite).WithOne(e => e.empresa).HasForeignKey(e => e.empresaid);
            modelBuilder.Entity<empresa>().HasMany(e => e.pessoa).WithOne(e => e.empresa).HasForeignKey(e => e.empresaid);
            modelBuilder.Entity<empresa>().HasMany(e => e.setor).WithOne(e => e.empresa).HasForeignKey(e => e.empresaid);
            modelBuilder.Entity<empresa>().HasMany(e => e.usuario).WithOne(e => e.empresa).HasForeignKey(e => e.empresaid);
            modelBuilder.Entity<empresa>().HasMany(e => e.usuariocolaborador).WithOne(e => e.empresacolaborador).HasForeignKey(e => e.empresaidcolaborador);
            modelBuilder.Entity<pessoa>().HasMany(e => e.ecmdocumento).WithOne(e => e.pessoa).HasForeignKey(e => e.pessoaidinteressado);
            //modelBuilder.Entity<pessoa>().HasMany(e => e.ecmdocumento).WithOne(e => e.pessoaautor).HasForeignKey(e => e.pessoaidautor);
            modelBuilder.Entity<pessoa>().HasMany(e => e.ecmdocumentotarefa).WithOne(e => e.pessoa).HasForeignKey(e => e.demandantepessoaid);
            modelBuilder.Entity<pessoa>().HasMany(e => e.ecmtramiteautor).WithOne(e => e.pessoaautor).HasForeignKey(e => e.pessoaidautor);
            modelBuilder.Entity<pessoa>().HasMany(e => e.ecmtramitedestinatario).WithOne(e => e.pessoadestinatario).HasForeignKey(e => e.pessoaiddestinatario);
            modelBuilder.Entity<pessoa>().HasMany(e => e.setor).WithOne(e => e.pessoa).HasForeignKey(e => e.pessoaiddiretor);
            modelBuilder.Entity<pessoa>().HasMany(e => e.usuario).WithOne(e => e.pessoa).HasForeignKey(e => e.pessoaid);
            modelBuilder.Entity<setor>().HasMany(e => e.ecmdocumento).WithOne(e => e.setor).HasForeignKey(e => e.setoridautor);
            //modelBuilder.Entity<setor>().HasMany(e => e.ecmdocumento).WithOne(e => e.setordemandante).HasForeignKey(e => e.setoridinteressado);
            modelBuilder.Entity<setor>().HasMany(e => e.setorFilhos).WithOne(e => e.setorgestor).HasForeignKey(e => e.setoridgestor);
            modelBuilder.Entity<setor>().HasMany(e => e.usuario).WithOne(e => e.setor).HasForeignKey(e => e.setorid);
            modelBuilder.Entity<ecmdocumento>().HasOne(a => a.ecmdocumentotarefa).WithOne(b => b.ecmdocumento).HasForeignKey<ecmdocumentotarefa>(b => b.ecmdocumentoidtarefa);
            modelBuilder.Entity<ecmtramite>().HasOne(e => e.setorautor).WithMany(e => e.ecmtramite).HasForeignKey(e => e.setoridautor);

        }
    }
}
