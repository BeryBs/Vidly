namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        //update-database ile up veya down methodlarından sadece biri çalışır.
        public override void Up() //Veritabanının son halini upgrade eder. (install gibi)
        {
            Sql("INSERT INTO MembershipTypes (ID,SignUpFee,DurationInMonths,DiscountRate) VALUES (1,0,0,0) ");
            Sql("INSERT INTO MembershipTypes (ID,SignUpFee,DurationInMonths,DiscountRate) VALUES (2,30,1,10) ");
            Sql("INSERT INTO MembershipTypes (ID,SignUpFee,DurationInMonths,DiscountRate) VALUES (3,90,3,15) ");
            Sql("INSERT INTO MembershipTypes (ID,SignUpFee,DurationInMonths,DiscountRate) VALUES (4,300,12,20) ");
        }
        
        public override void Down() //Veritabanındaki son değişiklikleri siler.(uninstall gibi)
        {
        }
    }
}
