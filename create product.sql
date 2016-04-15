

CREATE TABLE [dbo].[Product](
	[productId] [nchar](10) NOT NULL,
	[description] [nvarchar](255) Not NULL,
	[stock] [int] NULL,
	[price] [money] NULL,
	CONSTRAINT PK_Product_productID PRIMARY KEY CLUSTERED (productId)
) 

GO


