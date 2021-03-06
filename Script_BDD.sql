USE [tableaudebord]
GO
/****** Object:  Table [dbo].[Connexion]    Script Date: 06/02/2017 11:04:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Connexion](
	[Login] [nvarchar](50) NOT NULL,
	[MotDePasse] [nvarchar](50) NOT NULL,
	[libelle] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Connexion2] PRIMARY KEY CLUSTERED 
(
	[Login] ASC,
	[MotDePasse] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Connexion] ([Login], [MotDePasse], [libelle]) VALUES (N'admin', N'root', N' admin    ')
/****** Object:  Table [dbo].[dureeMoy]    Script Date: 06/02/2017 11:04:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dureeMoy](
	[mois] [int] NOT NULL,
	[annee] [int] NOT NULL,
	[dureeMoy] [int] NOT NULL,
 CONSTRAINT [PK_dureeMoy] PRIMARY KEY CLUSTERED 
(
	[mois] ASC,
	[annee] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[dureeMoy] ([mois], [annee], [dureeMoy]) VALUES (1, 2016, 72)
INSERT [dbo].[dureeMoy] ([mois], [annee], [dureeMoy]) VALUES (2, 2016, 48)
INSERT [dbo].[dureeMoy] ([mois], [annee], [dureeMoy]) VALUES (2, 2017, 55)
INSERT [dbo].[dureeMoy] ([mois], [annee], [dureeMoy]) VALUES (3, 2015, 64)
INSERT [dbo].[dureeMoy] ([mois], [annee], [dureeMoy]) VALUES (3, 2016, 12)
INSERT [dbo].[dureeMoy] ([mois], [annee], [dureeMoy]) VALUES (4, 2016, 10)
INSERT [dbo].[dureeMoy] ([mois], [annee], [dureeMoy]) VALUES (5, 2016, 18)
INSERT [dbo].[dureeMoy] ([mois], [annee], [dureeMoy]) VALUES (6, 2016, 22)
INSERT [dbo].[dureeMoy] ([mois], [annee], [dureeMoy]) VALUES (7, 2016, 50)
INSERT [dbo].[dureeMoy] ([mois], [annee], [dureeMoy]) VALUES (8, 2016, 78)
INSERT [dbo].[dureeMoy] ([mois], [annee], [dureeMoy]) VALUES (9, 2016, 64)
INSERT [dbo].[dureeMoy] ([mois], [annee], [dureeMoy]) VALUES (10, 2016, 90)
INSERT [dbo].[dureeMoy] ([mois], [annee], [dureeMoy]) VALUES (11, 2016, 37)
INSERT [dbo].[dureeMoy] ([mois], [annee], [dureeMoy]) VALUES (12, 2016, 77)
/****** Object:  Table [dbo].[CoutTotal]    Script Date: 06/02/2017 11:04:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CoutTotal](
	[Mois] [int] NOT NULL,
	[Annee] [int] NOT NULL,
	[prixTotal] [int] NOT NULL,
 CONSTRAINT [PK_CoutTotal] PRIMARY KEY CLUSTERED 
(
	[Mois] ASC,
	[Annee] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CoutTotal] ([Mois], [Annee], [prixTotal]) VALUES (1, 2016, 15)
INSERT [dbo].[CoutTotal] ([Mois], [Annee], [prixTotal]) VALUES (2, 2017, 743)
INSERT [dbo].[CoutTotal] ([Mois], [Annee], [prixTotal]) VALUES (4, 2015, 400)
INSERT [dbo].[CoutTotal] ([Mois], [Annee], [prixTotal]) VALUES (5, 2016, 89)
INSERT [dbo].[CoutTotal] ([Mois], [Annee], [prixTotal]) VALUES (9, 2016, 230)
INSERT [dbo].[CoutTotal] ([Mois], [Annee], [prixTotal]) VALUES (12, 2016, 850)
/****** Object:  Table [dbo].[Service]    Script Date: 06/02/2017 11:04:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Service](
	[id] [int] NOT NULL,
	[libelle] [varchar](255) NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Service] ([id], [libelle]) VALUES (1, N'Pediatrie')
INSERT [dbo].[Service] ([id], [libelle]) VALUES (2, N'Chirurgie')
INSERT [dbo].[Service] ([id], [libelle]) VALUES (3, N'Cardiologie')
INSERT [dbo].[Service] ([id], [libelle]) VALUES (4, N'Néphrologie')
INSERT [dbo].[Service] ([id], [libelle]) VALUES (5, N'Neurologie')
/****** Object:  Table [dbo].[NbeLitsTotal]    Script Date: 06/02/2017 11:04:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NbeLitsTotal](
	[totalLits] [int] NOT NULL,
	[idService] [int] NULL,
 CONSTRAINT [PK_NbeLitsTotal] PRIMARY KEY CLUSTERED 
(
	[totalLits] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NbeLitsTotal] ([totalLits], [idService]) VALUES (100, NULL)
/****** Object:  Table [dbo].[Occupation]    Script Date: 06/02/2017 11:04:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Occupation](
	[Mois] [int] NOT NULL,
	[Annee] [int] NOT NULL,
	[nbLitsOccup] [int] NOT NULL,
	[idService] [int] NULL,
 CONSTRAINT [PK_Occupation2] PRIMARY KEY CLUSTERED 
(
	[Mois] ASC,
	[Annee] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Occupation] ([Mois], [Annee], [nbLitsOccup], [idService]) VALUES (1, 2016, 50, NULL)
INSERT [dbo].[Occupation] ([Mois], [Annee], [nbLitsOccup], [idService]) VALUES (1, 2017, 50, NULL)
INSERT [dbo].[Occupation] ([Mois], [Annee], [nbLitsOccup], [idService]) VALUES (2, 2016, 80, NULL)
INSERT [dbo].[Occupation] ([Mois], [Annee], [nbLitsOccup], [idService]) VALUES (3, 2016, 30, NULL)
INSERT [dbo].[Occupation] ([Mois], [Annee], [nbLitsOccup], [idService]) VALUES (4, 2016, 10, NULL)
INSERT [dbo].[Occupation] ([Mois], [Annee], [nbLitsOccup], [idService]) VALUES (5, 2016, 48, NULL)
INSERT [dbo].[Occupation] ([Mois], [Annee], [nbLitsOccup], [idService]) VALUES (6, 2016, 11, NULL)
INSERT [dbo].[Occupation] ([Mois], [Annee], [nbLitsOccup], [idService]) VALUES (7, 2016, 23, NULL)
INSERT [dbo].[Occupation] ([Mois], [Annee], [nbLitsOccup], [idService]) VALUES (8, 2016, 99, NULL)
INSERT [dbo].[Occupation] ([Mois], [Annee], [nbLitsOccup], [idService]) VALUES (9, 2016, 71, NULL)
INSERT [dbo].[Occupation] ([Mois], [Annee], [nbLitsOccup], [idService]) VALUES (10, 2016, 87, NULL)
INSERT [dbo].[Occupation] ([Mois], [Annee], [nbLitsOccup], [idService]) VALUES (11, 2016, 19, NULL)
INSERT [dbo].[Occupation] ([Mois], [Annee], [nbLitsOccup], [idService]) VALUES (12, 2015, 48, NULL)
INSERT [dbo].[Occupation] ([Mois], [Annee], [nbLitsOccup], [idService]) VALUES (12, 2016, 45, NULL)
/****** Object:  ForeignKey [FK_NbeLitsTotal_Service]    Script Date: 06/02/2017 11:04:01 ******/
ALTER TABLE [dbo].[NbeLitsTotal]  WITH CHECK ADD  CONSTRAINT [FK_NbeLitsTotal_Service] FOREIGN KEY([idService])
REFERENCES [dbo].[Service] ([id])
GO
ALTER TABLE [dbo].[NbeLitsTotal] CHECK CONSTRAINT [FK_NbeLitsTotal_Service]
GO
/****** Object:  ForeignKey [FK_Occupation_Service]    Script Date: 06/02/2017 11:04:01 ******/
ALTER TABLE [dbo].[Occupation]  WITH CHECK ADD  CONSTRAINT [FK_Occupation_Service] FOREIGN KEY([idService])
REFERENCES [dbo].[Service] ([id])
GO
ALTER TABLE [dbo].[Occupation] CHECK CONSTRAINT [FK_Occupation_Service]
GO
