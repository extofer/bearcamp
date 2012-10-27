USE [bearcamp]
GO


CREATE TABLE [dbo].[FundraisingTasks](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](255) NULL,
	[Campaign] [int] NULL,
	[Assigned To] [int] NULL,
	[Priority] [nvarchar](255) NULL,
	[Status] [nvarchar](255) NULL,
	[PercentageComplete] [float] NULL,
	[Description] [ntext] NULL,
	[StartDate] [datetime] NULL,
	[DueDate] [datetime] NULL,
	[Attachments] [ntext] NULL,
 CONSTRAINT [FundraisingTasks_PK] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


ALTER TABLE [dbo].[FundraisingTasks] ADD  DEFAULT (getdate()) FOR [StartDate]
GO

ALTER TABLE [dbo].[FundraisingTasks]  WITH CHECK ADD  CONSTRAINT [FundraisingTasks_FK00] FOREIGN KEY([Campaign])
REFERENCES [dbo].[Campaigns] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[FundraisingTasks] CHECK CONSTRAINT [FundraisingTasks_FK00]
GO
