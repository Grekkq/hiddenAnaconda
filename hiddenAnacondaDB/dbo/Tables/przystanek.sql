/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
create table przystanek (
   id_przystanku        int                  not null,
   nazwa                varchar(30)          not null,
   lokalizacja          varchar(30)          not null,
   czy_jednokierunkowy  bit                  not null,
   constraint PK_PRZYSTANEK primary key nonclustered (id_przystanku)
)