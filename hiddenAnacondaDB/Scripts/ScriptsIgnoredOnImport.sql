
/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     23.11.2019 09:20:36                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('czas_odjazdu') and o.name = 'FK_CZAS_ODJ_T2CZ_O_TRASA')
alter table czas_odjazdu
   drop constraint FK_CZAS_ODJ_T2CZ_O_TRASA
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('czas_realizacji') and o.name = 'FK_CZAS_REA_CZ_O2CZ_R_CZAS_ODJ')
alter table czas_realizacji
   drop constraint FK_CZAS_REA_CZ_O2CZ_R_CZAS_ODJ
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('czas_realizacji') and o.name = 'FK_CZAS_REA_R_K2CZ_R_REALIZAC')
alter table czas_realizacji
   drop constraint FK_CZAS_REA_R_K2CZ_R_REALIZAC
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_D_K2K_DNI_KURS')
alter table kurs
   drop constraint FK_KURS_D_K2K_DNI_KURS
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_K2CZ_O_CZAS_ODJ')
alter table kurs
   drop constraint FK_KURS_K2CZ_O_CZAS_ODJ
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_L2K_LINIA')
alter table kurs
   drop constraint FK_KURS_L2K_LINIA
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('realizacja_kursu') and o.name = 'FK_REALIZAC_RELATIONS_POJAZD')
alter table realizacja_kursu
   drop constraint FK_REALIZAC_RELATIONS_POJAZD
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('realizacja_kursu') and o.name = 'FK_REALIZAC_K2RK_KURS')
alter table realizacja_kursu
   drop constraint FK_REALIZAC_K2RK_KURS
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('realizacja_kursu') and o.name = 'FK_REALIZAC_PK2RK_KIEROWCA')
alter table realizacja_kursu
   drop constraint FK_REALIZAC_PK2RK_KIEROWCA
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('realizacja_kursu') and o.name = 'FK_REALIZAC_WK2RK_KIEROWCA')
alter table realizacja_kursu
   drop constraint FK_REALIZAC_WK2RK_KIEROWCA
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('trasa') and o.name = 'FK_TRASA_P2T_PRZYSTAN')
alter table trasa
   drop constraint FK_TRASA_P2T_PRZYSTAN
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('trasa') and o.name = 'FK_TRASA_T2L_LINIA')
alter table trasa
   drop constraint FK_TRASA_T2L_LINIA
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('czas_odjazdu')
            and   name  = 't2cz_o_FK'
            and   indid > 0
            and   indid < 255)
   drop index czas_odjazdu.t2cz_o_FK
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('czas_odjazdu')
            and   type = 'U')
   drop table czas_odjazdu
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('czas_realizacji')
            and   name  = 'r_k2cz_r_FK'
            and   indid > 0
            and   indid < 255)
   drop index czas_realizacji.r_k2cz_r_FK
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('czas_realizacji')
            and   name  = 'cz_o2cz_r_FK'
            and   indid > 0
            and   indid < 255)
   drop index czas_realizacji.cz_o2cz_r_FK
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('czas_realizacji')
            and   type = 'U')
   drop table czas_realizacji
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('dni_kursowania')
            and   type = 'U')
   drop table dni_kursowania
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('kierowca')
            and   type = 'U')
   drop table kierowca
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('kurs')
            and   name  = 'd_k2k_FK'
            and   indid > 0
            and   indid < 255)
   drop index kurs.d_k2k_FK
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('kurs')
            and   name  = 'k2cz_o_FK'
            and   indid > 0
            and   indid < 255)
   drop index kurs.k2cz_o_FK
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('kurs')
            and   name  = 'l2k_FK'
            and   indid > 0
            and   indid < 255)
   drop index kurs.l2k_FK
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('kurs')
            and   type = 'U')
   drop table kurs
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('linia')
            and   type = 'U')
   drop table linia
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('pojazd')
            and   type = 'U')
   drop table pojazd
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('przystanek')
            and   type = 'U')
   drop table przystanek
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('realizacja_kursu')
            and   name  = 'k2rk_FK'
            and   indid > 0
            and   indid < 255)
   drop index realizacja_kursu.k2rk_FK
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('realizacja_kursu')
            and   name  = 'Relationship_13_FK'
            and   indid > 0
            and   indid < 255)
   drop index realizacja_kursu.Relationship_13_FK
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('realizacja_kursu')
            and   name  = 'wk2rk_FK'
            and   indid > 0
            and   indid < 255)
   drop index realizacja_kursu.wk2rk_FK
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('realizacja_kursu')
            and   name  = 'pk2rk_FK'
            and   indid > 0
            and   indid < 255)
   drop index realizacja_kursu.pk2rk_FK
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('realizacja_kursu')
            and   type = 'U')
   drop table realizacja_kursu
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('trasa')
            and   name  = 't2l_FK'
            and   indid > 0
            and   indid < 255)
   drop index trasa.t2l_FK
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('trasa')
            and   name  = 'p2t_FK'
            and   indid > 0
            and   indid < 255)
   drop index trasa.p2t_FK
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('trasa')
            and   type = 'U')
   drop table trasa
GO

