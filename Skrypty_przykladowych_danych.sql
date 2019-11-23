-- Dane dla kierowcow
INSERT INTO [dbo].[kierowca] ([id_kierowcy], [imie], [nazwisko], [czy_pracuje], [PESEL]) VALUES (0, N'Jan', N'asd', 1, 12345678985)
INSERT INTO [dbo].[kierowca] ([id_kierowcy], [imie], [nazwisko], [czy_pracuje], [PESEL]) VALUES (1, N'asd', N'asd', 0, 52466584756)
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
