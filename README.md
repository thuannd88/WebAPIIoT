DB:
CREATE TABLE [dbo].[Devices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](128) NULL,
	[Description] [nvarchar](128) NULL,
 CONSTRAINT [PK_Device] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Devices] ON 
GO
INSERT [dbo].[Devices] ([Id], [Name], [Description]) VALUES (1, N'ESP32', N'Living Room')
GO
INSERT [dbo].[Devices] ([Id], [Name], [Description]) VALUES (2, N'ESP8266', N'Kitchen')
GO
SET IDENTITY_INSERT [dbo].[Devices] OFF
GO
