USE [master]
GO
/****** Object:  Database [ActiBD]    Script Date: 3/7/2020 13:44:54 ******/
CREATE DATABASE [ActiBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ActiBD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ActiBD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ActiBD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ActiBD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ActiBD] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ActiBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ActiBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ActiBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ActiBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ActiBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ActiBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [ActiBD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ActiBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ActiBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ActiBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ActiBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ActiBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ActiBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ActiBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ActiBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ActiBD] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ActiBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ActiBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ActiBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ActiBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ActiBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ActiBD] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ActiBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ActiBD] SET RECOVERY FULL 
GO
ALTER DATABASE [ActiBD] SET  MULTI_USER 
GO
ALTER DATABASE [ActiBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ActiBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ActiBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ActiBD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ActiBD] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ActiBD', N'ON'
GO
ALTER DATABASE [ActiBD] SET QUERY_STORE = OFF
GO
USE [ActiBD]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 3/7/2020 13:44:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 3/7/2020 13:44:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [nvarchar](max) NOT NULL,
	[Dirección] [nvarchar](max) NOT NULL,
	[Dni] [int] NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Estado] [bit] NOT NULL,
	[FechaCreacion] [datetimeoffset](7) NOT NULL,
	[FechaModificacion] [datetimeoffset](7) NOT NULL,
	[Nacimiento] [datetime2](7) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[ProfesorId] [int] NULL,
	[Teléfono] [int] NOT NULL,
	[UsuarioCreacion] [nvarchar](max) NULL,
	[UsuarioModificacion] [nvarchar](max) NULL,
 CONSTRAINT [PK_Alumno] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 3/7/2020 13:44:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 3/7/2020 13:44:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 3/7/2020 13:44:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 3/7/2020 13:44:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 3/7/2020 13:44:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 3/7/2020 13:44:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[UserName] [nvarchar](256) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 3/7/2020 13:44:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 3/7/2020 13:44:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [nvarchar](max) NOT NULL,
	[Dirección] [nvarchar](max) NOT NULL,
	[Dni] [int] NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Estado] [bit] NOT NULL,
	[FechaCreacion] [datetimeoffset](7) NOT NULL,
	[FechaModificacion] [datetimeoffset](7) NOT NULL,
	[Nacimiento] [datetime2](7) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Teléfono] [int] NOT NULL,
	[UsuarioCreacion] [nvarchar](max) NULL,
	[UsuarioModificacion] [nvarchar](max) NULL,
 CONSTRAINT [PK_Profesor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'2.0.3-rtm-10026')
SET IDENTITY_INSERT [dbo].[Alumno] ON 

