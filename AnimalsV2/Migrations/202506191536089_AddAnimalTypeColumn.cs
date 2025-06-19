namespace AnimalsV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnimalTypeColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "AnimalType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animals", "AnimalType");
        }
    }
}
