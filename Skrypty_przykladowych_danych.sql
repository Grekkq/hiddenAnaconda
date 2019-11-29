﻿--Dane dla dni kursowania
INSERT INTO [dbo].[dni_kursowania] ([id_dni_kursowania], [od_dnia], [do_dnia], [rodzaj_kursu]) VALUES (1111, N'2020-11-25 00:00:00', N'2020-11-29 00:00:00', 1)
INSERT INTO [dbo].[dni_kursowania] ([id_dni_kursowania], [od_dnia], [do_dnia], [rodzaj_kursu]) VALUES (2222, N'2020-11-30 00:00:00', N'2020-12-01 00:00:00', 2)
-- Dane dla kierowcow
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
-- Dane dla tras
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (12, 101, 1000, 1)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (12, 101, 1001, 2)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (12, 101, 1002, 3)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (12, 101, 1003, 4)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (12, 101, 1004, 5)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (12, 101, 1005, 6)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (13, 164, 1008, 1)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (13, 164, 1009, 2)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (13, 164, 1010, 3)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (13, 164, 1011, 4)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (13, 164, 1012, 5)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (13, 164, 1013, 6)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (13, 164, 1014, 7)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (14, 164, 1014, 1)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (14, 164, 1013, 2)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (14, 164, 1012, 3)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (14, 164, 1011, 4)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (14, 164, 1010, 5)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (14, 164, 1009, 6)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (14, 164, 1008, 7)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (15, 551, 1115, 1)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (15, 551, 1011, 2)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (15, 551, 1013, 3)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (15, 551, 1000, 4)
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc]) VALUES (15, 551, 1010, 5)
--Dane dla czasu odjazdu
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (789, 12, 101, 1000, N'21:12:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (790, 12, 101, 1001, N'21:13:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (791, 12, 101, 1002, N'21:14:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (792, 12, 101, 1003, N'21:15:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (793, 12, 101, 1004, N'21:16:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (794, 12, 101, 1005, N'21:17:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (889, 13, 164, 1008, N'11:22:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (890, 13, 164, 1009, N'11:23:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (891, 13, 164, 1010, N'11:24:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (892, 13, 164, 1011, N'11:46:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (893, 13, 164, 1012, N'12:16:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (894, 13, 164, 1013, N'13:17:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (895, 13, 164, 1014, N'13:21:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (689, 14, 164, 1014, N'13:22:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (690, 14, 164, 1013, N'13:26:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (691, 14, 164, 1012, N'14:27:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (692, 14, 164, 1011, N'14:57:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (693, 14, 164, 1010, N'15:19:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (694, 14, 164, 1009, N'15:20:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (695, 14, 164, 1008, N'15:21:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (389, 15, 551, 1115, N'13:33:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (390, 15, 551, 1011, N'13:45:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (391, 15, 551, 1013, N'14:00:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (392, 15, 551, 1000, N'14:12:00')
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [id_linii], [id_przystanku], [czas_odjazdu]) VALUES (393, 15, 551, 1010, N'14:22:00')
-- Dane dla kursu
INSERT INTO [dbo].[kurs] ([id_kursu], [id_linii], [id_dni_kursowania], [id_czasu_odjazdu], [kolejnosc]) VALUES (156, 101, 1111, 789, 1)
INSERT INTO [dbo].[kurs] ([id_kursu], [id_linii], [id_dni_kursowania], [id_czasu_odjazdu], [kolejnosc]) VALUES (157, 164, 1111, 889, 2)
INSERT INTO [dbo].[kurs] ([id_kursu], [id_linii], [id_dni_kursowania], [id_czasu_odjazdu], [kolejnosc]) VALUES (158, 164, 1111, 689, 3)
INSERT INTO [dbo].[kurs] ([id_kursu], [id_linii], [id_dni_kursowania], [id_czasu_odjazdu], [kolejnosc]) VALUES (159, 551, 2222, 389, 4)
--Dane dla realizacji kursu
INSERT INTO [dbo].[realizacja_kursu] ([id_realizacji_kursu], [id_przypisanego_kierowcy], [id_wykonujacego_kierowcy], [id_pojazdu], [id_kursu], [data_realizacji]) VALUES (12000, 3, 3, 110, 156, N'2019-12-12 00:00:00')
INSERT INTO [dbo].[realizacja_kursu] ([id_realizacji_kursu], [id_przypisanego_kierowcy], [id_wykonujacego_kierowcy], [id_pojazdu], [id_kursu], [data_realizacji]) VALUES (12001, 1, 2, 111, 157, N'2019-06-05 00:00:00')
-- Dane dla czasu realizacji
INSERT INTO [dbo].[czas_realizacji] ([id_czasu_realizacji], [id_czasu_odjazdu], [id_realizacji_kursu]) VALUES (13000, 794, 12000)
INSERT INTO [dbo].[czas_realizacji] ([id_czasu_realizacji], [id_czasu_odjazdu], [id_realizacji_kursu]) VALUES (13001, 895, 12001)

