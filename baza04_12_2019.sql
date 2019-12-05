/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     04.12.2019 15:56:41                          */
/*==============================================================*/
ALTER DATABASE hiddenAnacondaDB COLLATE POLISH_CI_AS;

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('czas_odjazdu') and o.name = 'FK_CZAS_ODJ_T2CZ_O_TRASA')
alter table czas_odjazdu
   drop constraint FK_CZAS_ODJ_T2CZ_O_TRASA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('czas_realizacji') and o.name = 'FK_CZAS_REA_CZ_O2CZ_R_CZAS_ODJ')
alter table czas_realizacji
   drop constraint FK_CZAS_REA_CZ_O2CZ_R_CZAS_ODJ
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('czas_realizacji') and o.name = 'FK_CZAS_REA_R_K2CZ_R_REALIZAC')
alter table czas_realizacji
   drop constraint FK_CZAS_REA_R_K2CZ_R_REALIZAC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_K2CZ_O_CZAS_ODJ')
alter table kurs
   drop constraint FK_KURS_K2CZ_O_CZAS_ODJ
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_L2K_LINIA')
alter table kurs
   drop constraint FK_KURS_L2K_LINIA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('realizacja_kursu') and o.name = 'FK_REALIZAC_RELATIONS_POJAZD')
alter table realizacja_kursu
   drop constraint FK_REALIZAC_RELATIONS_POJAZD
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('realizacja_kursu') and o.name = 'FK_REALIZAC_K2RK_KURS')
alter table realizacja_kursu
   drop constraint FK_REALIZAC_K2RK_KURS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('realizacja_kursu') and o.name = 'FK_REALIZAC_PK2RK_KIEROWCA')
alter table realizacja_kursu
   drop constraint FK_REALIZAC_PK2RK_KIEROWCA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('realizacja_kursu') and o.name = 'FK_REALIZAC_WK2RK_KIEROWCA')
alter table realizacja_kursu
   drop constraint FK_REALIZAC_WK2RK_KIEROWCA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('trasa') and o.name = 'FK_TRASA_P2T_PRZYSTAN')
alter table trasa
   drop constraint FK_TRASA_P2T_PRZYSTAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('trasa') and o.name = 'FK_TRASA_T2L_LINIA')
alter table trasa
   drop constraint FK_TRASA_T2L_LINIA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('czas_odjazdu')
            and   name  = 't2cz_o_FK'
            and   indid > 0
            and   indid < 255)
   drop index czas_odjazdu.t2cz_o_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('czas_odjazdu')
            and   type = 'U')
   drop table czas_odjazdu
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('czas_realizacji')
            and   name  = 'r_k2cz_r_FK'
            and   indid > 0
            and   indid < 255)
   drop index czas_realizacji.r_k2cz_r_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('czas_realizacji')
            and   name  = 'cz_o2cz_r_FK'
            and   indid > 0
            and   indid < 255)
   drop index czas_realizacji.cz_o2cz_r_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('czas_realizacji')
            and   type = 'U')
   drop table czas_realizacji
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dni_kursowania')
            and   type = 'U')
   drop table dni_kursowania
go

if exists (select 1
            from  sysobjects
           where  id = object_id('kierowca')
            and   type = 'U')
   drop table kierowca
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('kurs')
            and   name  = 'k2cz_o_FK'
            and   indid > 0
            and   indid < 255)
   drop index kurs.k2cz_o_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('kurs')
            and   name  = 'l2k_FK'
            and   indid > 0
            and   indid < 255)
   drop index kurs.l2k_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('kurs')
            and   type = 'U')
   drop table kurs
go

if exists (select 1
            from  sysobjects
           where  id = object_id('linia')
            and   type = 'U')
   drop table linia
go

if exists (select 1
            from  sysobjects
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
go

if exists (select 1
            from  sysobjects
           where  id = object_id('pojazd')
            and   type = 'U')
   drop table pojazd
go

if exists (select 1
            from  sysobjects
           where  id = object_id('przystanek')
            and   type = 'U')
   drop table przystanek
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('realizacja_kursu')
            and   name  = 'k2rk_FK'
            and   indid > 0
            and   indid < 255)
   drop index realizacja_kursu.k2rk_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('realizacja_kursu')
            and   name  = 'Relationship_13_FK'
            and   indid > 0
            and   indid < 255)
   drop index realizacja_kursu.Relationship_13_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('realizacja_kursu')
            and   name  = 'wk2rk_FK'
            and   indid > 0
            and   indid < 255)
   drop index realizacja_kursu.wk2rk_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('realizacja_kursu')
            and   name  = 'pk2rk_FK'
            and   indid > 0
            and   indid < 255)
   drop index realizacja_kursu.pk2rk_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('realizacja_kursu')
            and   type = 'U')
   drop table realizacja_kursu
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('trasa')
            and   name  = 't2l_FK'
            and   indid > 0
            and   indid < 255)
   drop index trasa.t2l_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('trasa')
            and   name  = 'p2t_FK'
            and   indid > 0
            and   indid < 255)
   drop index trasa.p2t_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('trasa')
            and   type = 'U')
   drop table trasa
