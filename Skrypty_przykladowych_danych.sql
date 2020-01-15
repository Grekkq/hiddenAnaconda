--Dane dla logowania (admin,admin)
SET IDENTITY_INSERT [dbo].[logowanie] ON
INSERT INTO [dbo].[logowanie] ([id_uzytkownika], [login], [hasz], [poziom_uprawnien], [czy_aktywny]) VALUES (0, N'admin', N'3282a9ae9846b0c75f0faeb65905c28910a1dbd36d672437177c8a7b61a101c1d0722908', 6, 'TRUE')
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
INSERT INTO [dbo].[pojazd] ([id_pojazdu], [nr_rejestracyjny], [nr_VIN], [model], [marka], [data_produkcji], [czy_niskopodlogowy], [czy_sprawny]) VALUES (0, N'SK12A12', N'1B3LC46K68N192898', N'Urbino12', N'Solaris', N'2000-11-29 23:59:59', 1, 1);
INSERT INTO [dbo].[pojazd] ([id_pojazdu], [nr_rejestracyjny], [nr_VIN], [model], [marka], [data_produkcji], [czy_niskopodlogowy], [czy_sprawny]) VALUES (1, N'SK13A13', N'1FAFP53202A298049', N'Urbino12', N'Solaris', N'2001-10-13 23:59:59', 1, 1)
INSERT INTO [dbo].[pojazd] ([id_pojazdu], [nr_rejestracyjny], [nr_VIN], [model], [marka], [data_produkcji], [czy_niskopodlogowy], [czy_sprawny]) VALUES (2, N'SK14A14', N'JM1BJ2217X0142704', N'Urbino18', N'Solaris', N'2002-01-09 23:59:59', 1, 1)
INSERT INTO [dbo].[pojazd] ([id_pojazdu], [nr_rejestracyjny], [nr_VIN], [model], [marka], [data_produkcji], [czy_niskopodlogowy], [czy_sprawny]) VALUES (3, N'SK15A15', N'JM3TB38A490191433', N'Urbino18', N'Solaris', N'2003-07-17 23:59:59', 1, 1)
INSERT INTO [dbo].[pojazd] ([id_pojazdu], [nr_rejestracyjny], [nr_VIN], [model], [marka], [data_produkcji], [czy_niskopodlogowy], [czy_sprawny]) VALUES (4, N'SK16A16', N'1FTNE2EW5DDA92298', N'Urbino10,5', N'Solaris', N'1997-05-28 23:59:59', 1, 1)
SET IDENTITY_INSERT [dbo].[pojazd] OFF

-- Dane dla lini
SET IDENTITY_INSERT [dbo].[linia] ON
INSERT INTO [dbo].[linia] ([id_linii], [czy_zapetla]) VALUES (710, 1)
INSERT INTO [dbo].[linia] ([id_linii], [czy_zapetla]) VALUES (617, 1)
INSERT INTO [dbo].[linia] ([id_linii], [czy_zapetla]) VALUES (4, 0)
SET IDENTITY_INSERT [dbo].[linia] OFF

-- Dane dla przystankow
SET IDENTITY_INSERT [dbo].[przystanek] ON
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [kierunek]) VALUES (1, N'Plac Piastów', N'Gliwice', N'Zabrze-Gliwice')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [kierunek]) VALUES (2, N'Plac Piastów', N'Gliwice', N'Gliwice-Zabrze')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [kierunek]) VALUES (3, N'Plac Piastów', N'Gliwice', N'Knurów-Gliwice')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [kierunek]) VALUES (4, N'Plac Piastów', N'Gliwice', N'Gliwice-Knurów')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto]) VALUES (11, N'Dworcowa', N'Gliwice')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto]) VALUES (21, N'Strzody', N'Gliwice')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [kierunek]) VALUES (31, N'Rybnicka', N'Gliwice', N'Knurów-Gliwice')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [kierunek]) VALUES (32, N'Rybnicka', N'Gliwice', N'Gliwice-Knurów')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [kierunek]) VALUES (41, N'Dąbrowskiego', N'Gliwice', N'Zabrze-Gliwice')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [kierunek]) VALUES (42, N'Dąbrowskiego', N'Gliwice', N'Gliwice-Zabrze')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [kierunek]) VALUES (51, N'Zajezdnia', N'Gliwice', N'Zabrze-Gliwice')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [kierunek]) VALUES (52, N'Zajezdnia', N'Gliwice', N'Gliwice-Zabrze')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [kierunek]) VALUES (61, N'Wojska Polskiego', N'Knurów', N'Knurów-Gliwice')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [kierunek]) VALUES (62, N'Wojska Polskiego', N'Knurów', N'Gliwice-Knurów')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [kierunek]) VALUES (71, N'Cegielnia', N'Knurów', N'Knurów-Gliwice')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [kierunek]) VALUES (72, N'Cegielnia', N'Knurów', N'Gliwice-Knurów')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [kierunek]) VALUES (81, N'Szpitalna', N'Knurów', N'Knurów-Gliwice')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [kierunek]) VALUES (82, N'Szpitalna', N'Knurów', N'Gliwice-Knurów')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [kierunek]) VALUES (91, N'Gothego', N'Zabrze', N'Zabrze-Gliwice')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [kierunek]) VALUES (92, N'Gothego', N'Zabrze', N'Gliwice-Zabrze')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [kierunek]) VALUES (101, N'Plac Kroczka', N'Zabrze', N'Zabrze-Gliwice')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [kierunek]) VALUES (102, N'Plac Kroczka', N'Zabrze', N'Gliwice-Zabrze')
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto]) VALUES (111, N'Plac Krakowski', N'Gliwice')
SET IDENTITY_INSERT [dbo].[przystanek] OFF

