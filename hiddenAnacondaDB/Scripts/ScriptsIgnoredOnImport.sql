
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

/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     29.11.2019 09:58:45                          */
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
/* Created on:     29.11.2019 15:10:49                          */
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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
/* Created on:     29.11.2019 15:10:49                          */
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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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

--Dane dla dni kursowania
INSERT INTO [dbo].[dni_kursowania] ([id_dni_kursowania], [od_dnia], [do_dnia], [rodzaj_kursu]) VALUES (1, N'2020-11-25 00:00:00', N'2020-11-29 00:00:00', 0)
GO

INSERT INTO [dbo].[dni_kursowania] ([id_dni_kursowania], [od_dnia], [do_dnia], [rodzaj_kursu]) VALUES (2, N'2020-11-30 00:00:00', N'2020-12-01 00:00:00', 1)
GO

-- Dane dla kierowcow
INSERT INTO [dbo].[kierowca] ([id_kierowcy], [imie], [nazwisko], [czy_pracuje], [PESEL]) VALUES (1, N'Ryszard', N'Dobry', 1, 88111102744)
GO

INSERT INTO [dbo].[kierowca] ([id_kierowcy], [imie], [nazwisko], [czy_pracuje], [PESEL]) VALUES (2, N'Tomasz', N'Lepszy', 1, 87101208222)
GO

INSERT INTO [dbo].[kierowca] ([id_kierowcy], [imie], [nazwisko], [czy_pracuje], [PESEL]) VALUES (3, N'Wieslaw', N'Najlepszy', 1, 77030113562)
GO

INSERT INTO [dbo].[kierowca] ([id_kierowcy], [imie], [nazwisko], [czy_pracuje], [PESEL]) VALUES (4, N'Artur', N'Wrak', 1, 90010125732)
GO

INSERT INTO [dbo].[kierowca] ([id_kierowcy], [imie], [nazwisko], [czy_pracuje], [PESEL]) VALUES (5, N'Robert', N'Nowak', 1, 76121288126)
GO

-- Dane dla pojazdu
INSERT INTO [dbo].[pojazd] ([id_pojazdu], [nr_rejestracyjny], [model], [marka], [czy_niskopodlogowy], [czy_sprawny]) VALUES (0, N'SK12A12', N'Urbino12', N'Solaris', 1, 1)
GO

INSERT INTO [dbo].[pojazd] ([id_pojazdu], [nr_rejestracyjny], [model], [marka], [czy_niskopodlogowy], [czy_sprawny]) VALUES (1, N'SK13A13', N'Urbino12', N'Solaris', 1, 1)
GO

INSERT INTO [dbo].[pojazd] ([id_pojazdu], [nr_rejestracyjny], [model], [marka], [czy_niskopodlogowy], [czy_sprawny]) VALUES (2, N'SK14A14', N'Urbino18', N'Solaris', 1, 1)
GO

INSERT INTO [dbo].[pojazd] ([id_pojazdu], [nr_rejestracyjny], [model], [marka], [czy_niskopodlogowy], [czy_sprawny]) VALUES (3, N'SK15A15', N'Urbino18', N'Solaris', 1, 1)
GO

INSERT INTO [dbo].[pojazd] ([id_pojazdu], [nr_rejestracyjny], [model], [marka], [czy_niskopodlogowy], [czy_sprawny]) VALUES (4, N'SK16A16', N'Urbino10,5', N'Solaris', 1, 1)
GO

-- Dane dla lini
INSERT INTO [dbo].[linia] ([id_linii], [czy_zapetla]) VALUES (101, 1)
GO

INSERT INTO [dbo].[linia] ([id_linii], [czy_zapetla]) VALUES (164, 1)
GO

INSERT INTO [dbo].[linia] ([id_linii], [czy_zapetla]) VALUES (551, 0)
GO

-- Dane dla przystankow
INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1000, N'Aleja Korfantego', N'Katowice', 0)
GO

INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1001, N'Strefa Kultury', N'Katowice', 0)
GO

INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1002, N'Porcelanowa', N'Katowice', 0)
GO

INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1003, N'Browar', N'Tychy', 0)
GO

INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1004, N'Skalka', N'Tychy', 0)
GO

INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1005, N'Niepodleglosci', N'Tychy', 0)
GO

INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1006, N'Tecza', N'Tychy', 0)
GO

INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1007, N'Plac Piastow', N'Gliwice', 0)
GO

INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1008, N'Komag', N'Gliwice', 0)
GO

INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1009, N'Plac 750-lecia', N'Mikolów', 0)
GO

INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1010, N'Dworzec PKP', N'Mikolów', 0)
GO

INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1011, N'Dworzec PKP', N'Tychy', 0)
GO

INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1012, N'Hotelowiec', N'Tychy', 1)
GO

INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1013, N'Krakowska', N'Mikolów', 1)
GO

INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1014, N'Chlodnicza', N'Tychy', 1)
GO

INSERT INTO [dbo].[przystanek] ([id_przystanku], [nazwa], [miasto], [czy_jednokierunkowy]) VALUES (1115, N'Dworzec PKP', N'Gliwice', 1)
GO

-- Dane dla tras
INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (0, 101, 1000, 1, 0)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (1, 101, 1001, 2, 0)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (2, 101, 1002, 3, 0)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (3, 101, 1003, 4, 0)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (4, 101, 1004, 5, 0)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (5, 101, 1005, 6, 0)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (6, 164, 1008, 1, 0)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (7, 164, 1009, 2, 0)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (8, 164, 1010, 3, 0)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (9, 164, 1011, 4, 0)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (10, 164, 1012, 5, 0)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (11, 164, 1013, 6, 0)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (12, 164, 1014, 7, 0)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (13, 164, 1014, 1, 1)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (14, 164, 1013, 2, 1)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (15, 164, 1012, 3, 1)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (16, 164, 1011, 4, 1)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (17, 164, 1010, 5, 1)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (18, 164, 1009, 6, 1)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (19, 164, 1008, 7, 1)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (20, 551, 1115, 1, 0)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (21, 551, 1011, 2, 0)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (22, 551, 1013, 3, 0)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (23, 551, 1000, 4, 0)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (24, 551, 1010, 5, 0)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (25, 101, 1005, 1, 1)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (26, 101, 1004, 2, 1)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (27, 101, 1003, 3, 1)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (28, 101, 1002, 4, 1)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (29, 101, 1001, 5, 1)
GO

INSERT INTO [dbo].[trasa] ([id_trasy], [id_linii], [id_przystanku], [kolejnosc_przystankow], [nr_trasy]) VALUES (30, 101, 1000, 6, 1)
GO

