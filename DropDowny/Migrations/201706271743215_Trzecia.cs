namespace DropDowny.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Trzecia : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Zatrudnienies(AktywnoscZawodowa)values('Tak')");
            Sql("Insert into Zatrudnienies(AktywnoscZawodowa)values('Nie')");
            Sql("Insert into Zatrudnienies(AktywnoscZawodowa)values('Moze')");
        }
        
        public override void Down()
        {
            Sql("Delete from Zatrudnienies where AktywnoscZawodowa in ('Tak','Nie','Moze')");
        }
    }
}
