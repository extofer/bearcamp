USE [bearcamp]
GO

CREATE TABLE [dbo].[Events](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[Related Campaign] [int] NULL,
	[Owner] [int] NULL,
	[Start Date] [datetime] NULL,
	[End Date] [datetime] NULL,
	[Status] [nvarchar](255) NULL,
	[Fundraising Goal] [money] NULL,
 CONSTRAINT [aaaaaEvents_PK] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [CK Events] CHECK  (([Start Date]<=[End Date]))
GO


