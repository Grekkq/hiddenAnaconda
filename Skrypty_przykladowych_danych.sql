﻿-- Dane dla kierowcow
INSERT INTO [dbo].[kierowca] ([id_kierowcy], [imie], [nazwisko], [czy_pracuje], [PESEL]) VALUES (1, N'Ryszard', N'Dobry', 1, 88111102744)
INSERT INTO [dbo].[kierowca] ([id_kierowcy], [imie], [nazwisko], [czy_pracuje], [PESEL]) VALUES (2, N'Tomasz', N'Lepszy', 1, 87101208222)
INSERT INTO [dbo].[kierowca] ([id_kierowcy], [imie], [nazwisko], [czy_pracuje], [PESEL]) VALUES (3, N'Wieslaw', N'Najlepszy', 1, 77030113562)
INSERT INTO [dbo].[kierowca] ([id_kierowcy], [imie], [nazwisko], [czy_pracuje], [PESEL]) VALUES (4, N'Artur', N'Wrak', 1, 90010125732)
INSERT INTO [dbo].[kierowca] ([id_kierowcy], [imie], [nazwisko], [czy_pracuje], [PESEL]) VALUES (5, N'Robert', N'Nowak', 1, 76121288126)
-- Dane dla pojazdu
INSERT INTO [dbo].[pojazd] ([id_pojazdu], [nr_rejestracyjny], [model], [marka], [czy_niskopodlogowy], [czy_sprawny]) VALUES (110, N'SK12A12', N'Urbino12', N'Solaris', 1, 1)
INSERT INTO [dbo].[pojazd] ([id_pojazdu], [nr_rejestracyjny], [model], [marka], [czy_niskopodlogowy], [czy_sprawny]) VALUES (111, N'SK13A13', N'Urbino12', N'Solaris', 1, 1)
INSERT INTO [dbo].[pojazd] ([id_pojazdu], [nr_rejestracyjny], [model], [marka], [czy_niskopodlogowy], [czy_sprawny]) VALUES (112, N'SK14A14', N'Urbino18', N'Solaris', 1, 1)
INSERT INTO [dbo].[pojazd] ([id_pojazdu], [nr_rejestracyjny], [model], [marka], [czy_niskopodlogowy], [czy_sprawny]) VALUES (113, N'SK15A15', N'Urbino18', N'Solaris', 1, 1)
INSERT INTO [dbo].[pojazd] ([id_pojazdu], [nr_rejestracyjny], [model], [marka], [czy_niskopodlogowy], [czy_sprawny]) VALUES (114, N'SK16A16', N'Urbino10,5', N'Solaris', 1, 1)
-- Dane dla lini
INSERT INTO [dbo].[linia] ([id_linii], [czy_zapetla]) VALUES (101, 1)
INSERT INTO [dbo].[linia] ([id_linii], [czy_zapetla]) VALUES (164, 1)
INSERT INTO [dbo].[linia] ([id_linii], [czy_zapetla]) VALUES (551, 0)
-- Dane dla przystankow
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1000, N'Aleja Korfantego', N'Katowice', 0)
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1001, N'Strefa Kultury', N'Katowice', 0)
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1002, N'Porcelanowa', N'Katowice', 0)
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1003, N'Browar', N'Tychy', 0)
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1004, N'Skalka', N'Tychy', 0)
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1005, N'Niepodleglosci', N'Tychy', 0)
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1006, N'Tecza', N'Tychy', 0)
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1007, N'Plac Piastow', N'Gliwice', 0)
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1008, N'Komag', N'Gliwice', 0)
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1009, N'Plac 750-lecia', N'Mikolów', 0)
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1010, N'Dworzec PKP', N'Mikolów', 0)
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1011, N'Dworzec PKP', N'Tychy', 0)
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1012, N'Hotelowiec', N'Tychy', 1)
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1013, N'Krakowska', N'Mikolów', 1)
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1014, N'Chlodnicza', N'Tychy', 1)
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1115, N'Dworzec PKP', N'Gliwice', 1)