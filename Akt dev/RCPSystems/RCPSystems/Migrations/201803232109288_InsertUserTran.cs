namespace RCPSystems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertUserTran : DbMigration
    {
        public override void Up()
        {
            Sql(@"declare @wzor as varchar(23),@wzor2 as varchar(23), @data as varchar(23),@data2 as varchar(23),@trans as int,@dzien as int,
                @prac as int
                set @dzien=0
                set @wzor='2018-03-01 09:00:00.000'
                set @wzor2='2018-03-01 17:00:00.000'
                set @prac=1

                begin
	                while @prac<6
		                begin
			                while @dzien<31
				                Begin
					                set @data=dateadd(day, @dzien, convert(datetime2, @wzor))
					                set @data2=dateadd(day, @dzien, convert(datetime2, @wzor2))
							                if (select datepart(dw,@data))<>7 and (select datepart(dw,@data))<>1 
							                begin
								                insert into rcpTransactionAll values(@data,@prac,1)
								                insert into rcpTransactionAll values(@data2,@prac,2)
							                end
						                 set @dzien=@dzien+1
				                End
			                set @prac=@prac+1
			                set @dzien=0
			                set @wzor='2018-03-01 09:00:00.000'
			                set @wzor2='2018-03-01 17:00:00.000'
		                End
                End");
        }
        
        public override void Down()
        {
        }
    }
}