--Dane dla czasu odjazdu
INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (0, 0, N'7:15:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (1, 1, N'7:20:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (2, 2, N'7:25:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (3, 3, N'7:35:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (4, 4, N'7:45:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (5, 5, N'7:50:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (6, 6, N'11:22:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (7, 7, N'11:23:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (8, 8, N'11:24:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (9, 9, N'11:46:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (10, 10, N'12:16:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (11, 11, N'13:17:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (12, 12, N'13:21:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (13, 13, N'13:22:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (14, 14, N'13:26:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (15, 15, N'14:27:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (16, 16, N'14:57:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (17, 17, N'15:19:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (18, 18, N'15:20:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (19, 19, N'15:21:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (20, 20, N'13:33:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (21, 21, N'13:45:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (22, 22, N'14:00:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (23, 23, N'14:12:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (24, 24, N'14:22:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (25, 25, N'8:15:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (26, 26, N'8:20:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (27, 27, N'8:25:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (28, 28, N'8:35:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (29, 29, N'8:45:00')
GO

INSERT INTO [dbo].[czas_odjazdu] ([id_czasu_odjazdu], [id_trasy], [czas_odjazdu]) VALUES (30, 30, N'8:50:00')
GO

-- Dane dla kursu
INSERT INTO [dbo].[kurs] ([id_kursu], [id_linii], [id_czasu_odjazdu], [id_trasy], [ktory_kurs_danego_dnia], [rodzaj_kursu]) VALUES (0, 101, 0, 0, 0, 0)
GO

INSERT INTO [dbo].[kurs] ([id_kursu], [id_linii], [id_czasu_odjazdu], [id_trasy], [ktory_kurs_danego_dnia], [rodzaj_kursu]) VALUES (1, 164, 6, 6, 0, 0)
GO

INSERT INTO [dbo].[kurs] ([id_kursu], [id_linii], [id_czasu_odjazdu], [id_trasy], [ktory_kurs_danego_dnia], [rodzaj_kursu]) VALUES (2, 164, 13, 13, 1, 0)
GO

INSERT INTO [dbo].[kurs] ([id_kursu], [id_linii], [id_czasu_odjazdu], [id_trasy], [ktory_kurs_danego_dnia], [rodzaj_kursu]) VALUES (3, 101, 25, 25, 1, 0)
GO

INSERT INTO [dbo].[kurs] ([id_kursu], [id_linii], [id_czasu_odjazdu], [id_trasy], [ktory_kurs_danego_dnia], [rodzaj_kursu]) VALUES (4, 551, 20, 20, 0, 1)
GO

--Dane dla realizacji kursu
INSERT INTO [dbo].[realizacja_kursu] ([id_realizacji_kursu], [id_przypisanego_kierowcy], [id_wykonujacego_kierowcy], [id_pojazdu], [id_kursu], [data_realizacji]) VALUES (0, 3, 3, 2, 0, N'2019-11-29 00:00:00')
GO

INSERT INTO [dbo].[realizacja_kursu] ([id_realizacji_kursu], [id_przypisanego_kierowcy], [id_wykonujacego_kierowcy], [id_pojazdu], [id_kursu], [data_realizacji]) VALUES (1, 1, 2, 3, 4, N'2019-11-30 00:00:00')
GO

-- Dane dla czasu realizacji
INSERT INTO [dbo].[czas_realizacji] ([id_czasu_realizacji], [faktyczny_czas_odjazdu], [id_czasu_odjazdu], [id_realizacji_kursu]) VALUES (0, N'7:15:00', 0, 0)
GO

INSERT INTO [dbo].[czas_realizacji] ([id_czasu_realizacji], [faktyczny_czas_odjazdu], [id_czasu_odjazdu], [id_realizacji_kursu]) VALUES (1, N'7:21:00', 1, 0)
GO

INSERT INTO [dbo].[czas_realizacji] ([id_czasu_realizacji], [faktyczny_czas_odjazdu], [id_czasu_odjazdu], [id_realizacji_kursu]) VALUES (2, N'7:25:00', 2, 0)
GO

INSERT INTO [dbo].[czas_realizacji] ([id_czasu_realizacji], [faktyczny_czas_odjazdu], [id_czasu_odjazdu], [id_realizacji_kursu]) VALUES (3, N'7:35:00', 3, 0)
GO

INSERT INTO [dbo].[czas_realizacji] ([id_czasu_realizacji], [faktyczny_czas_odjazdu], [id_czasu_odjazdu], [id_realizacji_kursu]) VALUES (4, N'7:45:00', 4, 0)
GO

INSERT INTO [dbo].[czas_realizacji] ([id_czasu_realizacji], [faktyczny_czas_odjazdu], [id_czasu_odjazdu], [id_realizacji_kursu]) VALUES (5, N'7:51:00', 5, 0)
GO

/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     29.11.2019 15:10:49                          */
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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
/* Created on:     04.12.2019 12:21:00                          */
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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
/* Created on:     04.12.2019 15:56:41                          */
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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
/* Created on:     04.12.2019 15:56:41                          */
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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
/* Created on:     04.12.2019 15:56:41                          */
/*==============================================================*/

/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     04.12.2019 15:56:41                          */
/*==============================================================*/
ALTER DATABASE hiddenAnacondaDB COLLATE POLISH_CI_AS;
GO

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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
/* Created on:     04.12.2019 15:56:41                          */
/*==============================================================*/

/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     04.12.2019 15:56:41                          */
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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
/* Created on:     04.12.2019 15:56:41                          */
/*==============================================================*/

/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     04.12.2019 15:56:41                          */
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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
/* Created on:     04.12.2019 15:56:41                          */
/*==============================================================*/

/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     04.12.2019 15:56:41                          */
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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
/* Created on:     04.12.2019 15:56:41                          */
/*==============================================================*/
ALTER DATABASE hiddenAnacondaDB COLLATE POLISH_CI_AS;
GO

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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
/* Created on:     04.12.2019 15:56:41                          */
/*==============================================================*/
ALTER DATABASE hiddenAnacondaDB COLLATE POLISH_CI_AS;
GO

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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
/* Created on:     04.12.2019 15:56:41                          */
/*==============================================================*/
ALTER DATABASE hiddenAnacondaDB COLLATE POLISH_CI_AS;
GO

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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
/* Created on:     04.12.2019 15:56:41                          */
/*==============================================================*/
ALTER DATABASE hiddenAnacondaDB COLLATE POLISH_CI_AS;
GO

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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
/* Created on:     04.12.2019 15:56:41                          */
/*==============================================================*/
ALTER DATABASE hiddenAnacondaDB COLLATE POLISH_CI_AS;
GO

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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
/* Created on:     04.12.2019 15:56:41                          */
/*==============================================================*/
ALTER DATABASE hiddenAnacondaDB COLLATE POLISH_CI_AS;
GO

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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
/* Created on:     04.12.2019 15:56:41                          */
/*==============================================================*/
ALTER DATABASE hiddenAnacondaDB COLLATE POLISH_CI_AS;
GO

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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
/* Created on:     04.12.2019 15:56:41                          */
/*==============================================================*/
ALTER DATABASE hiddenAnacondaDB COLLATE POLISH_CI_AS;
GO

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
   where r.fkeyid = object_id('kurs') and o.name = 'FK_KURS_REFERENCE_TRASA')
alter table kurs
   drop constraint FK_KURS_REFERENCE_TRASA
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
           where  id = object_id('logowanie')
            and   type = 'U')
   drop table logowanie
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
