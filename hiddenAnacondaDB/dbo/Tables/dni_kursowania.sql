﻿/*==============================================================*/
/* Table: dni_kursowania                                        */
/*==============================================================*/
/*==============================================================*/
/* Table: dni_kursowania                                        */
/*==============================================================*/
create table dni_kursowania (
   id_dni_kursowania    int                  not null,
   od_dnia              varchar(20)          not null,
   do_dnia              varchar(20)          not null,
   rodzaj_kursu         int                  not null,
   constraint PK_DNI_KURSOWANIA primary key nonclustered (id_dni_kursowania)
)