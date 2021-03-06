USE [master]
GO
CREATE DATABASE [ICTPRG403_ICTPRG404_ICTPRG410]
GO
USE [ICTPRG403_ICTPRG404_ICTPRG410]
GO
CREATE TABLE [dbo].[People](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Height] [float] NOT NULL,
	[Weight] [float] NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED ([Id] ASC)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[People] ON 
INSERT [dbo].[People] ([Id], [FirstName], [LastName], [Height], [Weight]) VALUES (1, N'Jack', N'Orange', 5.1, 81)
INSERT [dbo].[People] ([Id], [FirstName], [LastName], [Height], [Weight]) VALUES (2, N'Betty', N'Yellow', 6.1, 75)
INSERT [dbo].[People] ([Id], [FirstName], [LastName], [Height], [Weight]) VALUES (3, N'Andrew', N'Mauve', 6.3, 85)
INSERT [dbo].[People] ([Id], [FirstName], [LastName], [Height], [Weight]) VALUES (4, N'Jane', N'Black', 5.8, 71)
SET IDENTITY_INSERT [dbo].[People] OFF
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RESET_DB]
AS
BEGIN
	DELETE FROM [dbo].[People];
	SET IDENTITY_INSERT [dbo].[People] ON 
	INSERT [dbo].[People] ([Id], [FirstName], [LastName], [Height], [Weight]) VALUES (1, N'Jack', N'Orange', 5.1, 81)
	INSERT [dbo].[People] ([Id], [FirstName], [LastName], [Height], [Weight]) VALUES (2, N'Betty', N'Yellow', 6.1, 75)
	INSERT [dbo].[People] ([Id], [FirstName], [LastName], [Height], [Weight]) VALUES (3, N'Andrew', N'Mauve', 6.3, 85)
	INSERT [dbo].[People] ([Id], [FirstName], [LastName], [Height], [Weight]) VALUES (4, N'Jane', N'Black', 5.8, 71)
	SET IDENTITY_INSERT [dbo].[People] OFF
	DBCC CHECKIDENT ('dbo.People', RESEED, 4)
END
GO
USE [master]
GO
ALTER DATABASE [ICTPRG403_ICTPRG404_ICTPRG410] SET  READ_WRITE 
GO
USE [ICTPRG403_ICTPRG404_ICTPRG410]
GO
