SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Donations](
	[DonationsID] [int] IDENTITY(1,1) NOT NULL,
	[DonorID] [int] NULL,
	[DonationAmount] [money] NOT NULL,
	[DonataionDate] [date] NOT NULL,
	[Comments] [nvarchar](343) NULL,
	[DonationType] [int] NOT NULL,
 CONSTRAINT [PK_Donations] PRIMARY KEY CLUSTERED 
(
	[DonationsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Donations]  WITH CHECK ADD  CONSTRAINT [FK_Donations_DonationTypeID] FOREIGN KEY([DonationType])
REFERENCES [dbo].[DonationTypeID] ([DonationTypeID])
GO

ALTER TABLE [dbo].[Donations] CHECK CONSTRAINT [FK_Donations_DonationTypeID]
GO

ALTER TABLE [dbo].[Donations]  WITH CHECK ADD  CONSTRAINT [FK_Donations_Donor] FOREIGN KEY([DonorID])
REFERENCES [dbo].[Donor] ([DonorID])
GO

ALTER TABLE [dbo].[Donations] CHECK CONSTRAINT [FK_Donations_Donor]
GO