INSERT [dbo].[Alumno] ([Id], [Apellido], [Dirección], [Dni], [Email], [Estado], [FechaCreacion], [FechaModificacion], [Nacimiento], [Nombre], [ProfesorId], [Teléfono], [UsuarioCreacion], [UsuarioModificacion]) VALUES (8, N'Gonzalez', N'Cruz 5148', 31051111, N'gonzalez@gmail.com', 1, CAST(N'0001-01-01T00:00:00.0000000+00:00' AS DateTimeOffset), CAST(N'2020-07-03T13:39:01.6968458-03:00' AS DateTimeOffset), CAST(N'1990-08-17T00:00:00.0000000' AS DateTime2), N'Agustin', NULL, 1560005425, NULL, N'pablocuervo2215@gmail.com')
INSERT [dbo].[Alumno] ([Id], [Apellido], [Dirección], [Dni], [Email], [Estado], [FechaCreacion], [FechaModificacion], [Nacimiento], [Nombre], [ProfesorId], [Teléfono], [UsuarioCreacion], [UsuarioModificacion]) VALUES (14, N'Lopez', N'Rojas 5148', 31051111, N'lopez@gmail.com', 1, CAST(N'0001-01-01T00:00:00.0000000+00:00' AS DateTimeOffset), CAST(N'2020-07-03T13:39:08.7633099-03:00' AS DateTimeOffset), CAST(N'1990-08-17T00:00:00.0000000' AS DateTime2), N'Carlos', NULL, 1560005425, NULL, N'pablocuervo2215@gmail.com')
INSERT [dbo].[Alumno] ([Id], [Apellido], [Dirección], [Dni], [Email], [Estado], [FechaCreacion], [FechaModificacion], [Nacimiento], [Nombre], [ProfesorId], [Teléfono], [UsuarioCreacion], [UsuarioModificacion]) VALUES (21, N'Herrero', N'saraza 123', 1181584512, N'herrero@gmail.com', 1, CAST(N'2020-07-03T13:39:57.7969568-03:00' AS DateTimeOffset), CAST(N'2020-07-03T13:39:57.7969568-03:00' AS DateTimeOffset), CAST(N'1990-05-18T00:00:00.0000000' AS DateTime2), N'Tomas', NULL, 154879635, N'pablocuervo2215@gmail.com', N'pablocuervo2215@gmail.com')
INSERT [dbo].[Alumno] ([Id], [Apellido], [Dirección], [Dni], [Email], [Estado], [FechaCreacion], [FechaModificacion], [Nacimiento], [Nombre], [ProfesorId], [Teléfono], [UsuarioCreacion], [UsuarioModificacion]) VALUES (22, N'Navarro', N'sasa 478', 654445456, N'navarro@gimail.com', 1, CAST(N'2020-07-03T13:41:06.5705468-03:00' AS DateTimeOffset), CAST(N'2020-07-03T13:41:06.5705468-03:00' AS DateTimeOffset), CAST(N'1989-12-01T00:00:00.0000000' AS DateTime2), N'Pablo', NULL, 154879335, N'pablocuervo2215@gmail.com', N'pablocuervo2215@gmail.com')
SET IDENTITY_INSERT [dbo].[Alumno] OFF
INSERT [dbo].[AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName]) VALUES (N'4d6e1395-47ff-413d-9c96-3939096ac22a', N'cbbad5de-c412-44e3-abb6-7bf50b125ef0', N'Usuario', N'USUARIO')
INSERT [dbo].[AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName]) VALUES (N'8b2bfadf-b64e-4f97-90d3-26f15ad1b070', N'd883ef47-327d-481a-b5b1-b7e7dfb5bf68', N'Administrador', N'ADMINISTRADOR')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'137f0739-d0e4-4096-88f9-cf299e5d3978', N'8b2bfadf-b64e-4f97-90d3-26f15ad1b070')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3d576f24-046d-467e-b247-2662bafe83ca', N'4d6e1395-47ff-413d-9c96-3939096ac22a')
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'137f0739-d0e4-4096-88f9-cf299e5d3978', 0, N'0ec8d746-1c94-49b1-9ff8-f179256c2916', N'pablocuervo2215@gmail.com', 0, 1, NULL, N'PABLOCUERVO2215@GMAIL.COM', N'PABLOCUERVO2215@GMAIL.COM', N'AQAAAAEAACcQAAAAEMtpklkWQ7emOX10euR1myb027Ty0aptQaWnrAdp1i7AfHq184J+KbCLKc6es8cRgg==', NULL, 0, N'ed681d19-5561-43da-87c2-02b16ad14138', 0, N'pablocuervo2215@gmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'3d576f24-046d-467e-b247-2662bafe83ca', 0, N'689928c8-481f-429a-81d9-de88743d9af5', N'pablocuervo22@hotmail.com', 0, 1, NULL, N'PABLOCUERVO22@HOTMAIL.COM', N'PABLOCUERVO22@HOTMAIL.COM', N'AQAAAAEAACcQAAAAEOS90L3jflFDfVDseJJiD5J3NLhbLoW03hm5w0KCmg1PQHRFFnCBFeGBzJSNqjkLCg==', NULL, 0, N'a1f9a01c-3fe1-40fe-a1a8-70683a07d6f6', 0, N'pablocuervo22@hotmail.com')
SET IDENTITY_INSERT [dbo].[Profesor] ON 

