USE [master]
GO
/****** Object:  Database [SistemaAirCenter]    Script Date: 24/11/2019 09:28:31 p. m. ******/
--CREATE DATABASE [SistemaAirCenter]
USE [SistemaAirCenter]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 24/11/2019 09:28:31 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[idClient] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[idClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permissions]    Script Date: 24/11/2019 09:28:31 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permissions](
	[idPermission] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](20) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_Permissions] PRIMARY KEY CLUSTERED 
(
	[idPermission] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 24/11/2019 09:28:31 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[idRole] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[idRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolesPermissions]    Script Date: 24/11/2019 09:28:31 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolesPermissions](
	[idRole] [int] NOT NULL,
	[idPermission] [int] NOT NULL,
 CONSTRAINT [PK_RolesPermissions] PRIMARY KEY CLUSTERED 
(
	[idRole] ASC,
	[idPermission] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 24/11/2019 09:28:31 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[idUser] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[password] [varchar](25) NOT NULL,
	[user] [varchar](50) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersRoles]    Script Date: 24/11/2019 09:28:31 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersRoles](
	[idUser] [int] NOT NULL,
	[idRole] [int] NOT NULL,
 CONSTRAINT [PK_UsersRoles] PRIMARY KEY CLUSTERED 
(
	[idUser] ASC,
	[idRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Permissions] ON 
GO
INSERT [dbo].[Permissions] ([idPermission], [name], [status]) VALUES (1, N'Usuarios', 1)
GO
INSERT [dbo].[Permissions] ([idPermission], [name], [status]) VALUES (2, N'Roles', 1)
GO
INSERT [dbo].[Permissions] ([idPermission], [name], [status]) VALUES (3, N'Productos', 1)
GO
INSERT [dbo].[Permissions] ([idPermission], [name], [status]) VALUES (4, N'Documentos', 1)
GO
INSERT [dbo].[Permissions] ([idPermission], [name], [status]) VALUES (5, N'Cotizaciones', 1)
GO
INSERT [dbo].[Permissions] ([idPermission], [name], [status]) VALUES (6, N'Clientes', 1)
GO
SET IDENTITY_INSERT [dbo].[Permissions] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 
GO
INSERT [dbo].[Roles] ([idRole], [name], [status]) VALUES (1, N'Administrador', 1)
GO
INSERT [dbo].[Roles] ([idRole], [name], [status]) VALUES (2, N'Capturista', 1)
GO
INSERT [dbo].[Roles] ([idRole], [name], [status]) VALUES (3, N'prueba2', 0)
GO
INSERT [dbo].[Roles] ([idRole], [name], [status]) VALUES (4, N'prueba3', 0)
GO
INSERT [dbo].[Roles] ([idRole], [name], [status]) VALUES (5, N'prueba5', 0)
GO
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
INSERT [dbo].[RolesPermissions] ([idRole], [idPermission]) VALUES (1, 1)
GO
INSERT [dbo].[RolesPermissions] ([idRole], [idPermission]) VALUES (1, 2)
GO
INSERT [dbo].[RolesPermissions] ([idRole], [idPermission]) VALUES (1, 3)
GO
INSERT [dbo].[RolesPermissions] ([idRole], [idPermission]) VALUES (1, 4)
GO
INSERT [dbo].[RolesPermissions] ([idRole], [idPermission]) VALUES (1, 5)
GO
INSERT [dbo].[RolesPermissions] ([idRole], [idPermission]) VALUES (1, 6)
GO
INSERT [dbo].[RolesPermissions] ([idRole], [idPermission]) VALUES (2, 3)
GO
INSERT [dbo].[RolesPermissions] ([idRole], [idPermission]) VALUES (2, 4)
GO
INSERT [dbo].[RolesPermissions] ([idRole], [idPermission]) VALUES (2, 5)
GO
INSERT [dbo].[RolesPermissions] ([idRole], [idPermission]) VALUES (2, 6)
GO
INSERT [dbo].[RolesPermissions] ([idRole], [idPermission]) VALUES (3, 1)
GO
INSERT [dbo].[RolesPermissions] ([idRole], [idPermission]) VALUES (3, 2)
GO
INSERT [dbo].[RolesPermissions] ([idRole], [idPermission]) VALUES (4, 1)
GO
INSERT [dbo].[RolesPermissions] ([idRole], [idPermission]) VALUES (4, 2)
GO
INSERT [dbo].[RolesPermissions] ([idRole], [idPermission]) VALUES (5, 2)
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([idUser], [name], [password], [user], [status]) VALUES (1, N'Ruben', N'a', N'admin', 1)
GO
INSERT [dbo].[Users] ([idUser], [name], [password], [user], [status]) VALUES (2, N'paul', N'1', N'paul', 1)
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
INSERT [dbo].[UsersRoles] ([idUser], [idRole]) VALUES (1, 1)
GO
INSERT [dbo].[UsersRoles] ([idUser], [idRole]) VALUES (2, 2)
GO
ALTER TABLE [dbo].[RolesPermissions]  WITH CHECK ADD  CONSTRAINT [FK_RolesPermissions_Permissions] FOREIGN KEY([idPermission])
REFERENCES [dbo].[Permissions] ([idPermission])
GO
ALTER TABLE [dbo].[RolesPermissions] CHECK CONSTRAINT [FK_RolesPermissions_Permissions]
GO
ALTER TABLE [dbo].[RolesPermissions]  WITH CHECK ADD  CONSTRAINT [FK_RolesPermissions_Roles] FOREIGN KEY([idRole])
REFERENCES [dbo].[Roles] ([idRole])
GO
ALTER TABLE [dbo].[RolesPermissions] CHECK CONSTRAINT [FK_RolesPermissions_Roles]
GO
ALTER TABLE [dbo].[UsersRoles]  WITH CHECK ADD  CONSTRAINT [FK_UsersRoles_Role] FOREIGN KEY([idRole])
REFERENCES [dbo].[Roles] ([idRole])
GO
ALTER TABLE [dbo].[UsersRoles] CHECK CONSTRAINT [FK_UsersRoles_Role]
GO
ALTER TABLE [dbo].[UsersRoles]  WITH CHECK ADD  CONSTRAINT [FK_UsersRoles_Users] FOREIGN KEY([idUser])
REFERENCES [dbo].[Users] ([idUser])
GO
ALTER TABLE [dbo].[UsersRoles] CHECK CONSTRAINT [FK_UsersRoles_Users]
GO
USE [master]
GO
ALTER DATABASE [SistemaAirCenter] SET  READ_WRITE 
GO
