SET IDENTITY_INSERT [dbo].[SoThu] ON
INSERT INTO [dbo].[SoThu] ([Id], [name], [sothuthang], [kehoach]) VALUES (1, N'Đội 1     ', CAST(100000 AS Decimal(18, 0)), CAST(200000 AS Decimal(18, 0)))
INSERT INTO [dbo].[SoThu] ([Id], [name], [sothuthang], [kehoach]) VALUES (2, N'Đội 2     ', CAST(300000 AS Decimal(18, 0)), CAST(350000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[SoThu] OFF
