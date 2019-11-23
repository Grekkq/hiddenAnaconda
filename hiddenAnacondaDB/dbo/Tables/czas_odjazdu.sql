﻿/*==============================================================*/
/* Table: czas_odjazdu                                          */
/*==============================================================*/
/*==============================================================*/
/* Table: czas_odjazdu                                          */
/*==============================================================*/
create table czas_odjazdu (
   id_czasu_odjazdu     int                  not null,
   id_trasy             int                  not null,
   id_linii             int                  not null,
   id_przystanku        int                  not null,
   czas_odjazdu         datetime             not null,
   constraint PK_CZAS_ODJAZDU primary key nonclustered (id_czasu_odjazdu)
)
GO
alter table czas_odjazdu
   add constraint FK_CZAS_ODJ_T2CZ_O_TRASA foreign key (id_trasy, id_linii, id_przystanku)
      references trasa (id_trasy, id_linii, id_przystanku)
GO
/*==============================================================*/
/* Index: t2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: t2cz_o_FK                                             */
/*==============================================================*/
create index t2cz_o_FK on czas_odjazdu (
id_trasy ASC,
id_linii ASC,
id_przystanku ASC
)