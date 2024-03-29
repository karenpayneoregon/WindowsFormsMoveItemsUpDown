/****** 
 Create a database called InsertExamples than run this script.
 ******/

USE [InsertExamples]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 11/28/2023 4:59:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON

/****** Object:  Table [dbo].[Person]    Script Date: 11/28/2023 4:59:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[BirthDate] [date] NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [InsertExamples] SET  READ_WRITE 
GO
