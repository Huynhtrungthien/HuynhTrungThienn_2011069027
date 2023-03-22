﻿namespace HuynhTrungThienn_2011069027.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORY (ID, NAME) VALUES (1, 'Development')");
            Sql("INSERT INTO CATEGORY (ID, NAME) VALUES (2, 'Business')");
            Sql("INSERT INTO CATEGORY (ID, NAME) VALUES (3, 'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
