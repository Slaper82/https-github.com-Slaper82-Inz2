namespace RCPSystems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TranBreakAdd : DbMigration
    {
        public override void Up()
        {
            Sql(@"declare @wzor as varchar(23),@wzor2 as varchar(23), @data as varchar(23),@data2 as varchar(23),@trans as int,@dzien as int,
                @prac as int
                set @dzien=0
                set @wzor='2018-03-01 12:00:00.000'
                set @wzor2='2018-03-01 12:30:00.000'
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
								                insert into rcpTransactionAll values(@data,@prac,3)
								                insert into rcpTransactionAll values(@data2,@prac,4)
							                end
						                 set @dzien=@dzien+1
				                End
			                set @prac=@prac+1
		                    set @dzien=0
			                set @wzor='2018-03-01 12:00:00.000'
			                set @wzor2='2018-03-01 12:30:00.000'
		                End
                End"
);

            Sql(@"
                    CREATE PROCEDURE [dbo].[ZadPodsumowania](@UserId as int,@Start as varchar(8),@Stop as varchar(8))
                    as
                    BEGIN
	                    SELECT 
	                     u.Name+' '+u.Surname as [User]
	                    ,el.Name
	                    ,ztl.Quantity as 'Ilosc'
	                    ,ISNULL(CONVERT(VARCHAR(8), DATEADD(S,SUM(DATEDIFF(S,zdt.Start,zdt.Stop)),0),108),'00:00:00') as 'Czaspracy'
	                     FROM 
		                     zadTaskProduction as zdt
		                    join zadTaskList as ztl on zdt.IdTask=ztl.IdTask
		                    join zadElement as el on ztl.IdElement=el.IdElement
		                    join genUsers as u on zdt.IdUser=u.IdUser
	                    WHERE 
		                    zdt.IdUser=@UserId and zdt.Stop is not null AND zdt.Start>@Start AND zdt.Stop<@Stop
	                    GROUP BY 
		                    u.Name,u.Surname,el.Name,ztl.Quantity
                    END"
);
        }
        
        public override void Down()
        {
        }
    }
}
