namespace ASP_MVC5_CRUD_Employees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations_Validaciones_del_Modelo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "EmployeeName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Employees", "Designation", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Designation", c => c.String());
            AlterColumn("dbo.Employees", "EmployeeName", c => c.String());
        }
    }
}
