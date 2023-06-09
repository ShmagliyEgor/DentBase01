USE [master]
GO
/****** Object:  Database [StomatClinic]    Script Date: 07.06.2023 21:18:11 ******/
CREATE DATABASE [StomatClinic]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StomatClinic', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\StomatClinic.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StomatClinic_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\StomatClinic_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [StomatClinic] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StomatClinic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StomatClinic] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StomatClinic] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StomatClinic] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StomatClinic] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StomatClinic] SET ARITHABORT OFF 
GO
ALTER DATABASE [StomatClinic] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StomatClinic] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StomatClinic] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StomatClinic] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StomatClinic] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StomatClinic] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StomatClinic] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StomatClinic] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StomatClinic] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StomatClinic] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StomatClinic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StomatClinic] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StomatClinic] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StomatClinic] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StomatClinic] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StomatClinic] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StomatClinic] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StomatClinic] SET RECOVERY FULL 
GO
ALTER DATABASE [StomatClinic] SET  MULTI_USER 
GO
ALTER DATABASE [StomatClinic] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StomatClinic] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StomatClinic] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StomatClinic] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StomatClinic] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StomatClinic] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'StomatClinic', N'ON'
GO
ALTER DATABASE [StomatClinic] SET QUERY_STORE = OFF
GO
USE [StomatClinic]
GO
/****** Object:  Table [dbo].[Avtorithations]    Script Date: 07.06.2023 21:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Avtorithations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Avtorithation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientProblems]    Script Date: 07.06.2023 21:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientProblems](
	[idClient] [int] NOT NULL,
	[idProblems] [int] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_ClientProblems] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MainClient]    Script Date: 07.06.2023 21:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MainClient](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FIO] [nvarchar](50) NOT NULL,
	[AgePacient] [int] NULL,
 CONSTRAINT [PK_MainClient] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Problems]    Script Date: 07.06.2023 21:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Problems](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nchar](100) NULL,
	[TimeRegister] [datetime] NOT NULL,
	[Cost] [int] NULL,
 CONSTRAINT [PK_Problems] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Avtorithations] ON 

INSERT [dbo].[Avtorithations] ([Id], [Login], [Password]) VALUES (1, N'111', N'111')
INSERT [dbo].[Avtorithations] ([Id], [Login], [Password]) VALUES (2, N'EShmagliy', N'111222')
SET IDENTITY_INSERT [dbo].[Avtorithations] OFF
GO
SET IDENTITY_INSERT [dbo].[ClientProblems] ON 

INSERT [dbo].[ClientProblems] ([idClient], [idProblems], [id]) VALUES (1, 2, 1)
INSERT [dbo].[ClientProblems] ([idClient], [idProblems], [id]) VALUES (1, 5, 2)
INSERT [dbo].[ClientProblems] ([idClient], [idProblems], [id]) VALUES (2, 3, 3)
INSERT [dbo].[ClientProblems] ([idClient], [idProblems], [id]) VALUES (3, 4, 4)
SET IDENTITY_INSERT [dbo].[ClientProblems] OFF
GO
SET IDENTITY_INSERT [dbo].[MainClient] ON 

INSERT [dbo].[MainClient] ([id], [FIO], [AgePacient]) VALUES (1, N'Иванов Иван Иванович', 24)
INSERT [dbo].[MainClient] ([id], [FIO], [AgePacient]) VALUES (2, N'Карасёва Ольга Дмитриевна', 10)
INSERT [dbo].[MainClient] ([id], [FIO], [AgePacient]) VALUES (3, N'Ромашкин Владислав Игаревич', 32)
SET IDENTITY_INSERT [dbo].[MainClient] OFF
GO
SET IDENTITY_INSERT [dbo].[Problems] ON 

INSERT [dbo].[Problems] ([id], [Description], [TimeRegister], [Cost]) VALUES (2, N'Стоматит                                                                                            ', CAST(N'2023-12-10T00:00:00.000' AS DateTime), 10000)
INSERT [dbo].[Problems] ([id], [Description], [TimeRegister], [Cost]) VALUES (3, N'Кариес                                                                                              ', CAST(N'2023-11-12T00:00:00.000' AS DateTime), 12000)
INSERT [dbo].[Problems] ([id], [Description], [TimeRegister], [Cost]) VALUES (4, N'Пародонтоз                                                                                          ', CAST(N'2023-12-16T00:00:00.000' AS DateTime), 24000)
INSERT [dbo].[Problems] ([id], [Description], [TimeRegister], [Cost]) VALUES (5, N'Кариес                                                                                              ', CAST(N'2023-02-21T00:00:00.000' AS DateTime), 32000)
SET IDENTITY_INSERT [dbo].[Problems] OFF
GO
ALTER TABLE [dbo].[ClientProblems]  WITH CHECK ADD  CONSTRAINT [FK_ClientProblems_MainClient] FOREIGN KEY([idClient])
REFERENCES [dbo].[MainClient] ([id])
GO
ALTER TABLE [dbo].[ClientProblems] CHECK CONSTRAINT [FK_ClientProblems_MainClient]
GO
ALTER TABLE [dbo].[ClientProblems]  WITH CHECK ADD  CONSTRAINT [FK_ClientProblems_Problems] FOREIGN KEY([idProblems])
REFERENCES [dbo].[Problems] ([id])
GO
ALTER TABLE [dbo].[ClientProblems] CHECK CONSTRAINT [FK_ClientProblems_Problems]
GO
USE [master]
GO
ALTER DATABASE [StomatClinic] SET  READ_WRITE 
GO
