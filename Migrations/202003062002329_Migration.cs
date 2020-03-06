namespace Online_Medicine_Shopping.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        price = c.Single(nullable: false),
                        quantity = c.Int(nullable: false),
                        category_name = c.String(),
                        descrition = c.String(),
                        sup_id = c.Int(nullable: false),
                        image = c.Binary(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.products");
        }
    }
}
