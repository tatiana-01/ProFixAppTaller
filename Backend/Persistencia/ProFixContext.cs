using System.Reflection;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class ProFixContext : DbContext
    {
        public ProFixContext(DbContextOptions<ProFixContext> options) : base(options)
        {
        }

        public DbSet<AreaContacto> AreaContactos { get; set; }
        public DbSet<ARL> ARLs { get; set; }
        public DbSet<CalidadProducto> CalidadProductos { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<CompraProveedor> CompraProveedores { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<EPS> EPSs { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Inspeccion> Inspecciones { get; set; }
        public DbSet<MarcaProducto> MarcaProductos { get; set; }
        public DbSet<MarcaVehiculo> MarcaVehiculos { get; set; }
        public DbSet<MetodoDePago> MetodoDePagos { get; set; }
        public DbSet<MomentoReparacion> MomentoReparaciones { get; set; }
        public DbSet<Orden> Ordenes { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<PersonaContacto> PersonaContactos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<ProductoCompra> ProductoCompras { get; set; }
        public DbSet<ProductoStock> ProductoStocks { get; set; }
        public DbSet<ProductoStockReparacion> ProductoStockReparaciones { get; set; }
        public DbSet<Reparacion> Reparaciones { get; set; }
        public DbSet<ReparacionEmpleado> ReparacionEmpleados { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<RolPersona> RolPersonas { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<TipoContacto> TipoContactos { get; set; }
        public DbSet<TipoEstado> TipoEstados { get; set; }
        public DbSet<TipoProducto> TipoProductos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Visita> Visitas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}