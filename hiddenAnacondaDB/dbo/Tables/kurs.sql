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
create table kurs (
   id_kursu             int                  not null,
   id_linii             int                  not null,
   id_dni_kursowania    int                  not null,
   id_czasu_odjazdu     int                  not null,
   kolejnosc            int                  not null,
   constraint PK_KURS primary key nonclustered (id_kursu)
)
GO
alter table kurs
   add constraint FK_KURS_D_K2K_DNI_KURS foreign key (id_dni_kursowania)
      references dni_kursowania (id_dni_kursowania)
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
create index d_k2k_FK on kurs (
id_dni_kursowania ASC
)