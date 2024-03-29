USE [OrderingRows1]
GO
/****** Object:  Table [dbo].[Albums]    Script Date: 12/22/2023 7:13:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Albums](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[ArtistId] [int] NULL,
 CONSTRAINT [PK_Albums] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Artist]    Script Date: 12/22/2023 7:13:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artist](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Artist] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 12/22/2023 7:13:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](15) NOT NULL,
	[Description] [ntext] NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 12/22/2023 7:13:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerIdentifier] [int] NOT NULL,
	[CompanyName] [nvarchar](40) NOT NULL,
	[ContactName] [nvarchar](30) NULL,
	[ContactTitle] [nvarchar](30) NULL,
	[Address] [nvarchar](60) NULL,
	[City] [nvarchar](15) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[Country] [nvarchar](15) NULL,
	[Phone] [nvarchar](24) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 12/22/2023 7:13:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gender](
	[id] [int] NOT NULL,
	[Role] [nvarchar](max) NULL,
	[RoleId] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 12/22/2023 7:13:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] NOT NULL,
	[ProductName] [nvarchar](40) NOT NULL,
	[CategoryID] [int] NULL,
	[RowPosition] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Songs]    Script Date: 12/22/2023 7:13:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Songs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[AlbumId] [int] NULL,
	[ArtistId] [int] NULL,
 CONSTRAINT [PK_Songs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 12/22/2023 7:13:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] NOT NULL,
	[CompanyName] [nvarchar](40) NOT NULL,
	[ContactName] [nvarchar](30) NULL,
	[ContactTitle] [nvarchar](30) NULL,
	[Address] [nvarchar](60) NULL,
	[City] [nvarchar](15) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[Country] [nvarchar](15) NULL,
	[Phone] [nvarchar](24) NULL,
	[RowPosition] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Albums] ON 

INSERT [dbo].[Albums] ([id], [Name], [ArtistId]) VALUES (1, N'A Hard Day''s Night', 1)
INSERT [dbo].[Albums] ([id], [Name], [ArtistId]) VALUES (2, N'Sgt Pepper’s Lonely Hearts Club Band', 1)
SET IDENTITY_INSERT [dbo].[Albums] OFF
GO
SET IDENTITY_INSERT [dbo].[Artist] ON 

INSERT [dbo].[Artist] ([id], [Name]) VALUES (1, N'The Beatles')
SET IDENTITY_INSERT [dbo].[Artist] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [Id]) VALUES (1, N'Beverages', N'Soft drinks, coffees, teas, beers, and ales', 1)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [Id]) VALUES (2, N'Condiments', N'Sweet and savory sauces, relishes, spreads, and seasonings', 2)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [Id]) VALUES (3, N'Confections', N'Desserts, candies, and sweet breads', 3)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [Id]) VALUES (4, N'Dairy Products', N'Cheeses', 4)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [Id]) VALUES (5, N'Grains/Cereals', N'Breads, crackers, pasta, and cereal', 5)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [Id]) VALUES (6, N'Meat/Poultry', N'Prepared meats', 6)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [Id]) VALUES (7, N'Produce', N'Dried fruit and bean curd', 7)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [Id]) VALUES (8, N'Seafood', N'Seaweed and fish', 8)
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (1, N'Alfreds Futterkiste', N'Maria Anders', N'Sales Representative', N'Obere Str. 57', N'Berlin', N'12209', N'Germany', N'030-0074321')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (2, N'Ana Trujillo Emparedados y helados', N'Ana Trujillo', N'Owner', N'Avda. de la Constitución 2222', N'México D.F.', N'05021', N'Mexico', N'(5) 555-4729')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (3, N'Antonio Moreno Taquería', N'Antonio Moreno', N'Owner', N'Mataderos  2312', N'México D.F.', N'05023', N'Mexico', N'(5) 555-3932')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (4, N'Around the Horn', N'Thomas Hardy', N'Sales Representative', N'120 Hanover Sq.', N'London', N'WA1 1DP', N'UK', N'(171) 555-7788')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (5, N'Berglunds snabbköp', N'Christina Berglund', N'Order Administrator', N'Berguvsvägen  8', N'Luleå', N'S-958 22', N'Sweden', N'0921-12 34 65')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (6, N'Blauer See Delikatessen', N'Hanna Moos', N'Sales Representative', N'Forsterstr. 57', N'Mannheim', N'68306', N'Germany', N'0621-08460')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (7, N'Blondesddsl père et fils', N'Frédérique Citeaux', N'Marketing Manager', N'24, place Kléber', N'Strasbourg', N'67000', N'France', N'88.60.15.31')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (8, N'Bólido Comidas preparadas', N'Martín Sommer', N'Owner', N'C/ Araquil, 67', N'Madrid', N'28023', N'Spain', N'(91) 555 22 82')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (9, N'Bon app''', N'Laurence Lebihan', N'Owner', N'12, rue des Bouchers', N'Marseille', N'13008', N'France', N'91.24.45.40')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (10, N'B''s Beverages', N'Victoria Ashworth', N'Sales Representative', N'Fauntleroy Circus', N'London', N'EC2 5NT', N'UK', N'(171) 555-1212')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (11, N'Cactus Comidas para llevar', N'Patricio Simpson', N'Sales Agent', N'Cerrito 333', N'Buenos Aires', N'1010', N'Argentina', N'(1) 135-5555')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (12, N'Centro comercial Moctezuma', N'Francisco Chang', N'Marketing Manager', N'Sierras de Granada 9993', N'México D.F.', N'05022', N'Mexico', N'(5) 555-3392')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (13, N'Chop-suey Chinese', N'Yang Wang', N'Owner', N'Hauptstr. 29', N'Bern', N'3012', N'Switzerland', N'0452-076545')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (14, N'Consolidated Holdings', N'Elizabeth Brown', N'Sales Representative', N'Berkeley Gardens 12  Brewery', N'London', N'WX1 6LT', N'UK', N'(171) 555-2282')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (15, N'Drachenblut Delikatessen', N'Sven Ottlieb', N'Order Administrator', N'Walserweg 21', N'Aachen', N'52066', N'Germany', N'0241-039123')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (16, N'Du monde entier', N'Janine Labrune', N'Owner', N'67, rue des Cinquante Otages', N'Nantes', N'44000', N'France', N'40.67.88.88')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (17, N'Eastern Connection', N'Ann Devon', N'Sales Agent', N'35 King George', N'London', N'WX3 6FW', N'UK', N'(171) 555-0297')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (18, N'Ernst Handel', N'Roland Mendel', N'Sales Manager', N'Kirchgasse 6', N'Graz', N'8010', N'Austria', N'7675-3425')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (19, N'FISSA Fabrica Inter. Salchichas S.A.', N'Diego Roel', N'Accounting Manager', N'C/ Moralzarzal, 86', N'Madrid', N'28034', N'Spain', N'(91) 555 94 44')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (20, N'Folies gourmandes', N'Martine Rancé', N'Assistant Sales Agent', N'184, chaussée de Tournai', N'Lille', N'59000', N'France', N'20.16.10.16')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (21, N'Folk och fä HB', N'Maria Larsson', N'Owner', N'Åkergatan 24', N'Bräcke', N'S-844 67', N'Sweden', N'0695-34 67 21')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (22, N'Frankenversand', N'Peter Franken', N'Marketing Manager', N'Berliner Platz 43', N'München', N'80805', N'Germany', N'089-0877310')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (23, N'France restauration', N'Carine Schmitt', N'Marketing Manager', N'54, rue Royale', N'Nantes', N'44000', N'France', N'40.32.21.21')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (24, N'Franchi S.p.A.', N'Paolo Accorti', N'Sales Representative', N'Via Monte Bianco 34', N'Torino', N'10100', N'Italy', N'011-4988260')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (25, N'Furia Bacalhau e Frutos do Mar', N'Lino Rodriguez', N'Sales Manager', N'Jardim das rosas n. 32', N'Lisboa', N'1675', N'Portugal', N'(1) 354-2534')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (26, N'Galería del gastrónomo', N'Eduardo Saavedra', N'Marketing Manager', N'Rambla de Cataluña, 23', N'Barcelona', N'08022', N'Spain', N'(93) 203 4560')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (27, N'Godos Cocina Típica', N'José Pedro Freyre', N'Sales Manager', N'C/ Romero, 33', N'Sevilla', N'41101', N'Spain', N'(95) 555 82 82')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (28, N'Königlich Essen', N'Philip Cramer', N'Sales Associate', N'Maubelstr. 90', N'Brandenburg', N'14776', N'Germany', N'0555-09876')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (29, N'La corne d''abondance', N'Daniel Tonini', N'Sales Representative', N'67, avenue de l''Europe', N'Versailles', N'78000', N'France', N'30.59.84.10')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (30, N'La maison d''Asie', N'Annette Roulet', N'Sales Manager', N'1 rue Alsace-Lorraine', N'Toulouse', N'31000', N'France', N'61.77.61.10')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (31, N'Lehmanns Marktstand', N'Renate Messner', N'Sales Representative', N'Magazinweg 7', N'Frankfurt a.M.', N'60528', N'Germany', N'069-0245984')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (32, N'Magazzini Alimentari Riuniti', N'Giovanni Rovelli', N'Marketing Manager', N'Via Ludovico il Moro 22', N'Bergamo', N'24100', N'Italy', N'035-640230')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (33, N'Maison Dewey', N'Catherine Dewey', N'Sales Agent', N'Rue Joseph-Bens 532', N'Bruxelles', N'B-1180', N'Belgium', N'(02) 201 24 67')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (34, N'Morgenstern Gesundkost', N'Alexander Feuer', N'Marketing Assistant', N'Heerstr. 22', N'Leipzig', N'04179', N'Germany', N'0342-023176')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (35, N'North/South', N'Simon Crowther', N'Sales Associate', N'South House 300 Queensbridge', N'London', N'SW7 1RZ', N'UK', N'(171) 555-7733')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (36, N'Océano Atlántico Ltda.', N'Yvonne Moncada', N'Sales Agent', N'Ing. Gustavo Moncada 8585 Piso 20-A', N'Buenos Aires', N'1010', N'Argentina', N'(1) 135-5333')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (37, N'Ottilies Käseladen', N'Henriette Pfalzheim', N'Owner', N'Mehrheimerstr. 369', N'Köln', N'50739', N'Germany', N'0221-0644327')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (38, N'Paris spécialités', N'Marie Bertrand', N'Owner', N'265, boulevard Charonne', N'Paris', N'75012', N'France', N'(1) 42.34.22.66')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (39, N'Pericles Comidas clásicas', N'Guillermo Fernández', N'Sales Representative', N'Calle Dr. Jorge Cash 321', N'México D.F.', N'05033', N'Mexico', N'(5) 552-3745')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (40, N'Piccolo und mehr', N'Georg Pipps', N'Sales Manager', N'Geislweg 14', N'Salzburg', N'5020', N'Austria', N'6562-9722')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (41, N'Princesa Isabel Vinhos', N'Isabel de Castro', N'Sales Representative', N'Estrada da saúde n. 58', N'Lisboa', N'1756', N'Portugal', N'(1) 356-5634')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (42, N'QUICK Stop', N'Horst Kloss', N'Accounting Manager', N'Taucherstraße 10', N'Cunewalde', N'01307', N'Germany', N'0372-035188')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (43, N'Rancho grande', N'Sergio Gutiérrez', N'Sales Representative', N'Av. del Libertador 900', N'Buenos Aires', N'1010', N'Argentina', N'(1) 123-5555')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (44, N'Reggiani Caseifici', N'Maurizio Moroni', N'Sales Associate', N'Strada Provinciale 124', N'Reggio Emilia', N'42100', N'Italy', N'0522-556721')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (45, N'Richter Supermarkt', N'Michael Holz', N'Sales Manager', N'Grenzacherweg 237', N'Genève', N'1203', N'Switzerland', N'0897-034214')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (46, N'Romero y tomillo', N'Alejandra Camino', N'Accounting Manager', N'Gran Vía, 1', N'Madrid', N'28001', N'Spain', N'(91) 745 6200')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (47, N'Santé Gourmet', N'Jonas Bergulfsen', N'Owner', N'Erling Skakkes gate 78', N'Stavern', N'4110', N'Norway', N'07-98 92 35')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (48, N'Seven Seas Imports', N'Hari Kumar', N'Sales Manager', N'90 Wadhurst Rd.', N'London', N'OX15 4NB', N'UK', N'(171) 555-1717')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (49, N'Simons bistro', N'Jytte Petersen', N'Owner', N'Vinbæltet 34', N'Kobenhavn', N'1734', N'Denmark', N'31 12 34 56')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (50, N'Spécialités du monde', N'Dominique Perrier', N'Marketing Manager', N'25, rue Lauriston', N'Paris', N'75016', N'France', N'(1) 47.55.60.10')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (51, N'Suprêmes délices', N'Pascale Cartrain', N'Accounting Manager', N'Boulevard Tirou, 255', N'Charleroi', N'B-6000', N'Belgium', N'(071) 23 67 22 20')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (52, N'Toms Spezialitäten', N'Karin Josephs', N'Marketing Manager', N'Luisenstr. 48', N'Münster', N'44087', N'Germany', N'0251-031259')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (53, N'Tortuga Restaurante', N'Miguel Angel Paolino', N'Owner', N'Avda. Azteca 123', N'México D.F.', N'05033', N'Mexico', N'(5) 555-2933')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (54, N'Vaffeljernet', N'Palle Ibsen', N'Sales Manager', N'Smagsloget 45', N'Århus', N'8200', N'Denmark', N'86 21 32 43')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (55, N'Victuailles en stock', N'Mary Saveley', N'Sales Agent', N'2, rue du Commerce', N'Lyon', N'69004', N'France', N'78.32.54.86')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (56, N'Vins et alcools Chevalier', N'Paul Henriot', N'Accounting Manager', N'59 rue de l''Abbaye', N'Reims', N'51100', N'France', N'26.47.15.10')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (57, N'Die Wandernde Kuh', N'Rita Müller', N'Sales Representative', N'Adenauerallee 900', N'Stuttgart', N'70563', N'Germany', N'0711-020361')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (58, N'Wartian Herkku', N'Pirkko Koskitalo', N'Accounting Manager', N'Torikatu 38', N'Oulu', N'90110', N'Finland', N'981-443655')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (59, N'Wilman Kala', N'Matti Karttunen', N'Owner/Marketing Assistant', N'Keskuskatu 45', N'Helsinki', N'21240', N'Finland', N'90-224 8858')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (60, N'Wolski  Zajazd', N'Zbyszek Piestrzeniewicz', N'Owner', N'ul. Filtrowa 68', N'Warszawa', N'01-012', N'Poland', N'(26) 642-7012')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (61, N'Old World Delicatessen', N'Rene Phillips', N'Sales Representative', N'2743 Bering St.', N'Anchorage', N'99508', N'USA', N'(907) 555-7584')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (62, N'Bottom-Dollar Markets', N'Elizabeth Lincoln', N'Accounting Manager', N'23 Tsawassen Blvd.', N'Tsawassen', N'T2F 8M4', N'Canada', N'(604) 555-4729')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (63, N'Laughing Bacchus Wine Cellars', N'Yoshi Tannamuri', N'Marketing Assistant', N'1900 Oak St.', N'Vancouver', N'V3F 2K1', N'Canada', N'(604) 555-3392')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (64, N'Let''s Stop N Shop', N'Jaime Yorres', N'Owner', N'87 Polk St. Suite 5', N'San Francisco', N'94117', N'USA', N'(415) 555-5938')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (65, N'Hungry Owl All-Night Grocers', N'Patricia McKenna', N'Sales Associate', N'8 Johnstown Road', N'Cork', NULL, N'Ireland', N'2967 542')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (66, N'GROSELLA-Restaurante', N'Manuel Pereira', N'Owner', N'5ª Ave. Los Palos Grandes', N'Caracas', N'1081', N'Venezuela', N'(2) 283-2951')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (67, N'Save-a-lot Markets', N'Jose Pavarotti', N'Sales Representative', N'187 Suffolk Ln.', N'Boise', N'83720', N'USA', N'(208) 555-8097')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (68, N'Island Trading', N'Helen Bennett', N'Marketing Manager', N'Garden House Crowther Way', N'Cowes', N'PO31 7PJ', N'UK', N'(198) 555-8888')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (69, N'LILA-Supermercado', N'Carlos González', N'Accounting Manager', N'Carrera 52 con Ave. Bolívar #65-98 Llano Largo', N'Barquisimeto', N'3508', N'Venezuela', N'(9) 331-6954')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (70, N'The Cracker Box', N'Liu Wong', N'Marketing Assistant', N'55 Grizzly Peak Rd.', N'Butte', N'59801', N'USA', N'(406) 555-5834')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (71, N'Rattlesnake Canyon Grocery', N'Paula Wilson', N'Assistant Sales Representative', N'2817 Milton Dr.', N'Albuquerque', N'87110', N'USA', N'(505) 555-5939')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (72, N'LINO-Delicateses', N'Felipe Izquierdo', N'Owner', N'Ave. 5 de Mayo Porlamar', N'I. de Margarita', N'4980', N'Venezuela', N'(8) 34-56-12')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (73, N'Great Lakes Food Market', N'Howard Snyder', N'Marketing Manager', N'2732 Baker Blvd.', N'Eugene', N'97403', N'USA', N'(503) 555-7555')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (74, N'Hungry Coyote Import Store', N'Yoshi Latimer', N'Sales Representative', N'City Center Plaza 516 Main St.', N'Elgin', N'97827', N'USA', N'(503) 555-6874')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (75, N'Lonesome Pine Restaurant', N'Fran Wilson', N'Sales Manager', N'89 Chiaroscuro Rd.', N'Portland', N'97219', N'USA', N'(503) 555-9573')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (76, N'The Big Cheese', N'Liz Nixon', N'Marketing Manager', N'89 Jefferson Way Suite 2', N'Portland', N'97201', N'USA', N'(503) 555-3612')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (77, N'Mère Paillarde', N'Jean Fresnière', N'Marketing Assistant', N'43 rue St. Laurent', N'Montréal', N'H1J 1C3', N'Canada', N'(514) 555-8054')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (78, N'Hanari Carnes', N'Mario Pontes', N'Accounting Manager', N'Rua do Paço, 67', N'Rio de Janeiro', N'05454-876', N'Brazil', N'(21) 555-0091')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (79, N'Que Delícia', N'Bernardo Batista', N'Accounting Manager', N'Rua da Panificadora, 12', N'Rio de Janeiro', N'02389-673', N'Brazil', N'(21) 555-4252')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (80, N'Ricardo Adocicados', N'Janete Limeira', N'Assistant Sales Agent', N'Av. Copacabana, 267', N'Rio de Janeiro', N'02389-890', N'Brazil', N'(21) 555-3412')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (81, N'Comércio Mineiro', N'Pedro Afonso', N'Sales Associate', N'Av. dos Lusíadas, 23', N'Sao Paulo', N'05432-043', N'Brazil', N'(11) 555-7647')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (82, N'Familia Arquibaldo', N'Aria Cruz', N'Marketing Assistant', N'Rua Orós, 92', N'Sao Paulo', N'05442-030', N'Brazil', N'(11) 555-9857')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (83, N'Gourmet Lanchonetes', N'André Fonseca', N'Sales Associate', N'Av. Brasil, 442', N'Campinas', N'04876-786', N'Brazil', N'(11) 555-9482')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (84, N'Queen Cozinha', N'Lúcia Carvalho', N'Marketing Assistant', N'Alameda dos Canàrios, 891', N'Sao Paulo', N'05487-020', N'Brazil', N'(11) 555-1189')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (85, N'Tradição Hipermercados', N'Anabela Domingues', N'Sales Representative', N'Av. Inês de Castro, 414', N'Sao Paulo', N'05634-030', N'Brazil', N'(11) 555-2167')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (86, N'Wellington Importadora', N'Paula Parente', N'Sales Manager', N'Rua do Mercado, 12', N'Resende', N'08737-363', N'Brazil', N'(14) 555-8122')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (87, N'HILARION-Abastos', N'Carlos Hernández', N'Sales Representative', N'Carrera 22 con Ave. Carlos Soublette #8-35', N'San Cristóbal', N'5022', N'Venezuela', N'(5) 555-1340')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (88, N'Lazy K Kountry Store', N'John Steel', N'Marketing Manager', N'12 Orchestra Terrace', N'Walla Walla', N'99362', N'USA', N'(509) 555-7969')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (89, N'Trail''s Head Gourmet Provisioners', N'Helvetius Nagy', N'Sales Associate', N'722 DaVinci Blvd.', N'Kirkland', N'98034', N'USA', N'(206) 555-8257')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (90, N'White Clover Markets', N'Karl Jablonski', N'Owner', N'305 - 14th Ave. S. Suite 3B', N'Seattle', N'98128', N'USA', N'(206) 555-4112')
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone]) VALUES (91, N'Split Rail Beer & Ale', N'Art Braunschweiger', N'Sales Manager', N'P.O. Box 555', N'Lander', N'82520', N'USA', N'(307) 555-4680')
GO
INSERT [dbo].[Gender] ([id], [Role], [RoleId]) VALUES (1, N'Male', 1)
INSERT [dbo].[Gender] ([id], [Role], [RoleId]) VALUES (2, N'Female', 2)
INSERT [dbo].[Gender] ([id], [Role], [RoleId]) VALUES (3, N'Other', 3)
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (1, N'Chai', 1, 6)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (2, N'Chang', 1, 4)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (3, N'Aniseed Syrup', 2, 2)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (4, N'Chef Anton''s Cajun Seasoning', 2, 0)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (5, N'Chef Anton''s Gumbo Mix', 2, 3)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (6, N'Grandma''s Boysenberry Spread', 2, 5)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (7, N'Uncle Bob''s Organic Dried Pears', 7, 4)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (8, N'Northwoods Cranberry Sauce', 2, 9)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (9, N'Mishi Kobe Niku', 6, 0)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (10, N'Ikura', 8, 5)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (11, N'Queso Cabrales', 4, 7)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (12, N'Queso Manchego La Pastora', 4, 8)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (13, N'Konbu', 8, 8)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (14, N'Tofu', 7, 3)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (15, N'Genen Shouyu', 2, 4)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (16, N'Pavlova', 3, 4)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (17, N'Alice Mutton', 6, 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (18, N'Carnarvon Tigers', 8, 2)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (19, N'Teatime Chocolate Biscuits', 3, 11)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (20, N'Sir Rodney''s Marmalade', 3, 8)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (21, N'Sir Rodney''s Scones', 3, 9)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (22, N'Gustaf''s Knäckebröd', 5, 2)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (23, N'Tunnbröd', 5, 5)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (24, N'Guaraná Fantástica', 1, 9)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (25, N'NuNuCa Nuß-Nougat-Creme', 3, 3)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (26, N'Gumbär Gummibärchen', 3, 0)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (27, N'Schoggi Schokolade', 3, 6)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (28, N'Rössle Sauerkraut', 7, 2)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (29, N'Thüringer Rostbratwurst', 6, 4)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (30, N'Nord-Ost Matjeshering', 8, 9)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (31, N'Gorgonzola Telino', 4, 3)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (32, N'Mascarpone Fabioli', 4, 5)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (33, N'Geitost', 4, 0)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (34, N'Sasquatch Ale', 1, 2)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (35, N'Steeleye Stout', 1, 3)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (36, N'Inlagd Sill', 8, 6)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (37, N'Gravad lax', 8, 4)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (38, N'Côte de Blaye', 1, 11)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (39, N'Chartreuse verte', 1, 5)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (40, N'Boston Crab Meat', 8, 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (41, N'Jack''s New England Clam Chowder', 8, 7)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (42, N'Singaporean Hokkien Fried Mee', 5, 4)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (43, N'Ipoh Coffee', 1, 7)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (44, N'Gula Malacca', 2, 6)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (45, N'Rogede sild', 8, 10)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (46, N'Spegesild', 8, 11)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (47, N'Zaanse koeken', 3, 5)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (48, N'Chocolade', 3, 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (49, N'Maxilaku', 3, 2)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (50, N'Valkoinen suklaa', 3, 12)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (51, N'Manjimup Dried Apples', 7, 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (52, N'Filo Mix', 5, 0)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (53, N'Perth Pasties', 6, 3)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (54, N'Tourtière', 6, 5)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (55, N'Pâté chinois', 6, 2)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (56, N'Gnocchi di nonna Alice', 5, 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (57, N'Ravioli Angelo', 5, 3)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (58, N'Escargots de Bourgogne', 8, 3)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (59, N'Raclette Courdavault', 4, 9)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (60, N'Camembert Pierrot', 4, 2)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (61, N'Sirop d''érable', 2, 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (62, N'Tarte au sucre', 3, 10)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (63, N'Vegie-spread', 2, 11)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (64, N'Wimmers gute Semmelknödel', 5, 6)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (65, N'Louisiana Fiery Hot Pepper Sauce', 2, 7)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (66, N'Louisiana Hot Spiced Okra', 2, 8)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (67, N'Laughing Lumberjack Lager', 1, 0)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (68, N'Scottish Longbreads', 3, 7)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (69, N'Gudbrandsdalsost', 4, 4)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (70, N'Outback Lager', 1, 8)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (71, N'Flotemysost', 4, 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (72, N'Mozzarella di Giovanni', 4, 6)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (73, N'Röd Kaviar', 8, 0)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (74, N'Longlife Tofu', 7, 0)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (75, N'Rhönbräu Klosterbier', 1, 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (76, N'Lakkalikööri', 1, 10)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [RowPosition]) VALUES (77, N'Original Frankfurter grüne Soße', 2, 10)
GO
SET IDENTITY_INSERT [dbo].[Songs] ON 

INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (1, N'A Hard Day''s Night', 1, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (2, N'I Should Have Known Better', 1, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (3, N'If I Fell', 1, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (4, N'I''m Happy Just To Dance With You', 1, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (5, N'And I Love Her', 1, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (6, N'Tell Me Why', 1, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (7, N'Can''t Buy Me Love', 1, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (8, N'Any Time At All', 1, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (9, N'I''ll Cry Instead', 1, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (10, N'Things We Said Today', 1, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (11, N'When I Get Home', 1, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (12, N'You Can''t Do That', 1, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (13, N'I''ll Be Back', 1, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (14, N'Sgt Pepper''s Lonely Hearts Club Band', 2, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (15, N'With A Little Help From My Friends', 2, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (16, N'Lucy In The Sky With Diamonds', 2, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (17, N'Getting Better', 2, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (18, N'Fixing A Hole', 2, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (19, N'She''s Leaving Home', 2, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (20, N'Being For The Benefit Of Mr Kite!', 2, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (21, N'Within You Without You', 2, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (22, N'When I''m Sixty-Four', 2, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (23, N'Lovely Rita', 2, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (24, N'Good Morning Good Morning', 2, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (25, N'Sgt Pepper''s Lonely Hearts Club Band (Reprise)', 2, 1)
INSERT [dbo].[Songs] ([id], [Name], [AlbumId], [ArtistId]) VALUES (26, N'A Day In The Life', 2, 1)
SET IDENTITY_INSERT [dbo].[Songs] OFF
GO
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (1, N'Exotic Liquids', N'Charlotte Cooper', N'Purchasing Manager', N'49 Gilbert St.', N'London', N'EC1 4SD', N'UK', N'(171) 555-2222', 1)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (2, N'New Orleans Cajun Delights', N'Shelley Burke', N'Order Administrator', N'P.O. Box 78934', N'New Orleans', N'70117', N'USA', N'(100) 555-4822', 2)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (3, N'Grandma Kelly''s Homestead', N'Regina Murphy', N'Sales Representative', N'707 Oxford Rd.', N'Ann Arbor', N'48104', N'USA', N'(313) 555-5735', 3)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (4, N'Tokyo Traders', N'Yoshi Nagase', N'Marketing Manager', N'9-8 Sekimai Musashino-shi', N'Tokyo', N'100', N'Japan', N'(03) 3555-5011', 4)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (5, N'Cooperativa de Quesos ''Las Cabras''', N'Antonio del Valle Saavedra', N'Export Administrator', N'Calle del Rosal 4', N'Oviedo', N'33007', N'Spain', N'(98) 598 76 54', 5)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (6, N'Mayumi''s', N'Mayumi Ohno', N'Marketing Representative', N'92 Setsuko Chuo-ku', N'Osaka', N'545', N'Japan', N'(06) 431-7877', 6)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (7, N'Pavlova, Ltd.', N'Ian Devling', N'Marketing Manager', N'74 Rose St. Moonie Ponds', N'Melbourne', N'3058', N'Australia', N'(03) 444-2343', 7)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (8, N'Specialty Biscuits, Ltd.', N'Peter Wilson', N'Sales Representative', N'29 King''s Way', N'Manchester', N'M14 GSD', N'UK', N'(161) 555-4448', 8)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (9, N'PB Knäckebröd AB', N'Lars Peterson', N'Sales Agent', N'Kaloadagatan 13', N'Göteborg', N'S-345 67', N'Sweden', N'031-987 65 43', 9)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (10, N'Refrescos Americanas LTDA', N'Carlos Diaz', N'Marketing Manager', N'Av. das Americanas 12.890', N'Sao Paulo', N'5442', N'Brazil', N'(11) 555 4640', 10)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (11, N'Heli Süßwaren GmbH & Co. KG', N'Petra Winkler', N'Sales Manager', N'Tiergartenstraße 5', N'Berlin', N'10785', N'Germany', N'(010) 9984510', 11)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (12, N'Plutzer Lebensmittelgroßmärkte AG', N'Martin Bein', N'International Marketing Mgr.', N'Bogenallee 51', N'Frankfurt', N'60439', N'Germany', N'(069) 992755', 12)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (13, N'Nord-Ost-Fisch Handelsgesellschaft mbH', N'Sven Petersen', N'Coordinator Foreign Markets', N'Frahmredder 112a', N'Cuxhaven', N'27478', N'Germany', N'(04721) 8713', 13)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (14, N'Formaggi Fortini s.r.l.', N'Elio Rossi', N'Sales Representative', N'Viale Dante, 75', N'Ravenna', N'48100', N'Italy', N'(0544) 60323', 14)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (15, N'Norske Meierier', N'Beate Vileid', N'Marketing Manager', N'Hatlevegen 5', N'Sandvika', N'1320', N'Norway', N'(0)2-953010', 15)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (16, N'Bigfoot Breweries', N'Cheryl Saylor', N'Regional Account Rep.', N'3400 - 8th Avenue Suite 210', N'Bend', N'97101', N'USA', N'(503) 555-9931', 16)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (17, N'Svensk Sjöföda AB', N'Michael Björn', N'Sales Representative', N'Brovallavägen 231', N'Stockholm', N'S-123 45', N'Sweden', N'08-123 45 67', 17)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (18, N'Aux joyeux ecclésiastiques', N'Guylène Nodier', N'Sales Manager', N'203, Rue des Francs-Bourgeois', N'Paris', N'75004', N'France', N'(1) 03.83.00.68', 18)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (19, N'New England Seafood Cannery', N'Robb Merchant', N'Wholesale Account Agent', N'Order Processing Dept. 2100 Paul Revere Blvd.', N'Boston', N'02134', N'USA', N'(617) 555-3267', 19)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (20, N'Leka Trading', N'Chandra Leka', N'Owner', N'471 Serangoon Loop, Suite #402', N'Singapore', N'0512', N'Singapore', N'555-8787', 20)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (21, N'Lyngbysild', N'Niels Petersen', N'Sales Manager', N'Lyngbysild Fiskebakken 10', N'Lyngby', N'2800', N'Denmark', N'43844108', 21)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (22, N'Zaanse Snoepfabriek', N'Dirk Luchte', N'Accounting Manager', N'Verkoop Rijnweg 22', N'Zaandam', N'9999 ZZ', N'Netherlands', N'(12345) 1212', 22)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (23, N'Karkki Oy', N'Anne Heikkonen', N'Product Manager', N'Valtakatu 12', N'Lappeenranta', N'53120', N'Finland', N'(953) 10956', 23)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (24, N'G''day, Mate', N'Wendy Mackenzie', N'Sales Representative', N'170 Prince Edward Parade Hunter''s Hill', N'Sydney', N'2042', N'Australia', N'(02) 555-5914', 24)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (25, N'Ma Maison', N'Jean-Guy Lauzon', N'Marketing Manager', N'2960 Rue St. Laurent', N'Montréal', N'H1J 1C3', N'Canada', N'(514) 555-9022', 25)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (26, N'Pasta Buttini s.r.l.', N'Giovanni Giudici', N'Order Administrator', N'Via dei Gelsomini, 153', N'Salerno', N'84100', N'Italy', N'(089) 6547665', 26)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (27, N'Escargots Nouveaux', N'Marie Delamare', N'Sales Manager', N'22, rue H. Voiron', N'Montceau', N'71300', N'France', N'85.57.00.07', 27)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (28, N'Gai pâturage', N'Eliane Noz', N'Sales Representative', N'Bat. B 3, rue des Alpes', N'Annecy', N'74000', N'France', N'38.76.98.06', 28)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [PostalCode], [Country], [Phone], [RowPosition]) VALUES (29, N'Forêts d''érables', N'Chantal Goulet', N'Accounting Manager', N'148 rue Chasseur', N'Ste-Hyacinthe', N'J2S 7S8', N'Canada', N'(514) 555-2955', 29)
GO
ALTER TABLE [dbo].[Albums]  WITH CHECK ADD  CONSTRAINT [FK_Albums_Artist] FOREIGN KEY([ArtistId])
REFERENCES [dbo].[Artist] ([id])
GO
ALTER TABLE [dbo].[Albums] CHECK CONSTRAINT [FK_Albums_Artist]
GO
ALTER TABLE [dbo].[Songs]  WITH CHECK ADD  CONSTRAINT [FK_Songs_Albums] FOREIGN KEY([AlbumId])
REFERENCES [dbo].[Albums] ([id])
GO
ALTER TABLE [dbo].[Songs] CHECK CONSTRAINT [FK_Songs_Albums]
GO
USE [master]
GO
ALTER DATABASE [OrderingRows1] SET  READ_WRITE 
GO
