﻿/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
create table przystanek (
   id_przystanku        int                  identity,
   nazwa                nvarchar(30)          collate POLISH_CI_AS not null,
   miasto               nvarchar(30)          collate POLISH_CI_AS not null,
   kierunek  nvarchar(60)                  collate POLISH_CI_AS null,
   constraint PK_PRZYSTANEK primary key nonclustered (id_przystanku)
)