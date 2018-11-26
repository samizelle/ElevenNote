namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note", "Category", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Note", "Category");
        }
    }
}