-- Dane dla tras
SET IDENTITY_INSERT [dbo].[trasa] ON
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (0, 710, 4, 0, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (1, 710, 11, 1, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (2, 710, 21, 2, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (3, 710, 32, 3, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (4, 710, 62, 4, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (5, 710, 72, 5, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (6, 710, 82, 6, 0)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (7, 710, 81, 0, 1)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (8, 710, 71, 1, 1)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (9, 710, 61, 2, 1)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (10, 710, 31, 3, 1)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (11, 710, 111, 4, 1)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (12, 710, 3, 5, 1)

SET IDENTITY_INSERT [dbo].[trasa] OFF

--Dane dla czasu odjazdu
SET IDENTITY_INSERT [dbo].[czas_odjazdu] ON
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (11, 0, N'7:15:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (12, 1, N'7:20:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (13, 2, N'7:25:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (14, 3, N'7:35:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (15, 4, N'7:45:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (16, 5, N'7:50:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (17, 6, N'8:02:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (21, 7, N'8:22:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (22, 8, N'8:24:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (23, 9, N'8:46:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (24, 10, N'8:59:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (25, 11, N'9:07:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (26, 12, N'9:17:00')

SET IDENTITY_INSERT [dbo].[czas_odjazdu] OFF

-- Dane dla kursu
SET IDENTITY_INSERT [dbo].[kurs] ON
INSERT INTO [dbo].[kurs] ([id_kursu], [id_linii], [id_czasu_odjazdu], [id_trasy], [ktory_kurs_danego_dnia], [rodzaj_kursu]) VALUES (0, 710, 11, 0, 0, N'roboczy')
INSERT INTO [dbo].[kurs] ([id_kursu], [id_linii], [id_czasu_odjazdu], [id_trasy], [ktory_kurs_danego_dnia], [rodzaj_kursu]) VALUES (1, 710, 21, 7, 0, N'roboczy')
INSERT INTO [dbo].[kurs] ([id_kursu], [id_linii], [id_czasu_odjazdu], [id_trasy], [ktory_kurs_danego_dnia], [rodzaj_kursu]) VALUES (2, 710, 11, 0, 0, N'wolny') -- tutaj są te same trasy to może być problem
INSERT INTO [dbo].[kurs] ([id_kursu], [id_linii], [id_czasu_odjazdu], [id_trasy], [ktory_kurs_danego_dnia], [rodzaj_kursu]) VALUES (3, 710, 21, 7, 0, N'wolny') -- tutaj są te same trasy to może być problem
SET IDENTITY_INSERT [dbo].[kurs] OFF

--Dane dla realizacji kursu
SET IDENTITY_INSERT [dbo].[realizacja_kursu] ON
INSERT INTO [dbo].[realizacja_kursu] ([id_realizacji_kursu], [id_przypisanego_kierowcy], [id_wykonujacego_kierowcy], [id_pojazdu], [id_kursu], [data_realizacji]) VALUES (0, 3, 3, 2, 0, N'2019-11-29 00:00:00')
INSERT INTO [dbo].[realizacja_kursu] ([id_realizacji_kursu], [id_przypisanego_kierowcy], [id_wykonujacego_kierowcy], [id_pojazdu], [id_kursu], [data_realizacji]) VALUES (1, 1, 2, 3, 1, N'2019-11-29 00:00:00')
SET IDENTITY_INSERT [dbo].[realizacja_kursu] OFF

-- Dane dla czasu realizacji
SET IDENTITY_INSERT [dbo].[czas_realizacji] ON
INSERT INTO [dbo].[czas_realizacji] ([id_czasu_realizacji], [faktyczny_czas_odjazdu], [id_czasu_odjazdu], [id_realizacji_kursu]) VALUES (0, N'7:15:00', 11, 0)
INSERT INTO [dbo].[czas_realizacji] ([id_czasu_realizacji], [faktyczny_czas_odjazdu], [id_czasu_odjazdu], [id_realizacji_kursu]) VALUES (1, N'7:21:00', 12, 0)
INSERT INTO [dbo].[czas_realizacji] ([id_czasu_realizacji], [faktyczny_czas_odjazdu], [id_czasu_odjazdu], [id_realizacji_kursu]) VALUES (2, N'7:25:00', 13, 0)
INSERT INTO [dbo].[czas_realizacji] ([id_czasu_realizacji], [faktyczny_czas_odjazdu], [id_czasu_odjazdu], [id_realizacji_kursu]) VALUES (3, N'7:35:00', 14, 0)
INSERT INTO [dbo].[czas_realizacji] ([id_czasu_realizacji], [faktyczny_czas_odjazdu], [id_czasu_odjazdu], [id_realizacji_kursu]) VALUES (4, N'7:45:00', 15, 0)
INSERT INTO [dbo].[czas_realizacji] ([id_czasu_realizacji], [faktyczny_czas_odjazdu], [id_czasu_odjazdu], [id_realizacji_kursu]) VALUES (5, N'7:51:00', 16, 0)
INSERT INTO [dbo].[czas_realizacji] ([id_czasu_realizacji], [faktyczny_czas_odjazdu], [id_czasu_odjazdu], [id_realizacji_kursu]) VALUES (6, N'8:02:00', 17, 0)
SET IDENTITY_INSERT [dbo].[czas_realizacji] OFF