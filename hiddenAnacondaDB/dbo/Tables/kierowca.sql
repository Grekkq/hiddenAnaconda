﻿/*==============================================================*/
/* Table: kierowca                                              */
/*==============================================================*/
/*==============================================================*/
/* Table: kierowca                                              */
/*==============================================================*/
create table kierowca (
   id_kierowcy          int                  not null,
   imie                 varchar(30)          not null,
   nazwisko             varchar(30)          not null,
   czy_pracuje          bit                  not null,
   PESEL                bigint               not null,
   constraint PK_KIEROWCA primary key nonclustered (id_kierowcy)
)