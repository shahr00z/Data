namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Description", c => c.String());
            AddColumn("dbo.Posts", "UniqId", c => c.Guid(nullable: false));
            AddColumn("dbo.Posts", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Posts", "RowVersion", c => c.Binary());
            AddColumn("dbo.Comments", "Description", c => c.String());
            AddColumn("dbo.Comments", "Name", c => c.String());
            AddColumn("dbo.Comments", "UniqId", c => c.Guid(nullable: false));
            AddColumn("dbo.Comments", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Comments", "RowVersion", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "RowVersion");
            DropColumn("dbo.Comments", "CreatedDate");
            DropColumn("dbo.Comments", "UniqId");
            DropColumn("dbo.Comments", "Name");
            DropColumn("dbo.Comments", "Description");
            DropColumn("dbo.Posts", "RowVersion");
            DropColumn("dbo.Posts", "CreatedDate");
            DropColumn("dbo.Posts", "UniqId");
            DropColumn("dbo.Posts", "Description");
        }
    }
}
