namespace WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rut = c.String(),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Direccion = c.String(),
                        Email = c.String(),
                        Telefono = c.String(),
                        Giro = c.String(),
                        PersonaContacto = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.DetallePedido",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PuntoSalida = c.String(),
                        Pedido_Id = c.String(),
                        PuntoLlegada = c.String(),
                        Kilometros = c.String(),
                        PrecioKilometro = c.String(),
                        CabinasDePeaje = c.String(),
                        Descuento = c.String(),
                        Iva = c.String(),
                        Descripcion = c.String(),
                        ValorTotal = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.Estado",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.FichaEmpleado",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Rut = c.String(),
                        Telefono = c.String(),
                        Email = c.String(),
                        Direccion = c.String(),
                        Edad = c.String(),
                        Rol = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.Lugar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.Maquina",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Patente = c.String(),
                        Nombre = c.String(),
                        Duenio = c.String(),
                        TipoMaquina = c.String(),
                        Fecha = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.Pedido",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cliente = c.String(),
                        TipoServicio = c.String(),
                        Lugar = c.String(),
                        Estado = c.String(),
                        Maquina = c.String(),
                        Fecha = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.Rol",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.TipoMaquina",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.TipoServicio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("public.TipoServicio");
            DropTable("public.TipoMaquina");
            DropTable("public.Rol");
            DropTable("public.Pedido");
            DropTable("public.Maquina");
            DropTable("public.Lugar");
            DropTable("public.FichaEmpleado");
            DropTable("public.Estado");
            DropTable("public.DetallePedido");
            DropTable("public.Cliente");
        }
    }
}
