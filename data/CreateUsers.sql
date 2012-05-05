USE [bearcamp]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[UserLogin] [nvarchar](42) NOT NULL,
	[Pswd] [nvarchar](65) NOT NULL,
	[FirstName] [nvarchar](42) NULL,
	[LastName] [nvarchar](42) NULL,
	[Email] [nvarchar](57) NULL,
	[Phone] [nchar](10) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserLogin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


