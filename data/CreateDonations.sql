SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Donations](
	[DonationsID] [int] IDENTITY(1,1) NOT NULL,
	[DonorID] [int] NULL,
	[Description] varchar (255),
[Campaign] int,
[Event] int, 
[Owner] int, 
	[DonationAmount] [money] NOT NULL,
[Paid] bit, 
	[DonataionDate] [date] NOT NULL,
[PaymentDate] [date], 
	[Comments] [nvarchar](343) NULL,
	[DonationType] [int] NOT NULL,
[ThanksSent] bit, 
[ThanksDate] datetime, 
[ThanksAmount] money

 CONSTRAINT [PK_Donations] PRIMARY KEY CLUSTERED 
(
	[DonationsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
