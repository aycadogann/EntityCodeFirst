namespace EntityCodeFirst.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CreateMusterisTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Musteris",
                c => new
                    {
                        MusteriId = c.Int(nullable: false, identity: true),
                        MusteriAd = c.String(),
                        MusteriSoyad = c.String(),
                    })
                .PrimaryKey(t => t.MusteriId);
            
            AddColumn("Uruns", "Aciklama", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("Uruns", "Aciklama");
            DropTable("Musteris");
        }
    }
}
