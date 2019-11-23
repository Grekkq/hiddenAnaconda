﻿/*==============================================================*/
/* Table: trasa                                                 */
/*==============================================================*/
/*==============================================================*/
/* Table: trasa                                                 */
/*==============================================================*/
create table trasa (
   id_trasy             int                  not null,
   id_linii             int                  not null,
   id_przystanku        int                  not null,
   kolejnosc            int                  not null,
   constraint PK_TRASA primary key nonclustered (id_trasy, id_linii, id_przystanku)
)
GO
alter table trasa
   add constraint FK_TRASA_P2T_PRZYSTAN foreign key (id_przystanku)
      references przystanek (id_przystanku)
GO
alter table trasa
   add constraint FK_TRASA_T2L_LINIA foreign key (id_linii)
      references linia (id_linii)
GO
/*==============================================================*/
/* Index: p2t_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: p2t_FK                                                */
/*==============================================================*/
create index p2t_FK on trasa (
id_przystanku ASC
)
GO
/*==============================================================*/
/* Index: t2l_FK                                                */
/*==============================================================*/
/*==============================================================*/
/* Index: t2l_FK                                                */
/*==============================================================*/
create index t2l_FK on trasa (
id_linii ASC
)