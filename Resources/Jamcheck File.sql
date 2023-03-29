USE [master]
GO
/****** Object:  Database [jampractice]    Script Date: 3/27/2023 1:06:19 AM ******/
CREATE DATABASE [jampractice]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'jampractice', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\jampractice.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'jampractice_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\jampractice_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [jampractice] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [jampractice].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [jampractice] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [jampractice] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [jampractice] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [jampractice] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [jampractice] SET ARITHABORT OFF 
GO
ALTER DATABASE [jampractice] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [jampractice] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [jampractice] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [jampractice] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [jampractice] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [jampractice] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [jampractice] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [jampractice] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [jampractice] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [jampractice] SET  DISABLE_BROKER 
GO
ALTER DATABASE [jampractice] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [jampractice] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [jampractice] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [jampractice] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [jampractice] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [jampractice] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [jampractice] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [jampractice] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [jampractice] SET  MULTI_USER 
GO
ALTER DATABASE [jampractice] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [jampractice] SET DB_CHAINING OFF 
GO
ALTER DATABASE [jampractice] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [jampractice] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [jampractice] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [jampractice] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [jampractice] SET QUERY_STORE = OFF
GO
USE [jampractice]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 3/27/2023 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[RoleType] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Org]    Script Date: 3/27/2023 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Org](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[company] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 3/27/2023 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fname] [nvarchar](20) NOT NULL,
	[lname] [nvarchar](20) NOT NULL,
	[username] [nvarchar](40) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[password] [nvarchar](12) NOT NULL,
	[companyid] [int] NOT NULL,
	[roletypeid] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[UserInfoes]    Script Date: 3/27/2023 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[UserInfoes] as 
select 
fname [First Name],
lname [Last Name],
Username,
Email,
Password,
R.roletype [Role],
o.company [Company]
from users u
left join Roles r on u.roletypeid = r.id
left join Org o on u.companyid = o.id
GO
/****** Object:  Table [dbo].[parishes]    Script Date: 3/27/2023 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[parishes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dealerships]    Script Date: 3/27/2023 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dealerships](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](40) NOT NULL,
	[tel] [nvarchar](10) NOT NULL,
	[address] [nvarchar](100) NULL,
	[parishid] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewDealerships]    Script Date: 3/27/2023 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Script for SelectTopNRows command from SSMS  ******/
create view [dbo].[ViewDealerships] as
SELECT 
      d.name [Name],
	  d.tel [Telephone],
      d.address [Address],
      p.name [Parish]
  FROM Dealerships d
  left join parishes p on p.id = d.parishid
GO
/****** Object:  Table [dbo].[Make]    Script Date: 3/27/2023 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Make](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleType]    Script Date: 3/27/2023 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fuel]    Script Date: 3/27/2023 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fuel](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SteeringPosition]    Script Date: 3/27/2023 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SteeringPosition](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransmissionType]    Script Date: 3/27/2023 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransmissionType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ImportFrom]    Script Date: 3/27/2023 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImportFrom](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ImportFrom] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicles]    Script Date: 3/27/2023 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[year] [int] NOT NULL,
	[makeid] [int] NOT NULL,
	[Model] [nvarchar](30) NOT NULL,
	[fuelid] [int] NOT NULL,
	[ChassisNo] [nvarchar](20) NOT NULL,
	[VinNum] [nvarchar](20) NOT NULL,
	[Mileage] [int] NOT NULL,
	[Seating] [int] NOT NULL,
	[steeringid] [int] NOT NULL,
	[bodytypeid] [int] NOT NULL,
	[transmissionid] [int] NOT NULL,
	[ImportfromID] [int] NOT NULL,
	[Importer] [nvarchar](50) NOT NULL,
	[ImportDate] [date] NOT NULL,
	[Picture] [varbinary](max) NOT NULL,
 CONSTRAINT [PK__Vehicles__3213E83FDCD6DCCC] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewVehicles]    Script Date: 3/27/2023 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



/****** Script for SelectTopNRows command from SSMS  ******/
CREATE       view [dbo].[ViewVehicles] as 
SELECT TOP (1000)
	  v.id,
	  Picture,
      m.name[Make],
	  Model,
      f.name[Fuel],
      ChassisNo,
      Vinnum [VIN],
	  year,
      Mileage,
      Seating,
      s.name[Steering],
      body.Name [BodyType],
      t.name[Transmission],
      imp.Name[ImportFrom],
      Importer,
      ImportDate
  FROM Vehicles v
  join make m on m.id = v.makeid
  join fuel f on f.id = v.fuelid
  join SteeringPosition s on s.id = v.steeringid
  join VehicleType body on body.id = v.bodytypeid
  join transmissiontype t on t.id = v.transmissionid
  join ImportFrom imp on imp.id = v.ImportFromID
  
