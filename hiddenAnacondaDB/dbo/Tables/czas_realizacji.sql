﻿/*==============================================================*/
/* Table: czas_realizacji                                       */
/*==============================================================*/
/*==============================================================*/
/* Table: czas_realizacji                                       */
/*==============================================================*/
create table czas_realizacji (
   id_czasu_realizacji  int                  not null,
   id_czasu_odjazdu     int                  not null,
   id_realizacji_kursu  int                  not null,
   constraint PK_CZAS_REALIZACJI primary key nonclustered (id_czasu_realizacji)
)
GO
alter table czas_realizacji
   add constraint FK_CZAS_REA_CZ_O2CZ_R_CZAS_ODJ foreign key (id_czasu_odjazdu)
      references czas_odjazdu (id_czasu_odjazdu)
GO
alter table czas_realizacji
   add constraint FK_CZAS_REA_R_K2CZ_R_REALIZAC foreign key (id_realizacji_kursu)
      references realizacja_kursu (id_realizacji_kursu)
GO
/*==============================================================*/
/* Index: cz_o2cz_r_FK                                          */
/*==============================================================*/
/*==============================================================*/
/* Index: cz_o2cz_r_FK                                          */
/*==============================================================*/
create index cz_o2cz_r_FK on czas_realizacji (
id_czasu_odjazdu ASC
)
GO
/*==============================================================*/
/* Index: r_k2cz_r_FK                                           */
/*==============================================================*/
/*==============================================================*/
/* Index: r_k2cz_r_FK                                           */
/*==============================================================*/
create index r_k2cz_r_FK on czas_realizacji (
id_realizacji_kursu ASC
)