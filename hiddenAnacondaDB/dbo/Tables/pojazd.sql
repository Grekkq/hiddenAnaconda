﻿/*==============================================================*/
/* Table: pojazd                                                */
/*==============================================================*/
/*==============================================================*/
/* Table: pojazd                                                */
/*==============================================================*/
create table pojazd (
   id_pojazdu           int                  not null,
   nr_rejestracyjny     varchar(7)           not null,
   model                varchar(20)          not null,
   marka                varchar(20)          not null,
   czy_niskopodlogowy   bit                  not null,
   czy_sprawny          bit                  not null,
   constraint PK_POJAZD primary key nonclustered (id_pojazdu)
)