/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     23.11.2019 09:20:36                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('czas_odjazdu') and o.name = 'FK_CZAS_ODJ_T2CZ_O_TRASA')
alter table czas_odjazdu
   drop constraint FK_CZAS_ODJ_T2CZ_O_TRASA
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('czas_realizacji') and o.name = 'FK_CZAS_REA_CZ_O2CZ_R_CZAS_ODJ')
alter table czas_realizacji
   drop constraint FK_CZAS_REA_CZ_O2CZ_R_CZAS_ODJ
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('czas_realizacji') and o.name = 'FK_CZAS_REA_R_K2CZ_R_REALIZAC')
alter table czas_realizacji
   drop constraint FK_CZAS_REA_R_K2CZ_R_REALIZAC
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_D_K2K_DNI_KURS')
alter table kurs
   drop constraint FK_KURS_D_K2K_DNI_KURS
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_K2CZ_O_CZAS_ODJ')
alter table kurs
   drop constraint FK_KURS_K2CZ_O_CZAS_ODJ
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_L2K_LINIA')
alter table kurs
   drop constraint FK_KURS_L2K_LINIA
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('realizacja_kursu') and o.name = 'FK_REALIZAC_RELATIONS_POJAZD')
alter table realizacja_kursu
   drop constraint FK_REALIZAC_RELATIONS_POJAZD
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('realizacja_kursu') and o.name = 'FK_REALIZAC_K2RK_KURS')
alter table realizacja_kursu
   drop constraint FK_REALIZAC_K2RK_KURS
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('realizacja_kursu') and o.name = 'FK_REALIZAC_PK2RK_KIEROWCA')
alter table realizacja_kursu
   drop constraint FK_REALIZAC_PK2RK_KIEROWCA
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('realizacja_kursu') and o.name = 'FK_REALIZAC_WK2RK_KIEROWCA')
alter table realizacja_kursu
   drop constraint FK_REALIZAC_WK2RK_KIEROWCA
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('trasa') and o.name = 'FK_TRASA_P2T_PRZYSTAN')
alter table trasa
   drop constraint FK_TRASA_P2T_PRZYSTAN
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('trasa') and o.name = 'FK_TRASA_T2L_LINIA')
alter table trasa
   drop constraint FK_TRASA_T2L_LINIA
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('czas_odjazdu')
            and   name  = 't2cz_o_FK'
            and   indid > 0
            and   indid < 255)
   drop index czas_odjazdu.t2cz_o_FK
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('czas_odjazdu')
            and   type = 'U')
   drop table czas_odjazdu
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('czas_realizacji')
            and   name  = 'r_k2cz_r_FK'
            and   indid > 0
            and   indid < 255)
   drop index czas_realizacji.r_k2cz_r_FK
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('czas_realizacji')
            and   name  = 'cz_o2cz_r_FK'
            and   indid > 0
            and   indid < 255)
   drop index czas_realizacji.cz_o2cz_r_FK
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('czas_realizacji')
            and   type = 'U')
   drop table czas_realizacji
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('dni_kursowania')
            and   type = 'U')
   drop table dni_kursowania
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('kierowca')
            and   type = 'U')
   drop table kierowca
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('kurs')
            and   name  = 'd_k2k_FK'
            and   indid > 0
            and   indid < 255)
   drop index kurs.d_k2k_FK
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('kurs')
            and   name  = 'k2cz_o_FK'
            and   indid > 0
            and   indid < 255)
   drop index kurs.k2cz_o_FK
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('kurs')
            and   name  = 'l2k_FK'
            and   indid > 0
            and   indid < 255)
   drop index kurs.l2k_FK
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('kurs')
            and   type = 'U')
   drop table kurs
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('linia')
            and   type = 'U')
   drop table linia
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('pojazd')
            and   type = 'U')
   drop table pojazd
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('przystanek')
            and   type = 'U')
   drop table przystanek
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('realizacja_kursu')
            and   name  = 'k2rk_FK'
            and   indid > 0
            and   indid < 255)
   drop index realizacja_kursu.k2rk_FK
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('realizacja_kursu')
            and   name  = 'Relationship_13_FK'
            and   indid > 0
            and   indid < 255)
   drop index realizacja_kursu.Relationship_13_FK
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('realizacja_kursu')
            and   name  = 'wk2rk_FK'
            and   indid > 0
            and   indid < 255)
   drop index realizacja_kursu.wk2rk_FK
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('realizacja_kursu')
            and   name  = 'pk2rk_FK'
            and   indid > 0
            and   indid < 255)
   drop index realizacja_kursu.pk2rk_FK
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('realizacja_kursu')
            and   type = 'U')
   drop table realizacja_kursu
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('trasa')
            and   name  = 't2l_FK'
            and   indid > 0
            and   indid < 255)
   drop index trasa.t2l_FK
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('trasa')
            and   name  = 'p2t_FK'
            and   indid > 0
            and   indid < 255)
   drop index trasa.p2t_FK
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('trasa')
            and   type = 'U')
   drop table trasa
GO

INSERT INTO kierowca VALUES (5, Jan, asd, TRUE, 12345678985)
GO

