﻿/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
/*==============================================================*/
/* Table: kurs                                                  */
/*==============================================================*/
create table kurs (
   id_kursu             int                  identity,
   id_linii             int                  not null,
   id_czasu_odjazdu     int                  not null,
   id_trasy             int                  not null,
   ktory_kurs_danego_dnia int                  not null,
   rodzaj_kursu         nvarchar(30)         collate POLISH_CI_AS not null,
   constraint PK_KURS primary key nonclustered (id_kursu)
)

GO
alter table kurs
   add constraint FK_KURS_K2CZ_O_CZAS_ODJ foreign key (id_czasu_odjazdu)
      references czas_odjazdu (id_czasu_odjazdu)
GO
alter table kurs
   add constraint FK_KURS_L2K_LINIA foreign key (id_linii)
      references linia (id_linii)
GO
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
create index l2k_FK on kurs (
id_linii ASC
)
GO
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
create index k2cz_o_FK on kurs (
id_czasu_odjazdu ASC
)
GO
/*==============================================================*/
/* Index: d_k2k_FK                                              */
/*==============================================================*/
/*==============================================================*/
/* Index: d_k2k_FK                                              */
/*==============================================================*/
/*==============================================================*/
/* Index: d_k2k_FK                                              */
/*==============================================================*/
/*==============================================================*/
/* Index: d_k2k_FK                                              */
/*==============================================================*/
GO
alter table kurs
   add constraint FK_KURS_REFERENCE_TRASA foreign key (id_trasy)
      references trasa (id_trasy)