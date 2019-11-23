﻿/*==============================================================*/
/* Table: realizacja_kursu                                      */
/*==============================================================*/
/*==============================================================*/
/* Table: realizacja_kursu                                      */
/*==============================================================*/
create table realizacja_kursu (
   id_realizacji_kursu  int                  not null,
   id_przypisanego_kierowcy int                  not null,
   id_wykonujacego_kierowcy int                  null,
   id_pojazdu           int                  not null,
   id_kursu             int                  not null,
   data_realizacji      datetime             not null,
   constraint PK_REALIZACJA_KURSU primary key nonclustered (id_realizacji_kursu)
)
GO
alter table realizacja_kursu
   add constraint FK_REALIZAC_RELATIONS_POJAZD foreign key (id_pojazdu)
      references pojazd (id_pojazdu)
GO
alter table realizacja_kursu
   add constraint FK_REALIZAC_K2RK_KURS foreign key (id_kursu)
      references kurs (id_kursu)
GO
alter table realizacja_kursu
   add constraint FK_REALIZAC_PK2RK_KIEROWCA foreign key (id_przypisanego_kierowcy)
      references kierowca (id_kierowcy)
GO
alter table realizacja_kursu
   add constraint FK_REALIZAC_WK2RK_KIEROWCA foreign key (id_wykonujacego_kierowcy)
      references kierowca (id_kierowcy)
GO
/*==============================================================*/
/* Index: pk2rk_FK                                              */
/*==============================================================*/
/*==============================================================*/
/* Index: pk2rk_FK                                              */
/*==============================================================*/
create index pk2rk_FK on realizacja_kursu (
id_przypisanego_kierowcy ASC
)
GO
/*==============================================================*/
/* Index: wk2rk_FK                                              */
/*==============================================================*/
/*==============================================================*/
/* Index: wk2rk_FK                                              */
/*==============================================================*/
create index wk2rk_FK on realizacja_kursu (
id_wykonujacego_kierowcy ASC
)
GO
/*==============================================================*/
/* Index: Relationship_13_FK                                    */
/*==============================================================*/
/*==============================================================*/
/* Index: Relationship_13_FK                                    */
/*==============================================================*/
create index Relationship_13_FK on realizacja_kursu (
id_pojazdu ASC
)
GO
/*==============================================================*/
/* Index: k2rk_FK                                               */
/*==============================================================*/
/*==============================================================*/
/* Index: k2rk_FK                                               */
/*==============================================================*/
create index k2rk_FK on realizacja_kursu (
id_kursu ASC
)