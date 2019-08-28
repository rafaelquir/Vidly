namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pupulateNameMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name ='Paga cuando se lleva' WHERE id=1");
            Sql("UPDATE MembershipTypes SET Name ='Mensual' WHERE id=2");
            Sql("UPDATE MembershipTypes SET Name ='Trimestral' WHERE id=3");
            Sql("UPDATE MembershipTypes SET Name ='Anual' WHERE id=4");
        }
        
        public override void Down()
        {
        }
    }
}
