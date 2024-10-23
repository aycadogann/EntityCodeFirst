namespace EntityCodeFirst.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class RenameKategoriAdToKategoryAdiInKategorisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("Kategoris", "KategoriAdi", c => c.String());
            DropColumn("Kategoris", "KategoriAd");
        }
        
        public override void Down()
        {
            AddColumn("Kategoris", "KategoriAd", c => c.String());
            DropColumn("Kategoris", "KategoriAdi");
        }
    }
}
