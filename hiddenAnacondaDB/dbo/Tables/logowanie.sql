﻿/*==============================================================*/
/* Table: logowanie                                             */
/*==============================================================*/
/*==============================================================*/
/* Table: logowanie                                             */
/*==============================================================*/
/*==============================================================*/
/* Table: logowanie                                             */
/*==============================================================*/
/*==============================================================*/
/* Table: logowanie                                             */
/*==============================================================*/
/*==============================================================*/
/* Table: logowanie                                             */
/*==============================================================*/
/*==============================================================*/
/* Table: logowanie                                             */
/*==============================================================*/
/*==============================================================*/
/* Table: logowanie                                             */
/*==============================================================*/
/*==============================================================*/
/* Table: logowanie                                             */
/*==============================================================*/
/*==============================================================*/
/* Table: logowanie                                             */
/*==============================================================*/
/*==============================================================*/
/* Table: logowanie                                             */
/*==============================================================*/
/*==============================================================*/
/* Table: logowanie                                             */
/*==============================================================*/
/*==============================================================*/
/* Table: logowanie                                             */
/*==============================================================*/
create table logowanie (
   id_uzytkownika       int                  identity,
   login                varchar(20)          collate POLISH_CI_AS not null,
   hasz                 varchar(72)          not null,
   poziom_uprawnien     int                  not null,
   czy_aktywny          bit                  not null,
   constraint PK_LOGOWANIE primary key (id_uzytkownika)
)