USE [AdventureWorks2008]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdatePerson]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdatePerson]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdatePerson]
(
	@BusinessEntityID int,
	@PersonType nchar(2),
	@NameStyle NameStyle,
	@Title nvarchar(8),
	@FirstName Name,
	@MiddleName Name,
	@LastName Name,
	@Suffix nvarchar(10),
	@EmailPromotion int,
	@rowguid uniqueidentifier,
	@ModifiedDate datetime
)
AS
BEGIN
	UPDATE [AdventureWorks2008].[Person].[Person]
	SET
		[PersonType] = @PersonType,
		[NameStyle] = @NameStyle,
		[Title] = @Title,
		[FirstName] = @FirstName,
		[MiddleName] = @MiddleName,
		[LastName] = @LastName,
		[Suffix] = @Suffix,
		[EmailPromotion] = @EmailPromotion,
		[rowguid] = @rowguid,
		[ModifiedDate] = @ModifiedDate
             WHERE [BusinessEntityID] = @BusinessEntityID
END;
GO

USE [AdventureWorks2008]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertPerson]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertPerson]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[InsertPerson]
(
	@BusinessEntityID int,
	@PersonType nchar(2),
	@NameStyle NameStyle,
	@Title nvarchar(8),
	@FirstName Name,
	@MiddleName Name,
	@LastName Name,
	@Suffix nvarchar(10),
	@EmailPromotion int,
	@rowguid uniqueidentifier,
	@ModifiedDate datetime
)
AS
BEGIN

	INSERT INTO [AdventureWorks2008].[Person].[Person]
	(
		[BusinessEntityID],
		[PersonType],
		[NameStyle],
		[Title],
		[FirstName],
		[MiddleName],
		[LastName],
		[Suffix],
		[EmailPromotion],
		[rowguid],
		[ModifiedDate]
	)
	VALUES
	(
		@BusinessEntityID,
		@PersonType,
		@NameStyle,
		@Title,
		@FirstName,
		@MiddleName,
		@LastName,
		@Suffix,
		@EmailPromotion,
		@rowguid,
		@ModifiedDate
	)
END;
GO

USE [AdventureWorks2008]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeletePerson]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeletePerson]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[DeletePerson]
(
	@BusinessEntityID int
)
AS
BEGIN

	DELETE FROM Person.Person WHERE Person.Person.BusinessEntityID = @BusinessEntityID

END;

GO

USE [AdventureWorks2008]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectPeople]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectPeople]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SelectPeople]
AS
BEGIN

	SELECT
		[BusinessEntityID],
		[PersonType],
		[NameStyle],
		[Title],
		[FirstName],
		[MiddleName],
		[LastName],
		[Suffix],
		[EmailPromotion],
		[AdditionalContactInfo],
		[Demographics],
		[rowguid],
		[ModifiedDate]
	FROM
		[AdventureWorks2008].[Person].[Person]

END;

GO
