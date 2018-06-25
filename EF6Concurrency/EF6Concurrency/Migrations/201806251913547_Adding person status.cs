namespace EF6Concurrency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addingpersonstatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Status");
        }
    }
}
