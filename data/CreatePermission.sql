USE [bearcamp]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Permission](
	[PermissionID] [int] IDENTITY(1,1) NOT NULL,
	[UserLogin] [nvarchar](42) NULL,
	[FeatureID] [int] NULL,
	[PermissionSort] [smallint] NULL,
 CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
(
	[PermissionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Permission]  WITH CHECK ADD  CONSTRAINT [FK_Permission_Feature] FOREIGN KEY([FeatureID])
REFERENCES [dbo].[Feature] ([FeatureID])
GO

ALTER TABLE [dbo].[Permission] CHECK CONSTRAINT [FK_Permission_Feature]
GO

ALTER TABLE [dbo].[Permission]  WITH CHECK ADD  CONSTRAINT [FK_Permission_Users] FOREIGN KEY([UserLogin])
REFERENCES [dbo].[Users] ([UserLogin])
GO

ALTER TABLE [dbo].[Permission] CHECK CONSTRAINT [FK_Permission_Users]
GO


