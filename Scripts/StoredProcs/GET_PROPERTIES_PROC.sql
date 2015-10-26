
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Paul Cope>
-- Create date: <25 OCT 2015>
-- Description:	<Stored Procedure to get properties>
-- =============================================
CREATE PROCEDURE GET_PROPERTY
	(
	@Prop_ID int,
	@Address_ID int OUTPUT,
	@Prop_Value money OUTPUT,
	@Lowest_Value money OUTPUT,
	@User_ID int OUTPUT
	)
AS
BEGIN
	SET NOCOUNT ON;

	select @Address_ID = Address_ID,
	@Prop_Value = Properties.Valuation,
	@Lowest_Value = Properties.LowestPrice,
	@User_ID = Properties.UserID
	from Properties
	left join Addresses
	on Properties.Prop_Address_ID = Addresses.Address_ID
	where Prop_ID = @Prop_ID;
	RETURN
END
GO