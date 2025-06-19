namespace AnimalsV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Age = c.Int(nullable: false),
                        BreedTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BreedTypes", t => t.BreedTypeId, cascadeDelete: true)
                .Index(t => t.BreedTypeId);
            
            CreateTable(
                "dbo.BreedTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animals", "BreedTypeId", "dbo.BreedTypes");
            DropIndex("dbo.Animals", new[] { "BreedTypeId" });
            DropTable("dbo.BreedTypes");
            DropTable("dbo.Animals");
        }
    }
}