go

/*==============================================================*/
/* Table: czas_odjazdu                                          */
/*==============================================================*/
create table czas_odjazdu (
   id_czasu_odjazdu     int                  identity,
   id_trasy             int                  not null,
   czas_odjazdu         datetime             not null,
   constraint PK_CZAS_ODJAZDU primary key nonclustered (id_czasu_odjazdu)
)
go

/*==============================================================*/
/* Index: t2cz_o_FK                                             */
/*==============================================================*/
create index t2cz_o_FK on czas_odjazdu (
id_trasy ASC
)
go

/*==============================================================*/
/* Table: czas_realizacji                                       */
/*==============================================================*/
create table czas_realizacji (
   id_czasu_realizacji  int                  identity,
   faktyczny_czas_odjazdu datetime             not null,
   id_czasu_odjazdu     int                  not null,
   id_realizacji_kursu  int                  not null,
   constraint PK_CZAS_REALIZACJI primary key nonclustered (id_czasu_realizacji)
)
go

/*==============================================================*/
/* Index: cz_o2cz_r_FK                                          */
/*==============================================================*/
create index cz_o2cz_r_FK on czas_realizacji (
id_czasu_odjazdu ASC
)
go

/*==============================================================*/
/* Index: r_k2cz_r_FK                                           */
/*==============================================================*/
create index r_k2cz_r_FK on czas_realizacji (
id_realizacji_kursu ASC
)
go

/*==============================================================*/
/* Table: dni_kursowania                                        */
/*==============================================================*/
create table dni_kursowania (
   id_dni_kursowania    int                  identity,
   od_dnia              datetime             not null,
   do_dnia              datetime             not null,
   rodzaj_kursu         nvarchar(30)          collate POLISH_CI_AS not null,
   constraint PK_DNI_KURSOWANIA primary key nonclustered (id_dni_kursowania)
)
go

/*==============================================================*/
/* Table: kierowca                                              */
/*==============================================================*/
create table kierowca (
   id_kierowcy          int                  identity,
   imie                 nvarchar(30)          collate POLISH_CI_AS not null,
   nazwisko             nvarchar(30)          collate POLISH_CI_AS not null,
   czy_pracuje          bit                  not null,
   PESEL                bigint               not null,
   constraint PK_KIEROWCA primary key nonclustered (id_kierowcy)
)
go

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
go

/*==============================================================*/
/* Index: l2k_FK                                                */
/*==============================================================*/
create index l2k_FK on kurs (
id_linii ASC
)
go

/*==============================================================*/
/* Index: k2cz_o_FK                                             */
/*==============================================================*/
create index k2cz_o_FK on kurs (
id_czasu_odjazdu ASC
)
go

/*==============================================================*/
/* Table: linia                                                 */
/*==============================================================*/
create table linia (
   id_linii             int                  identity,
   czy_zapetla          bit                  not null,
   constraint PK_LINIA primary key nonclustered (id_linii)
)
go

/*==============================================================*/
/* Table: logowanie                                             */
/*==============================================================*/
create table logowanie (
   id_uzytkownika       int                  identity,
   login                nvarchar(20)          collate POLISH_CI_AS not null,
   hasz                 nvarchar(72)          collate POLISH_CI_AS not null,
   poziom_uprawnien     int                  not null,
   czy_aktywny          bit                  not null,
   constraint PK_LOGOWANIE primary key (id_uzytkownika)
)
go

/*==============================================================*/
/* Table: pojazd                                                */
/*==============================================================*/
create table pojazd (
   id_pojazdu           int                  identity,
   nr_rejestracyjny     nvarchar(7)           collate POLISH_CI_AS not null,
   model                nvarchar(20)          collate POLISH_CI_AS not null,
   marka                nvarchar(20)          collate POLISH_CI_AS not null,
   czy_niskopodlogowy   bit                  not null,
   czy_sprawny          bit                  not null,
   constraint PK_POJAZD primary key nonclustered (id_pojazdu)
)
go

