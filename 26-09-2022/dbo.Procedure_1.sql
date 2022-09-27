CREATE PROCEDURE [dbo].[UpdateMember]
	@p_memberid int,
	@p_membername char(20),
	@p_accopendate  datetime,
	@p_maxbooksallowed int,
	@p_penaltyamount numeric(5)
AS
	update Member
	set Member_Name=@p_membername,
	Acc_Open_Date=@p_accopendate,
	Max_Books_Allowd=@p_maxbooksallowed,
	Penalty_Amount=@p_penaltyamount
	where Member_Id=@p_memberid;
RETURN 0
