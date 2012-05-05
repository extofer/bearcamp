USE [bearcamp]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Donor](
	[DonorID] [int] IDENTITY(1,1) NOT NULL,
	[FastName] [nvarchar](52) NULL,
	[LastName] [nvarchar](54) NULL,
	[Email] [nvarchar](52) NULL,
	[Phone] [nchar](10) NULL,
	[Address1] [nvarchar](54) NULL,
	[Address2] [nvarchar](54) NULL,
	[City] [nvarchar](52) NULL,
	[State] [char](2) NULL,
	[Zip] [char](7) NULL,
 CONSTRAINT [PK_Donor] PRIMARY KEY CLUSTERED 
(
	[DonorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