/*==============================================================*/
/* Table: przystanek                                            */
/*==============================================================*/
create table przystanek (
   id_przystanku        int                  identity,
   nazwa                nvarchar(30)          collate POLISH_CI_AS not null,
   miasto               nvarchar(30)          collate POLISH_CI_AS not null,
   czy_jednokierunkowy  bit                  not null,
   constraint PK_PRZYSTANEK primary key nonclustered (id_przystanku)
)
go

/*==============================================================*/
/* Table: realizacja_kursu                                      */
/*==============================================================*/
create table realizacja_kursu (
   id_realizacji_kursu  int                  identity,
   id_przypisanego_kierowcy int                  not null,
   id_wykonujacego_kierowcy int                  null,
   id_pojazdu           int                  not null,
   id_kursu             int                  not null,
   data_realizacji      datetime             not null,
   constraint PK_REALIZACJA_KURSU primary key nonclustered (id_realizacji_kursu)
)
go

/*==============================================================*/
/* Index: pk2rk_FK                                              */
/*==============================================================*/
create index pk2rk_FK on realizacja_kursu (
id_przypisanego_kierowcy ASC
)
go

/*==============================================================*/
/* Index: wk2rk_FK                                              */
/*==============================================================*/
create index wk2rk_FK on realizacja_kursu (
id_wykonujacego_kierowcy ASC
)
go

/*==============================================================*/
/* Index: Relationship_13_FK                                    */
/*==============================================================*/
create index Relationship_13_FK on realizacja_kursu (
id_pojazdu ASC
)
go

/*==============================================================*/
/* Index: k2rk_FK                                               */
/*==============================================================*/
create index k2rk_FK on realizacja_kursu (
id_kursu ASC
)
go

/*==============================================================*/
/* Table: trasa                                                 */
/*==============================================================*/
create table trasa (
   id_trasy             int                  identity,
   id_linii             int                  not null,
   id_przystanku        int                  not null,
   kolejnosc_przystankow int                  not null,
   nr_trasy             int                  not null,
   constraint PK_TRASA primary key nonclustered (id_trasy)
)
go

/*==============================================================*/
/* Index: p2t_FK                                                */
/*==============================================================*/
create index p2t_FK on trasa (
id_przystanku ASC
)
go

/*==============================================================*/
/* Index: t2l_FK                                                */
/*==============================================================*/
create index t2l_FK on trasa (
id_linii ASC
)
go

alter table czas_odjazdu
   add constraint FK_CZAS_ODJ_T2CZ_O_TRASA foreign key (id_trasy)
      references trasa (id_trasy)
go

alter table czas_realizacji
   add constraint FK_CZAS_REA_CZ_O2CZ_R_CZAS_ODJ foreign key (id_czasu_odjazdu)
      references czas_odjazdu (id_czasu_odjazdu)
go

alter table czas_realizacji
   add constraint FK_CZAS_REA_R_K2CZ_R_REALIZAC foreign key (id_realizacji_kursu)
      references realizacja_kursu (id_realizacji_kursu)
go

alter table kurs
   add constraint FK_KURS_REFERENCE_TRASA foreign key (id_trasy)
      references trasa (id_trasy)
go

alter table kurs
   add constraint FK_KURS_K2CZ_O_CZAS_ODJ foreign key (id_czasu_odjazdu)
      references czas_odjazdu (id_czasu_odjazdu)
go

alter table kurs
   add constraint FK_KURS_L2K_LINIA foreign key (id_linii)
      references linia (id_linii)
go

alter table realizacja_kursu
   add constraint FK_REALIZAC_RELATIONS_POJAZD foreign key (id_pojazdu)
      references pojazd (id_pojazdu)
go

alter table realizacja_kursu
   add constraint FK_REALIZAC_K2RK_KURS foreign key (id_kursu)
      references kurs (id_kursu)
go

alter table realizacja_kursu
   add constraint FK_REALIZAC_PK2RK_KIEROWCA foreign key (id_przypisanego_kierowcy)
      references kierowca (id_kierowcy)
go

alter table realizacja_kursu
   add constraint FK_REALIZAC_WK2RK_KIEROWCA foreign key (id_wykonujacego_kierowcy)
      references kierowca (id_kierowcy)
go

alter table trasa
   add constraint FK_TRASA_P2T_PRZYSTAN foreign key (id_przystanku)
      references przystanek (id_przystanku)
go

alter table trasa
   add constraint FK_TRASA_T2L_LINIA foreign key (id_linii)
      references linia (id_linii)
go

