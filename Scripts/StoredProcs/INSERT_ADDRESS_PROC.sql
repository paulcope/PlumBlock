-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Paul Cope>
-- Create date: <25 OCT 2015>
-- Description:	<Stored Procedure to insert property>
-- =============================================
CREATE PROCEDURE INSERT_ADDRESS 
	-- Add the parameters for the stored procedure here
	(
	@Address1 varchar,
	@Address2 varchar,
	@Address3 varchar,
	@Address4 varchar,
	@Address5 varchar,
	@Postcode varchar
	)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.Addresses (AddressLine1, AddressLine2, AddressLine3, AddressLine4, AddressLine5, PostCode)
	values (@Address1, @Address2, @Address3, @Address4, @Address5, @Postcode);

END
GO
