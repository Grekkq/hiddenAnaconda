﻿/*==============================================================*/
/* Table: kierowca                                              */
/*==============================================================*/
/*==============================================================*/
/* Table: kierowca                                              */
/*==============================================================*/
/*==============================================================*/
/* Table: kierowca                                              */
/*==============================================================*/
/*==============================================================*/
/* Table: kierowca                                              */
/*==============================================================*/
/*==============================================================*/
/* Table: kierowca                                              */
/*==============================================================*/
/*==============================================================*/
/* Table: kierowca                                              */
/*==============================================================*/
/*==============================================================*/
/* Table: kierowca                                              */
/*==============================================================*/
/*==============================================================*/
/* Table: kierowca                                              */
/*==============================================================*/
/*==============================================================*/
/* Table: kierowca                                              */
/*==============================================================*/
/*==============================================================*/
/* Table: kierowca                                              */
/*==============================================================*/
/*==============================================================*/
/* Table: kierowca                                              */
/*==============================================================*/
/*==============================================================*/
/* Table: kierowca                                              */
/*==============================================================*/
/*==============================================================*/
/* Table: kierowca                                              */
/*==============================================================*/
/*==============================================================*/
/* Table: kierowca                                              */
/*==============================================================*/
/*==============================================================*/
/* Table: kierowca                                              */
/*==============================================================*/
create table kierowca (
   id_kierowcy          int                  identity,
   imie                 varchar(30)          collate POLISH_CI_AS not null,
   nazwisko             varchar(30)          collate POLISH_CI_AS not null,
   czy_pracuje          bit                  not null,
   PESEL                bigint               not null,
   constraint PK_KIEROWCA primary key nonclustered (id_kierowcy)
)