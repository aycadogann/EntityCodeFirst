namespace EntityCodeFirst.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class KategoriAdiToKategoiAdInKategorisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("Kategoris", "KategoriAd", c => c.String());
            Sql("update Kategoris set KategoriAd=KategoriAdi");
            DropColumn("Kategoris", "KategoriAdi");
        }
        
        public override void Down()
        {
            AddColumn("Kategoris", "KategoriAdi", c => c.String());
            Sql("update Kategoris set KategoriAdi=KategoriAd");
            DropColumn("Kategoris", "KategoriAd");
        }
    }
}
