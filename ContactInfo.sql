USE [ContactInfo]
GO

CREATE TABLE [dbo].[Contacts](
	[ContactID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[EmailAddress] [varchar](50) NOT NULL,
	[Birthdate] [datetime] NULL,
	[NumberOfComputers] [int] NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[ContactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [ContactInfo]
GO

CREATE TABLE [dbo].[Addresses](
	[AddressID] [int] IDENTITY(1,1) NOT NULL,
	[ContactID] [int] NOT NULL,
	[AddressType] [varchar](50) NOT NULL,
	[AddressLine1] [varchar](50) NOT NULL,
	[AddressLine2] [varchar](50) NULL,
	[City] [varchar](50) NOT NULL,
	[StateCode] [varchar](2) NOT NULL,
	[Zip] [int] NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[AddressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_Contact] FOREIGN KEY([ContactID])
REFERENCES [dbo].[Contacts] ([ContactID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_Contact]
GO

