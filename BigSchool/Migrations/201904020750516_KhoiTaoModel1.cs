namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KhoiTaoModel1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Courses", new[] { "Lecturerid" });
            CreateIndex("dbo.Courses", "LecturerId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Courses", new[] { "LecturerId" });
            CreateIndex("dbo.Courses", "Lecturerid");
        }
    }
}
