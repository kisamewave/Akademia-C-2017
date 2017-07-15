namespace DropDowny.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Druga : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Wyksztalcenies(PoziomWyksztalcenia)values('Wyzsze')");
            Sql("Insert into Wyksztalcenies(PoziomWyksztalcenia)values('Srednie')");
            Sql("Insert into Wyksztalcenies(PoziomWyksztalcenia)values('Zawodowe')");
            Sql("Insert into Wyksztalcenies(PoziomWyksztalcenia)values('Brak')");
        }
        
        public override void Down()
        {
            Sql("Delete from Wyksztalcenies where PoziomWyksztalcenia in ('Wyzsze','Srednie','Zawodowe','Brak')");
        }
    }
}
