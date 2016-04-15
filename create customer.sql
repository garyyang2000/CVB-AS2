


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer](
	[custId] [int] NOT NULL,
	[firstName] [nchar](50) NOT NULL,
	[lastName] [nvarchar](50) NOT NULL,
	[streetAddress] [nchar](255) NOT NULL,
	[city] [nchar](100) NOT NULL,
	[province] [nchar](10) NOT NULL,
	[postalCode] [nchar](10) NOT NULL,
	[creditLimit] [money] NOT NULL,
	[email] [nvarchar](255) NOT NULL,
	[phoneNumber][nvarchar](5) Not null,
	CONSTRAINT PK_Customer_custID PRIMARY KEY CLUSTERED (custId)
) ON [PRIMARY]

GO