/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     24.11.2019 09:57:42                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('czas_odjazdu') and o.name = 'FK_CZAS_ODJ_T2CZ_O_TRASA')
alter table czas_odjazdu
   drop constraint FK_CZAS_ODJ_T2CZ_O_TRASA
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('czas_realizacji') and o.name = 'FK_CZAS_REA_CZ_O2CZ_R_CZAS_ODJ')
alter table czas_realizacji
   drop constraint FK_CZAS_REA_CZ_O2CZ_R_CZAS_ODJ
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('czas_realizacji') and o.name = 'FK_CZAS_REA_R_K2CZ_R_REALIZAC')
alter table czas_realizacji
   drop constraint FK_CZAS_REA_R_K2CZ_R_REALIZAC
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_D_K2K_DNI_KURS')
alter table kurs
   drop constraint FK_KURS_D_K2K_DNI_KURS
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_K2CZ_O_CZAS_ODJ')
alter table kurs
   drop constraint FK_KURS_K2CZ_O_CZAS_ODJ
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_L2K_LINIA')
alter table kurs
   drop constraint FK_KURS_L2K_LINIA
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('realizacja_kursu') and o.name = 'FK_REALIZAC_RELATIONS_POJAZD')
alter table realizacja_kursu
   drop constraint FK_REALIZAC_RELATIONS_POJAZD
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('realizacja_kursu') and o.name = 'FK_REALIZAC_K2RK_KURS')
alter table realizacja_kursu
   drop constraint FK_REALIZAC_K2RK_KURS
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('realizacja_kursu') and o.name = 'FK_REALIZAC_PK2RK_KIEROWCA')
alter table realizacja_kursu
   drop constraint FK_REALIZAC_PK2RK_KIEROWCA
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('realizacja_kursu') and o.name = 'FK_REALIZAC_WK2RK_KIEROWCA')
alter table realizacja_kursu
   drop constraint FK_REALIZAC_WK2RK_KIEROWCA
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('trasa') and o.name = 'FK_TRASA_P2T_PRZYSTAN')
alter table trasa
   drop constraint FK_TRASA_P2T_PRZYSTAN
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('trasa') and o.name = 'FK_TRASA_T2L_LINIA')
alter table trasa
   drop constraint FK_TRASA_T2L_LINIA
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('czas_odjazdu')
            and   name  = 't2cz_o_FK'
            and   indid > 0
            and   indid < 255)
   drop index czas_odjazdu.t2cz_o_FK
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('czas_odjazdu')
            and   type = 'U')
   drop table czas_odjazdu
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('czas_realizacji')
            and   name  = 'r_k2cz_r_FK'
            and   indid > 0
            and   indid < 255)
   drop index czas_realizacji.r_k2cz_r_FK
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('czas_realizacji')
            and   name  = 'cz_o2cz_r_FK'
            and   indid > 0
            and   indid < 255)
   drop index czas_realizacji.cz_o2cz_r_FK
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('czas_realizacji')
            and   type = 'U')
   drop table czas_realizacji
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('dni_kursowania')
            and   type = 'U')
   drop table dni_kursowania
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('kierowca')
            and   type = 'U')
   drop table kierowca
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('kurs')
            and   name  = 'd_k2k_FK'
            and   indid > 0
            and   indid < 255)
   drop index kurs.d_k2k_FK
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('kurs')
            and   name  = 'k2cz_o_FK'
            and   indid > 0
            and   indid < 255)
   drop index kurs.k2cz_o_FK
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('kurs')
            and   name  = 'l2k_FK'
            and   indid > 0
            and   indid < 255)
   drop index kurs.l2k_FK
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('kurs')
            and   type = 'U')
   drop table kurs
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('linia')
            and   type = 'U')
   drop table linia
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('pojazd')
            and   type = 'U')
   drop table pojazd
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('przystanek')
            and   type = 'U')
   drop table przystanek
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('realizacja_kursu')
            and   name  = 'k2rk_FK'
            and   indid > 0
            and   indid < 255)
   drop index realizacja_kursu.k2rk_FK
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('realizacja_kursu')
            and   name  = 'Relationship_13_FK'
            and   indid > 0
            and   indid < 255)
   drop index realizacja_kursu.Relationship_13_FK
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('realizacja_kursu')
            and   name  = 'wk2rk_FK'
            and   indid > 0
            and   indid < 255)
   drop index realizacja_kursu.wk2rk_FK
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('realizacja_kursu')
            and   name  = 'pk2rk_FK'
            and   indid > 0
            and   indid < 255)
   drop index realizacja_kursu.pk2rk_FK
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('realizacja_kursu')
            and   type = 'U')
   drop table realizacja_kursu
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('trasa')
            and   name  = 't2l_FK'
            and   indid > 0
            and   indid < 255)
   drop index trasa.t2l_FK
GO

if exists (select 1
            from  sysindexes
           where  id    = object_id('trasa')
            and   name  = 'p2t_FK'
            and   indid > 0
            and   indid < 255)
   drop index trasa.p2t_FK
GO

if exists (select 1
            from  sysobjects
           where  id = object_id('trasa')
            and   type = 'U')
   drop table trasa
GO
