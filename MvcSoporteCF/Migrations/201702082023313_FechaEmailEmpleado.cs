namespace MvcSoporteCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FechaEmailEmpleado : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empleado", "FechaNacimiento", c => c.DateTime());
            AddColumn("dbo.Empleado", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empleado", "Email");
            DropColumn("dbo.Empleado", "FechaNacimiento");
        }
    }
}
