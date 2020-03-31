using Microsoft.EntityFrameworkCore;
using Prokb.Data.Models;
using Prokb.Data.Models.TiposFicha;
using System.Linq;

namespace Prokb.Data
{
    public class ProkbContext : DbContext
    {

        public ProkbContext() {  }
        public ProkbContext(DbContextOptions<ProkbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<FichaNoConformidad>().ToTable("FichasNoConformidad");
            modelBuilder.Entity<FichaNoConformidadEficienciaEnergetica>().ToTable("FichasNoConformidad");
            modelBuilder.Entity<FichaNoConformidadMedioAmbiente>();//.ToTable("FichasNoConformidad");
            modelBuilder.Entity<FichaNoConformidadServicio>();//.ToTable("FichasNoConformidad");
            modelBuilder.Entity<FichaNoConformidadProductoAcabado>();//.ToTable("FichasNoConformidad");
            modelBuilder.Entity<FichaAnalisis>();//.ToTable("FichasNoConformidad");
            modelBuilder.Entity<FichaArticulo>();//.ToTable("FichasNoConformidad");
            modelBuilder.Entity<FichaArticuloEFIMED>();//.ToTable("FichasNoConformidad");
            modelBuilder.Entity<FichaCalidad>();//.ToTable("FichasNoConformidad");
            modelBuilder.Entity<FichaCompras>();//.ToTable("FichasNoConformidad");
            modelBuilder.Entity<FichaEjecucion>();//.ToTable("FichasNoConformidad");
            modelBuilder.Entity<FichaIncidencia>();//.ToTable("FichasNoConformidad");
            modelBuilder.Entity<FichaLogistica>();//.ToTable("FichasNoConformidad");

            modelBuilder.Entity<FichaPlanificacion>();//.ToTable("FichasNoConformidad");
            modelBuilder.Entity<Area>().ToTable("Areas");
            modelBuilder.Entity<Decision>().ToTable("Decisiones");
            modelBuilder.Entity<Documento>().ToTable("Documentos");
            modelBuilder.Entity<Empresa>().ToTable("Empresas");
            modelBuilder.Entity<EmpresaAreaSeccionUsuario>().ToTable("EmpresaAreaSeccionUsuarios");
            modelBuilder.Entity<Incidencia>().ToTable("Incidencias");
            modelBuilder.Entity<Motivo>().ToTable("Motivos");
            modelBuilder.Entity<Proveedor>().ToTable("Proveedores");
            modelBuilder.Entity<Seccion>().ToTable("Secciones");
            modelBuilder.Entity<TipoDecisionSeccion>().ToTable("TiposDecisionSeccion");
            modelBuilder.Entity<TipoIncidenciaSeccion>().ToTable("TiposIncidenciaSeccion");
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }


        }
        //public DbSet<FichaNoConformidad> FichasNoConformidad { get; set; }
        public DbSet<FichaNoConformidadEficienciaEnergetica> FichasNoConformidadEficienciaEnergetica { get; set; }
        public DbSet<FichaNoConformidadMedioAmbiente> FichasNoConformidadMedioAmbiente { get; set; }
        public DbSet<FichaNoConformidadServicio> FichasNoConformidadServicio { get; set; }
        public DbSet<FichaNoConformidadProductoAcabado> FichasNoConformidadProductoAcabado { get; set; }
        public DbSet<FichaAnalisis> FichasAnalisis { get; set; }
        public DbSet<FichaArticulo> FichasArticulo { get; set; }
        public DbSet<FichaArticuloEFIMED> FichasArticuloEFIMED { get; set; }
        public DbSet<FichaCalidad> FichasCalidad { get; set; }
        public DbSet<FichaCompras> FichasCompras { get; set; }
        public DbSet<FichaEjecucion> FichasEjecucion { get; set; }
        public DbSet<FichaIncidencia> FichasIncidencia { get; set; }
        public DbSet<FichaLogistica> FichasLogistica { get; set; }

        public DbSet<FichaPlanificacion> FichasPlanificacion { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Decision> Decisiones { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<EmpresaAreaSeccionUsuario> EmpresaAreaSeccionUsuarios { get; set; }
        public DbSet<Incidencia> Incidencias { get; set; }
        public DbSet<Motivo> Motivos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Seccion> Secciones { get; set; }
        public DbSet<TipoDecisionSeccion> TiposDecisionSeccion { get; set; }
        public DbSet<TipoIncidenciaSeccion> TiposIncidenciaSeccion { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Articulo> Articulo { get; set; }


    }

}
