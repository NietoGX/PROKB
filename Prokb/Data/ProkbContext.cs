using Microsoft.EntityFrameworkCore;
using Prokb.Data.Models;
using Prokb.Data.Models.TiposFicha;

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
            modelBuilder.Entity<FichaNoConformidad>().ToTable("FichasNoConformidad");
            modelBuilder.Entity<FichaNoConformidadEficienciaEnergetica>().ToTable("FichaNoConformidadEficienciaEnergetica");
            modelBuilder.Entity<FichaNoConformidadMedioAmbiente>().ToTable("FichasNoConformidadMedioAmbiente");
            modelBuilder.Entity<FichaNoConformidadServicio>().ToTable("FichasNoConformidadServicioa");
            modelBuilder.Entity<FichaNoConformidadProductoAcabado>().ToTable("FichasNoConformidadProductoAcabado");
            modelBuilder.Entity<FichaAnalisis>().ToTable("FichasAnalisis");
            modelBuilder.Entity<FichaArticulo>().ToTable("FichasArticulo");
            modelBuilder.Entity<FichaArticuloEFIMED>().ToTable("FichasArticuloEFIMED");
            modelBuilder.Entity<FichaCalidad>().ToTable("FichasCalidad");
            modelBuilder.Entity<FichaCompras>().ToTable("FichasCompras");
            modelBuilder.Entity<FichaEjecucion>().ToTable("FichasEjecucion");
            modelBuilder.Entity<FichaIncidencia>().ToTable("FichasIncidencia");
            modelBuilder.Entity<FichaLogistica>().ToTable("FichasLogistica");
            
            modelBuilder.Entity<FichaPlanificacion>().ToTable("FichasPlanificacion");
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



        }
        public DbSet<FichaNoConformidad> FichasNoConformidad { get; set; }
        public DbSet<FichaNoConformidadEficienciaEnergetica> FichasNoConformidadEficienciaEnergetica { get; set; }
        public DbSet<FichaNoConformidadMedioAmbiente> FichasNoConformidadMedioAmbiente { get; set; }
        public DbSet<FichaNoConformidadServicio> FichasNoConformidadServicioa { get; set; }
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


    }

}