INSERT [dbo].[Profesor] ([Id], [Apellido], [Dirección], [Dni], [Email], [Estado], [FechaCreacion], [FechaModificacion], [Nacimiento], [Nombre], [Teléfono], [UsuarioCreacion], [UsuarioModificacion]) VALUES (4, N'Damico', N'Pia 123', 29065487, N'damico@gmail.com', 1, CAST(N'0001-01-01T00:00:00.0000000+00:00' AS DateTimeOffset), CAST(N'2020-07-03T16:36:00.0701666+00:00' AS DateTimeOffset), CAST(N'1965-01-27T00:00:00.0000000' AS DateTime2), N'Gaston', 1589984755, NULL, N'pablocuervo2215@gmail.com')
INSERT [dbo].[Profesor] ([Id], [Apellido], [Dirección], [Dni], [Email], [Estado], [FechaCreacion], [FechaModificacion], [Nacimiento], [Nombre], [Teléfono], [UsuarioCreacion], [UsuarioModificacion]) VALUES (8, N'Avila', N'Callao 1123', 290586487, N'avila@gmail.com', 1, CAST(N'0001-01-01T00:00:00.0000000+00:00' AS DateTimeOffset), CAST(N'2020-07-03T16:36:10.7189968+00:00' AS DateTimeOffset), CAST(N'1995-06-10T00:00:00.0000000' AS DateTime2), N'Graciela', 15563266, NULL, N'pablocuervo2215@gmail.com')
INSERT [dbo].[Profesor] ([Id], [Apellido], [Dirección], [Dni], [Email], [Estado], [FechaCreacion], [FechaModificacion], [Nacimiento], [Nombre], [Teléfono], [UsuarioCreacion], [UsuarioModificacion]) VALUES (12, N'Senatori', N'Florida 235', 45646546, N'senatori 4564', 1, CAST(N'2020-07-03T13:42:10.8633573-03:00' AS DateTimeOffset), CAST(N'2020-07-03T13:42:10.8633573-03:00' AS DateTimeOffset), CAST(N'1985-05-05T00:00:00.0000000' AS DateTime2), N'Emmanuel', 54564554, N'pablocuervo2215@gmail.com', N'pablocuervo2215@gmail.com')
INSERT [dbo].[Profesor] ([Id], [Apellido], [Dirección], [Dni], [Email], [Estado], [FechaCreacion], [FechaModificacion], [Nacimiento], [Nombre], [Teléfono], [UsuarioCreacion], [UsuarioModificacion]) VALUES (13, N'Villelli', N'zaraza 87897', 56484654, N'villelli@gmail.com', 1, CAST(N'2020-07-03T13:42:56.7602902-03:00' AS DateTimeOffset), CAST(N'2020-07-03T13:42:56.7602902-03:00' AS DateTimeOffset), CAST(N'1980-05-06T00:00:00.0000000' AS DateTime2), N'Miguel', 5646454, N'pablocuervo2215@gmail.com', N'pablocuervo2215@gmail.com')
SET IDENTITY_INSERT [dbo].[Profesor] OFF
/****** Object:  Index [IX_Alumno_ProfesorId]    Script Date: 3/7/2020 13:44:54 ******/
CREATE NONCLUSTERED INDEX [IX_Alumno_ProfesorId] ON [dbo].[Alumno]
(
	[ProfesorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 3/7/2020 13:44:54 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 3/7/2020 13:44:54 ******/
CREATE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 3/7/2020 13:44:54 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 3/7/2020 13:44:54 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 3/7/2020 13:44:54 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_UserId]    Script Date: 3/7/2020 13:44:54 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 3/7/2020 13:44:54 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 3/7/2020 13:44:54 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Alumno]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Profesor_ProfesorId] FOREIGN KEY([ProfesorId])
REFERENCES [dbo].[Profesor] ([Id])
GO
ALTER TABLE [dbo].[Alumno] CHECK CONSTRAINT [FK_Alumno_Profesor_ProfesorId]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
USE [master]
GO
ALTER DATABASE [ActiBD] SET  READ_WRITE 
GO
