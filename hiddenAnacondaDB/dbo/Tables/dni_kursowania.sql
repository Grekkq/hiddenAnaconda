﻿/*==============================================================*/
/* Table: dni_kursowania                                        */
/*==============================================================*/
/*==============================================================*/
/* Table: dni_kursowania                                        */
/*==============================================================*/
/*==============================================================*/
/* Table: dni_kursowania                                        */
/*==============================================================*/
/*==============================================================*/
/* Table: dni_kursowania                                        */
/*==============================================================*/
/*==============================================================*/
/* Table: dni_kursowania                                        */
/*==============================================================*/
/*==============================================================*/
/* Table: dni_kursowania                                        */
/*==============================================================*/
/*==============================================================*/
/* Table: dni_kursowania                                        */
/*==============================================================*/
/*==============================================================*/
/* Table: dni_kursowania                                        */
/*==============================================================*/
/*==============================================================*/
/* Table: dni_kursowania                                        */
/*==============================================================*/
/*==============================================================*/
/* Table: dni_kursowania                                        */
/*==============================================================*/
/*==============================================================*/
/* Table: dni_kursowania                                        */
/*==============================================================*/
/*==============================================================*/
/* Table: dni_kursowania                                        */
/*==============================================================*/
/*==============================================================*/
/* Table: dni_kursowania                                        */
/*==============================================================*/
/*==============================================================*/
/* Table: dni_kursowania                                        */
/*==============================================================*/
/*==============================================================*/
/* Table: dni_kursowania                                        */
/*==============================================================*/
create table dni_kursowania (
   id_dni_kursowania    int                  identity,
   od_dnia              datetime             not null,
   do_dnia              datetime             not null,
   rodzaj_kursu         varchar(30)          collate POLISH_CI_AS not null,
   constraint PK_DNI_KURSOWANIA primary key nonclustered (id_dni_kursowania)
)