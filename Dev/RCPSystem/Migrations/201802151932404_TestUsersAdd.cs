namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestUsersAdd : DbMigration
    {
        public override void Up()
        {
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Jan','Kowalski',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Antoni','Nowak',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Marian','Wisniewski',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Jerzy','Baran',1,1)");
            Sql("insert into genUsers (Name,Surname,IdRole,Active) values ('Stefan','Duren',1,1)");
        }
        
        public override void Down()
        {
        }
    }
}
