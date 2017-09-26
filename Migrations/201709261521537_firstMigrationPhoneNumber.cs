namespace LC_02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigrationPhoneNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Professors", "PhoneNumber", c => c.String());
            AddColumn("dbo.Students", "PhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "PhoneNumber");
            DropColumn("dbo.Professors", "PhoneNumber");
        }
    }
}
