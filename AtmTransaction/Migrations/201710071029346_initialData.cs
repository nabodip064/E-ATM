namespace AtmTransaction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserDatas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        card_number = c.Int(nullable: false),
                        pinNumber = c.Int(nullable: false),
                        balance = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserDatas");
        }
    }
}
