namespace EntityCodeFirst.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class RenameMusteriSoyadToMusteriUnvanInMusterisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("Musteris", "MusteriUnvan", c => c.String());
            DropColumn("Uruns", "Aciklama");
            DropColumn("Musteris", "MusteriSoyad");
        }
        
        public override void Down()
        {
            AddColumn("Musteris", "MusteriSoyad", c => c.String());
            AddColumn("Uruns", "Aciklama", c => c.String());
            DropColumn("Musteris", "MusteriUnvan");
        }
    }
}
