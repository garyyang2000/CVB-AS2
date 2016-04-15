USE [DemoDB]
GO

/****** Object:  Table [dbo].[Order]    Script Date: 2016-04-14 10:40:00 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Order](
	[orderNumber] [nvarchar](10) NOT NULL,
	[orderDate] [date] NOT NULL,
	[shipDate] [date] NOT NULL,	
	[custId] [int] NULL
	CONSTRAINT PK_Order_orderNumber PRIMARY KEY CLUSTERED (orderNumber),
	CONSTRAINT FK_Order_custId FOREIGN KEY (custId) 
    REFERENCES Customer (custID) 
	ON UPDATE CASCADE
) ON [PRIMARY]

CREATE TABLE [dbo].[OrderItem](
	[orderNumber] [nvarchar](10) NOT NULL,
	[productId] [nchar](10) NOT NULL,
	[quantity] [int] NOT NULL,	
	[discount] [money] NULL,
	CONSTRAINT PK_OrderItem_compPK_orderNumber_productId PRIMARY KEY CLUSTERED (orderNumber,productId),
	CONSTRAINT FK_OrderItem_productId FOREIGN KEY (productId) 
    REFERENCES Product(productID) 
	CONSTRAINT FK_OrderItem_orderNum FOREIGN KEY (orderNumber) 
    REFERENCES [Order](orderNumber) 
	)
GO