GO
SET IDENTITY_INSERT [dbo].[Fuel] ON 
GO
INSERT [dbo].[Fuel] ([id], [name]) VALUES (1, N'')
GO
INSERT [dbo].[Fuel] ([id], [name]) VALUES (2, N'Petrol')
GO
INSERT [dbo].[Fuel] ([id], [name]) VALUES (3, N'Diesel')
GO
INSERT [dbo].[Fuel] ([id], [name]) VALUES (4, N'Electric')
GO
INSERT [dbo].[Fuel] ([id], [name]) VALUES (5, N'Hybrid')
GO
SET IDENTITY_INSERT [dbo].[Fuel] OFF
GO
SET IDENTITY_INSERT [dbo].[ImportFrom] ON 
GO
INSERT [dbo].[ImportFrom] ([id], [Name]) VALUES (1, N'')
GO
INSERT [dbo].[ImportFrom] ([id], [Name]) VALUES (2, N'Signapore')
GO
INSERT [dbo].[ImportFrom] ([id], [Name]) VALUES (3, N'Japan')
GO
INSERT [dbo].[ImportFrom] ([id], [Name]) VALUES (4, N'USA')
GO
INSERT [dbo].[ImportFrom] ([id], [Name]) VALUES (5, N'Europe')
GO
SET IDENTITY_INSERT [dbo].[ImportFrom] OFF
GO
SET IDENTITY_INSERT [dbo].[Make] ON 
GO
INSERT [dbo].[Make] ([id], [Name]) VALUES (1, N'Honda')
GO
INSERT [dbo].[Make] ([id], [Name]) VALUES (2, N'Toyota')
GO
INSERT [dbo].[Make] ([id], [Name]) VALUES (3, N'Nissan')
GO
INSERT [dbo].[Make] ([id], [Name]) VALUES (4, N'Mazda')
GO
INSERT [dbo].[Make] ([id], [Name]) VALUES (5, N'Subaru')
GO
INSERT [dbo].[Make] ([id], [Name]) VALUES (6, N'BMW')
GO
INSERT [dbo].[Make] ([id], [Name]) VALUES (7, N'Mercedes-Benz')
GO
SET IDENTITY_INSERT [dbo].[Make] OFF
GO
SET IDENTITY_INSERT [dbo].[Org] ON 
GO
INSERT [dbo].[Org] ([id], [company]) VALUES (1, N'JamCheck')
GO
INSERT [dbo].[Org] ([id], [company]) VALUES (2, N'Customs')
GO
SET IDENTITY_INSERT [dbo].[Org] OFF
GO
SET IDENTITY_INSERT [dbo].[parishes] ON 
GO
INSERT [dbo].[parishes] ([id], [name]) VALUES (1, N'Clarendon')
GO
INSERT [dbo].[parishes] ([id], [name]) VALUES (2, N'Hanover')
GO
INSERT [dbo].[parishes] ([id], [name]) VALUES (3, N'Kingston')
GO
INSERT [dbo].[parishes] ([id], [name]) VALUES (4, N'Manchester')
GO
INSERT [dbo].[parishes] ([id], [name]) VALUES (5, N'Portland')
GO
INSERT [dbo].[parishes] ([id], [name]) VALUES (6, N'St. Andrew')
GO
INSERT [dbo].[parishes] ([id], [name]) VALUES (7, N'St. Ann')
GO
INSERT [dbo].[parishes] ([id], [name]) VALUES (8, N'St. Catherine')
GO
INSERT [dbo].[parishes] ([id], [name]) VALUES (9, N'St. Elizabeth')
GO
INSERT [dbo].[parishes] ([id], [name]) VALUES (10, N'St. James')
GO
INSERT [dbo].[parishes] ([id], [name]) VALUES (11, N'St. Mary')
GO
INSERT [dbo].[parishes] ([id], [name]) VALUES (12, N'St. Thomas')
GO
INSERT [dbo].[parishes] ([id], [name]) VALUES (13, N'Trelawny')
GO
INSERT [dbo].[parishes] ([id], [name]) VALUES (14, N'Westmorland')
GO
SET IDENTITY_INSERT [dbo].[parishes] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 
GO
INSERT [dbo].[Roles] ([id], [RoleType]) VALUES (1, N'Choose a role')
GO
INSERT [dbo].[Roles] ([id], [RoleType]) VALUES (2, N'Staff')
GO
INSERT [dbo].[Roles] ([id], [RoleType]) VALUES (3, N'Manager')
GO
INSERT [dbo].[Roles] ([id], [RoleType]) VALUES (4, N'Admin')
GO
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[SteeringPosition] ON 
GO
INSERT [dbo].[SteeringPosition] ([id], [name]) VALUES (1, N'Left Hand')
GO
INSERT [dbo].[SteeringPosition] ([id], [name]) VALUES (2, N'Right Hand')
GO
SET IDENTITY_INSERT [dbo].[SteeringPosition] OFF
GO
SET IDENTITY_INSERT [dbo].[TransmissionType] ON 
GO
INSERT [dbo].[TransmissionType] ([id], [name]) VALUES (1, N'')
GO
INSERT [dbo].[TransmissionType] ([id], [name]) VALUES (2, N'Automatic')
GO
INSERT [dbo].[TransmissionType] ([id], [name]) VALUES (3, N'Manual')
GO
INSERT [dbo].[TransmissionType] ([id], [name]) VALUES (4, N'CVT')
GO
SET IDENTITY_INSERT [dbo].[TransmissionType] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 
GO
INSERT [dbo].[users] ([id], [fname], [lname], [username], [email], [password], [companyid], [roletypeid]) VALUES (4, N'Kemoy', N'Gallimore', N'kemgal', N'kemoy@gmail.com', N'Password1', 1, 4)
GO
INSERT [dbo].[users] ([id], [fname], [lname], [username], [email], [password], [companyid], [roletypeid]) VALUES (5, N'cf', N'cl', N'cc', N'c@gmail.com', N'Password1', 2, 2)
GO
INSERT [dbo].[users] ([id], [fname], [lname], [username], [email], [password], [companyid], [roletypeid]) VALUES (6, N'jf', N'jl', N'jj', N'j@gmail.com', N'Password1', 1, 2)
GO
INSERT [dbo].[users] ([id], [fname], [lname], [username], [email], [password], [companyid], [roletypeid]) VALUES (7, N'Darwin', N'Dallas', N'DDallas', N'DDallas@gmail.com', N'Password1', 1, 3)
GO
SET IDENTITY_INSERT [dbo].[users] OFF
GO
SET IDENTITY_INSERT [dbo].[Vehicles] ON 
GO
GO
SET IDENTITY_INSERT [dbo].[Vehicles] OFF
GO
SET IDENTITY_INSERT [dbo].[VehicleType] ON 
GO
INSERT [dbo].[VehicleType] ([id], [Name]) VALUES (1, N'')
GO
INSERT [dbo].[VehicleType] ([id], [Name]) VALUES (2, N'SUV')
GO
INSERT [dbo].[VehicleType] ([id], [Name]) VALUES (3, N'Hatchback')
GO
INSERT [dbo].[VehicleType] ([id], [Name]) VALUES (4, N'Convertible')
GO
INSERT [dbo].[VehicleType] ([id], [Name]) VALUES (5, N'Coupe')
GO
INSERT [dbo].[VehicleType] ([id], [Name]) VALUES (6, N'Pick-Up')
GO
INSERT [dbo].[VehicleType] ([id], [Name]) VALUES (7, N'Sedan')
GO
SET IDENTITY_INSERT [dbo].[VehicleType] OFF
GO
ALTER TABLE [dbo].[Dealerships]  WITH CHECK ADD FOREIGN KEY([parishid])
REFERENCES [dbo].[parishes] ([id])
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD FOREIGN KEY([companyid])
REFERENCES [dbo].[Org] ([id])
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD FOREIGN KEY([roletypeid])
REFERENCES [dbo].[Roles] ([id])
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK__Vehicles__bodyty__5165187F] FOREIGN KEY([bodytypeid])
REFERENCES [dbo].[VehicleType] ([id])
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK__Vehicles__bodyty__5165187F]
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK__Vehicles__fuelid__52593CB8] FOREIGN KEY([fuelid])
REFERENCES [dbo].[Fuel] ([id])
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK__Vehicles__fuelid__52593CB8]
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK__Vehicles__Import__534D60F1] FOREIGN KEY([ImportfromID])
REFERENCES [dbo].[ImportFrom] ([id])
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK__Vehicles__Import__534D60F1]
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK__Vehicles__makeid__5441852A] FOREIGN KEY([makeid])
REFERENCES [dbo].[Make] ([id])
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK__Vehicles__makeid__5441852A]
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK__Vehicles__steeri__5535A963] FOREIGN KEY([steeringid])
REFERENCES [dbo].[SteeringPosition] ([id])
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK__Vehicles__steeri__5535A963]
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK__Vehicles__transm__5629CD9C] FOREIGN KEY([transmissionid])
REFERENCES [dbo].[TransmissionType] ([id])
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK__Vehicles__transm__5629CD9C]
GO
USE [master]
GO
ALTER DATABASE [jampractice] SET  READ_WRITE 
GO