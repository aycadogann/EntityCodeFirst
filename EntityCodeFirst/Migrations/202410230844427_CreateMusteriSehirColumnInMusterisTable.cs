namespace EntityCodeFirst.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CreateMusteriSehirColumnInMusterisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("Musteris", "MusteriSehir", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("Musteris", "MusteriSehir");
        }
    }
}
