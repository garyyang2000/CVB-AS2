CREATE TABLE [dbo].[OrderItem](
	[orderNumber] [nvarchar](10) NOT NULL,
	[productId] [nchar](10) NOT NULL,
	[quantity] [int] NOT NULL,	
	[discount] [money] NULL,
	CONSTRAINT PK_OrderItem_compPK_orderNumber_productId PRIMARY KEY CLUSTERED (orderNumber,productId),
	CONSTRAINT FK_OrderItem_productId FOREIGN KEY (productId) 
    REFERENCES Product(productID) ,
	CONSTRAINT FK_OrderItem_orderNum FOREIGN KEY (orderNumber) 
    REFERENCES [Order](orderNumber) 
	)
GO