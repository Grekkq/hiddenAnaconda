--Dane dla logowania (admin,admin)
SET IDENTITY_INSERT [dbo].[logowanie] ON
INSERT INTO [dbo].[logowanie] ([id_uzytkownika], [login], [hasz], [poziom_uprawnien], [czy_aktywny]) VALUES (0, N'admin', N'3282a9ae9846b0c75f0faeb65905c28910a1dbd36d672437177c8a7b61a101c1d0722908', 1, 'TRUE')
SET IDENTITY_INSERT [dbo].[logowanie] OFF

--Dane dla dni kursowania
SET IDENTITY_INSERT [dbo].[dni_kursowania] ON
INSERT INTO [dbo].[dni_kursowania] ([id_dni_kursowania], [od_dnia], [do_dnia], [rodzaj_kursu]) VALUES (1, N'2020-11-25 00:00:00', N'2020-11-29 23:59:59', N'roboczy')
INSERT INTO [dbo].[dni_kursowania] ([id_dni_kursowania], [od_dnia], [do_dnia], [rodzaj_kursu]) VALUES (2, N'2020-11-30 00:00:00', N'2020-12-01 23:59:59', N'świąteczny')
SET IDENTITY_INSERT [dbo].[dni_kursowania] OFF

-- Dane dla kierowcow
SET IDENTITY_INSERT [dbo].[kierowca] ON
INSERT INTO [dbo].[kierowca] ([id_kierowcy], [imie], [nazwisko], [czy_pracuje], [PESEL]) VALUES (1, N'Ryszard', N'Dobry', 1, 88111102744)
INSERT INTO [dbo].[kierowca] ([id_kierowcy], [imie], [nazwisko], [czy_pracuje], [PESEL]) VALUES (2, N'Tomasz', N'Lepszy', 1, 87101208222)
INSERT INTO [dbo].[kierowca] ([id_kierowcy], [imie], [nazwisko], [czy_pracuje], [PESEL]) VALUES (3, N'Wieslaw', N'Najlepszy', 1, 77030113562)
INSERT INTO [dbo].[kierowca] ([id_kierowcy], [imie], [nazwisko], [czy_pracuje], [PESEL]) VALUES (4, N'Artur', N'Wrak', 1, 90010125732)
INSERT INTO [dbo].[kierowca] ([id_kierowcy], [imie], [nazwisko], [czy_pracuje], [PESEL]) VALUES (5, N'Robert', N'Nowak', 1, 76121288126)
SET IDENTITY_INSERT [dbo].[kierowca] OFF

-- Dane dla pojazdu
SET IDENTITY_INSERT [dbo].[pojazd] ON
INSERT INTO [dbo].[pojazd] ([id_pojazdu], [nr_rejestracyjny], [model], [marka], [czy_niskopodlogowy], [czy_sprawny]) VALUES (0, N'SK12A12', N'Urbino12', N'Solaris', 1, 1)
INSERT INTO [dbo].[pojazd] ([id_pojazdu], [nr_rejestracyjny], [model], [marka], [czy_niskopodlogowy], [czy_sprawny]) VALUES (1, N'SK13A13', N'Urbino12', N'Solaris', 1, 1)
INSERT INTO [dbo].[pojazd] ([id_pojazdu], [nr_rejestracyjny], [model], [marka], [czy_niskopodlogowy], [czy_sprawny]) VALUES (2, N'SK14A14', N'Urbino18', N'Solaris', 1, 1)
INSERT INTO [dbo].[pojazd] ([id_pojazdu], [nr_rejestracyjny], [model], [marka], [czy_niskopodlogowy], [czy_sprawny]) VALUES (3, N'SK15A15', N'Urbino18', N'Solaris', 1, 1)
INSERT INTO [dbo].[pojazd] ([id_pojazdu], [nr_rejestracyjny], [model], [marka], [czy_niskopodlogowy], [czy_sprawny]) VALUES (4, N'SK16A16', N'Urbino10,5', N'Solaris', 1, 1)
SET IDENTITY_INSERT [dbo].[pojazd] OFF

-- Dane dla lini
SET IDENTITY_INSERT [dbo].[linia] ON
INSERT INTO [dbo].[linia] ([id_linii], [czy_zapetla]) VALUES (101, 1)
INSERT INTO [dbo].[linia] ([id_linii], [czy_zapetla]) VALUES (164, 1)
INSERT INTO [dbo].[linia] ([id_linii], [czy_zapetla]) VALUES (551, 0)
SET IDENTITY_INSERT [dbo].[linia] OFF

-- Dane dla przystankow
SET IDENTITY_INSERT [dbo].[przystanek] ON
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
SET IDENTITY_INSERT [dbo].[przystanek] OFF

