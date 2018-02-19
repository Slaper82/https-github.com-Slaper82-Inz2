namespace RCPSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserToOrg : DbMigration
    {
        public override void Up()
        {
            Sql("insert into genOrgUnitPriv values (1,2,1)");
            Sql("insert into genOrgUnitPriv values (2,3,1)");
            Sql("insert into genOrgUnitPriv values (3,3,1)");
        }
        
        public override void Down()
        {
        }
    }
}
