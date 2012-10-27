CREATE TABLE [dbo].[Employees](
	[ID] [int] NOT NULL,
	[Company] [nvarchar](255) NULL,
	[Last Name] [nvarchar](255) NULL,
	[First Name] [nvarchar](255) NULL,
	[E-mail Address] [nvarchar](255) NULL,
	[Job Title] [nvarchar](255) NULL,
	[Business Phone] [nvarchar](255) NULL,
	[Home Phone] [nvarchar](255) NULL,
	[Mobile Phone] [nvarchar](255) NULL,
	[Fax Number] [nvarchar](255) NULL,
	[Address] [nvarchar](50) NULL,
	[City] [nvarchar](255) NULL,
	[State/Province] [nvarchar](255) NULL,
	[ZIP/Postal Code] [nvarchar](255) NULL,
	[Country/Region] [nvarchar](255) NULL,
	[Web Page] [ntext] NULL,
	[Notes] [ntext] NULL,
	[Attachments] [ntext] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


