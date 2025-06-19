namespace AnimalsV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAnimalTypeTable23 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BreedTypes", "AnimalTypeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BreedTypes", "AnimalTypeId");
        }
    }
}
