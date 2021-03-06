USE [master]
GO
/****** Object:  Database [BD2_2]    Script Date: 2017-04-27 20:54:57 ******/
CREATE DATABASE [BD2_2]
 CONTAINMENT = NONE
/* ON  PRIMARY 
( NAME = N'BD2_2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\BD2_2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BD2_2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\BD2_2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )*/
GO
ALTER DATABASE [BD2_2] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD2_2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD2_2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD2_2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD2_2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD2_2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD2_2] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD2_2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BD2_2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD2_2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD2_2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD2_2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD2_2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD2_2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD2_2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD2_2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD2_2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BD2_2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD2_2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD2_2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD2_2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD2_2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD2_2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD2_2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD2_2] SET RECOVERY FULL 
GO
ALTER DATABASE [BD2_2] SET  MULTI_USER 
GO
ALTER DATABASE [BD2_2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD2_2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD2_2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD2_2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BD2_2] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BD2_2', N'ON'
GO
ALTER DATABASE [BD2_2] SET QUERY_STORE = OFF
GO
USE [BD2_2]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [BD2_2]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 2017-04-27 20:54:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[Address_id] [int] IDENTITY NOT NULL,
	[City] [varchar](50) NOT NULL,
	[Street] [varchar](50) NOT NULL,
	[House_number] [int] NOT NULL,
	[Flat_number] [int] NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[Address_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Examination_dictionary]    Script Date: 2017-04-27 20:54:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examination_dictionary](
	[Examination_code] [varchar](30) NOT NULL,
	[Examiantion_type] [char](1) NOT NULL,
	[Examination_name] [varchar](80) NULL,
 CONSTRAINT [PK_Examintion_dictionary] PRIMARY KEY CLUSTERED 
(
	[Examination_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LAB_examination]    Script Date: 2017-04-27 20:54:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LAB_examination](
	[LAB_examination_id] [int] IDENTITY NOT NULL,
	[LAB_examination_code] [varchar](30) NOT NULL,
	[doctor_notes] [varchar](max) NULL,
	[LAB_worker_id] [int] NULL,
	[commission_examination_date] [datetime] NOT NULL,
	[LAB_examination_result] [varchar](50) NULL,
	[LAB_examination_date] [datetime] NULL,
	[LAB_manager_id] [int] NULL,
	[LAB_manager_notes] [varchar](max) NULL,
	[ending_examination_date] [datetime] NULL,
	[status] [varchar](15) NOT NULL,
	[visit_id] [int] NOT NULL,
 CONSTRAINT [PK_LAB_examination] PRIMARY KEY CLUSTERED 
(
	[LAB_examination_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patient]    Script Date: 2017-04-27 20:54:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[Patient_id] [int] IDENTITY(1,1) NOT NULL,
	[First_name] [varchar](30) NOT NULL,
	[Last_name] [varchar](30) NOT NULL,
	[Phone_number] [varchar](12) NOT NULL,
	[PESEL] [varchar](11) NOT NULL,
	[address_id] [int] NOT NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[Patient_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Physical_examination]    Script Date: 2017-04-27 20:54:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Physical_examination](
	[Physical_examination_id] [int] IDENTITY NOT NULL,
	[Physical_examination_code] [varchar](30) NOT NULL,
	[Result] [varchar](max) NOT NULL,
	[visit_id] [int] NOT NULL,
 CONSTRAINT [PK_Physical_examination] PRIMARY KEY CLUSTERED 
(
	[Physical_examination_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Visit]    Script Date: 2017-04-27 20:54:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visit](
	[visit_id] [int] IDENTITY NOT NULL,
	[description] [varchar](max) NULL,
	[diagnosis] [varchar](50) NULL,
	[status] [varchar](15) NOT NULL,
	[registration_date] [datetime] NULL,
	[ending_date] [datetime] NULL,
	[patient_id] [int] NOT NULL,
	[doctor_id] [int] NOT NULL,
	[registerer_id] [int] NOT NULL,
 CONSTRAINT [PK_Visit] PRIMARY KEY CLUSTERED 
(
	[visit_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Worker]    Script Date: 2017-04-27 20:54:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Worker](
	[Worker_id] [int] IDENTITY(1,1) NOT NULL,
	[Role] [varchar](10) NOT NULL,
	[First_name] [varchar](30) NOT NULL,
	[Last_name] [varchar](30) NOT NULL,
	[NPWZ] [int] NULL,
	[E-mail_Address] [varchar](75) NOT NULL,
	[Phone_number] [varchar](12) NOT NULL,
	[PESEL] [varchar](11) NOT NULL,
	[address_id] [int] NOT NULL,
	[Login] [varchar](30) NOT NULL,
	[Password] [varchar](40) NOT NULL,
	[Expiration_date] [datetime] NULL
 CONSTRAINT [PK_Worker] PRIMARY KEY CLUSTERED 
(
	[Worker_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[LAB_examination]  WITH CHECK ADD  CONSTRAINT [FK_LAB_examination_Examination_dictionary] FOREIGN KEY([LAB_examination_code])
REFERENCES [dbo].[Examination_dictionary] ([Examination_code])
GO
ALTER TABLE [dbo].[LAB_examination] CHECK CONSTRAINT [FK_LAB_examination_Examination_dictionary]
GO
ALTER TABLE [dbo].[LAB_examination]  WITH CHECK ADD  CONSTRAINT [FK_LAB_examination_Visit] FOREIGN KEY([visit_id])
REFERENCES [dbo].[Visit] ([visit_id])
GO
ALTER TABLE [dbo].[LAB_examination] CHECK CONSTRAINT [FK_LAB_examination_Visit]
GO
ALTER TABLE [dbo].[LAB_examination]  WITH CHECK ADD  CONSTRAINT [FK_LAB_examination_Worker] FOREIGN KEY([LAB_worker_id])
REFERENCES [dbo].[Worker] ([Worker_id])
GO
ALTER TABLE [dbo].[LAB_examination] CHECK CONSTRAINT [FK_LAB_examination_Worker]
GO
ALTER TABLE [dbo].[LAB_examination]  WITH CHECK ADD  CONSTRAINT [FK_LAB_examination_Worker1] FOREIGN KEY([LAB_manager_id])
REFERENCES [dbo].[Worker] ([Worker_id])
GO
ALTER TABLE [dbo].[LAB_examination] CHECK CONSTRAINT [FK_LAB_examination_Worker1]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Address] FOREIGN KEY([address_id])
REFERENCES [dbo].[Address] ([Address_id])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Address]
GO
ALTER TABLE [dbo].[Physical_examination]  WITH CHECK ADD  CONSTRAINT [FK_Physical_examination_Examination_dictionary] FOREIGN KEY([Physical_examination_code])
REFERENCES [dbo].[Examination_dictionary] ([Examination_code])
GO
ALTER TABLE [dbo].[Physical_examination] CHECK CONSTRAINT [FK_Physical_examination_Examination_dictionary]
GO
ALTER TABLE [dbo].[Physical_examination]  WITH CHECK ADD  CONSTRAINT [FK_Physical_examination_Visit] FOREIGN KEY([visit_id])
REFERENCES [dbo].[Visit] ([visit_id])
GO
ALTER TABLE [dbo].[Physical_examination] CHECK CONSTRAINT [FK_Physical_examination_Visit]
GO
ALTER TABLE [dbo].[Examination_dictionary]  WITH CHECK ADD  CONSTRAINT [CK_Type] CHECK  (([Examiantion_type]='L' OR [Examiantion_type]='F'))
GO
ALTER TABLE [dbo].[Examination_dictionary] CHECK CONSTRAINT [CK_Type]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Patient] FOREIGN KEY([patient_id])
REFERENCES [dbo].[Patient] ([Patient_id])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Patient]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Worker] FOREIGN KEY([doctor_id])
REFERENCES [dbo].[Worker] ([Worker_id])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Worker]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Worker1] FOREIGN KEY([registerer_id])
REFERENCES [dbo].[Worker] ([Worker_id])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Worker1]
GO
ALTER TABLE [dbo].[Worker]  WITH CHECK ADD  CONSTRAINT [FK_Worker_Address] FOREIGN KEY([address_id])
REFERENCES [dbo].[Address] ([Address_id])
GO
ALTER TABLE [dbo].[Worker] CHECK CONSTRAINT [FK_Worker_Address]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [CK_Visit] CHECK  (([status]='REJ' OR [status]='ANUL' OR [status]='ZAK'))
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [CK_Visit]
GO
USE [master]
GO
ALTER DATABASE [BD2_2] SET  READ_WRITE 
GO