-- Dane dla tras
SET IDENTITY_INSERT [dbo].[trasa] ON
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (0, 101, 1000, 1, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (1, 101, 1001, 2, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (2, 101, 1002, 3, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (3, 101, 1003, 4, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (4, 101, 1004, 5, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (5, 101, 1005, 6, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (6, 164, 1008, 1, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (7, 164, 1009, 2, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (8, 164, 1010, 3, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (9, 164, 1011, 4, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (10, 164, 1012, 5, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (11, 164, 1013, 6, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (12, 164, 1014, 7, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (13, 164, 1014, 1, 1)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (14, 164, 1013, 2, 1)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (15, 164, 1012, 3, 1)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (16, 164, 1011, 4, 1)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (17, 164, 1010, 5, 1)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (18, 164, 1009, 6, 1)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (19, 164, 1008, 7, 1)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (20, 551, 1115, 1, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (21, 551, 1011, 2, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (22, 551, 1013, 3, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (23, 551, 1000, 4, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (24, 551, 1010, 5, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (25, 101, 1005, 1, 1)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (26, 101, 1004, 2, 1)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (27, 101, 1003, 3, 1)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (28, 101, 1002, 4, 1)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (29, 101, 1001, 5, 1)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (30, 101, 1000, 6, 1)
SET IDENTITY_INSERT [dbo].[trasa] OFF

--Dane dla czasu odjazdu
SET IDENTITY_INSERT [dbo].[czas_odjazdu] ON
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (0, 0, N'7:15:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (1, 1, N'7:20:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (2, 2, N'7:25:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (3, 3, N'7:35:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (4, 4, N'7:45:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (5, 5, N'7:50:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (6, 6, N'11:22:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (7, 7, N'11:23:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (8, 8, N'11:24:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (9, 9, N'11:46:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (10, 10, N'12:16:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (11, 11, N'13:17:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (12, 12, N'13:21:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (13, 13, N'13:22:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (14, 14, N'13:26:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (15, 15, N'14:27:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (16, 16, N'14:57:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (17, 17, N'15:19:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (18, 18, N'15:20:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (19, 19, N'15:21:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (20, 20, N'13:33:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (21, 21, N'13:45:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (22, 22, N'14:00:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (23, 23, N'14:12:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (24, 24, N'14:22:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (25, 25, N'8:15:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (26, 26, N'8:20:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (27, 27, N'8:25:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (28, 28, N'8:35:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (29, 29, N'8:45:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (30, 30, N'8:50:00')
SET IDENTITY_INSERT [dbo].[czas_odjazdu] OFF

-- Dane dla kursu
SET IDENTITY_INSERT [dbo].[kurs] ON
INSERT INTO [dbo].[kurs] ([id_kursu], [id_linii], [id_czasu_odjazdu], [id_trasy], [ktory_kurs_danego_dnia], [rodzaj_kursu]) VALUES (0, 101, 0, 0, 0, N'roboczy')
INSERT INTO [dbo].[kurs] ([id_kursu], [id_linii], [id_czasu_odjazdu], [id_trasy], [ktory_kurs_danego_dnia], [rodzaj_kursu]) VALUES (1, 164, 6, 6, 0, N'roboczy')
INSERT INTO [dbo].[kurs] ([id_kursu], [id_linii], [id_czasu_odjazdu], [id_trasy], [ktory_kurs_danego_dnia], [rodzaj_kursu]) VALUES (2, 164, 13, 13, 1, N'roboczy')
INSERT INTO [dbo].[kurs] ([id_kursu], [id_linii], [id_czasu_odjazdu], [id_trasy], [ktory_kurs_danego_dnia], [rodzaj_kursu]) VALUES (3, 101, 25, 25, 1, N'roboczy')
INSERT INTO [dbo].[kurs] ([id_kursu], [id_linii], [id_czasu_odjazdu], [id_trasy], [ktory_kurs_danego_dnia], [rodzaj_kursu]) VALUES (4, 551, 20, 20, 0, N'wolny')
SET IDENTITY_INSERT [dbo].[kurs] OFF

--Dane dla realizacji kursu
SET IDENTITY_INSERT [dbo].[realizacja_kursu] ON
INSERT INTO [dbo].[realizacja_kursu] ([id_realizacji_kursu], [id_przypisanego_kierowcy], [id_wykonujacego_kierowcy], [id_pojazdu], [id_kursu], [data_realizacji]) VALUES (0, 3, 3, 2, 0, N'2019-11-29 00:00:00')
INSERT INTO [dbo].[realizacja_kursu] ([id_realizacji_kursu], [id_przypisanego_kierowcy], [id_wykonujacego_kierowcy], [id_pojazdu], [id_kursu], [data_realizacji]) VALUES (1, 1, 2, 3, 4, N'2019-11-30 00:00:00')
SET IDENTITY_INSERT [dbo].[realizacja_kursu] OFF

-- Dane dla czasu realizacji
SET IDENTITY_INSERT [dbo].[czas_realizacji] ON
INSERT INTO [dbo].[czas_realizacji] ([id_czasu_realizacji], [faktyczny_czas_odjazdu], [id_czasu_odjazdu], [id_realizacji_kursu]) VALUES (0, N'7:15:00', 0, 0)
INSERT INTO [dbo].[czas_realizacji] ([id_czasu_realizacji], [faktyczny_czas_odjazdu], [id_czasu_odjazdu], [id_realizacji_kursu]) VALUES (1, N'7:21:00', 1, 0)
INSERT INTO [dbo].[czas_realizacji] ([id_czasu_realizacji], [faktyczny_czas_odjazdu], [id_czasu_odjazdu], [id_realizacji_kursu]) VALUES (2, N'7:25:00', 2, 0)
INSERT INTO [dbo].[czas_realizacji] ([id_czasu_realizacji], [faktyczny_czas_odjazdu], [id_czasu_odjazdu], [id_realizacji_kursu]) VALUES (3, N'7:35:00', 3, 0)
INSERT INTO [dbo].[czas_realizacji] ([id_czasu_realizacji], [faktyczny_czas_odjazdu], [id_czasu_odjazdu], [id_realizacji_kursu]) VALUES (4, N'7:45:00', 4, 0)
INSERT INTO [dbo].[czas_realizacji] ([id_czasu_realizacji], [faktyczny_czas_odjazdu], [id_czasu_odjazdu], [id_realizacji_kursu]) VALUES (5, N'7:51:00', 5, 0)
SET IDENTITY_INSERT [dbo].[czas_realizacji] OFF