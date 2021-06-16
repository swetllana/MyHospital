namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Specialization = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Insurance = c.String(nullable: false, maxLength: 40),
                        DateAdmitted = c.DateTime(nullable: false),
                        DateCheckedOut = c.DateTime(nullable: false),
                        Doctor_Id = c.Int(nullable: false),
                        Doctor_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.Doctor_Id1)
                .Index(t => t.Doctor_Id1);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        TestDate = c.DateTime(nullable: false),
                        TestTime = c.DateTime(nullable: false),
                        Result = c.String(nullable: false, maxLength: 300),
                        Patient_Id = c.Int(nullable: false),
                        Doctor_Id = c.Int(nullable: false),
                        Doctor_Id1 = c.Int(),
                        Patient_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.Doctor_Id1)
                .ForeignKey("dbo.Patients", t => t.Patient_Id1)
                .Index(t => t.Doctor_Id1)
                .Index(t => t.Patient_Id1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tests", "Patient_Id1", "dbo.Patients");
            DropForeignKey("dbo.Tests", "Doctor_Id1", "dbo.Doctors");
            DropForeignKey("dbo.Patients", "Doctor_Id1", "dbo.Doctors");
            DropIndex("dbo.Tests", new[] { "Patient_Id1" });
            DropIndex("dbo.Tests", new[] { "Doctor_Id1" });
            DropIndex("dbo.Patients", new[] { "Doctor_Id1" });
            DropTable("dbo.Tests");
            DropTable("dbo.Patients");
            DropTable("dbo.Doctors");
        }
    }
}
