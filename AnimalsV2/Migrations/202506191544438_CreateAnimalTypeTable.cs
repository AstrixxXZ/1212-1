﻿namespace AnimalsV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAnimalTypeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AnimalTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AnimalTypes");
        }
    }
}
