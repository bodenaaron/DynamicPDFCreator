
    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK_88062DE]') and parent_object_id = OBJECT_ID(N'Ansprechpartner2Projekt'))
alter table Ansprechpartner2Projekt  drop constraint FK_88062DE


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK_2167DE0F]') and parent_object_id = OBJECT_ID(N'Ansprechpartner2Projekt'))
alter table Ansprechpartner2Projekt  drop constraint FK_2167DE0F


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK_731C7101]') and parent_object_id = OBJECT_ID(N'Ansprechpartner2Projekt'))
alter table Ansprechpartner2Projekt  drop constraint FK_731C7101


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK_A0D4BBC7]') and parent_object_id = OBJECT_ID(N'Auftrag'))
alter table Auftrag  drop constraint FK_A0D4BBC7


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK_A234C863]') and parent_object_id = OBJECT_ID(N'Auftrag'))
alter table Auftrag  drop constraint FK_A234C863


    if exists (select * from dbo.sysobjects where id = object_id(N'WesiTeam') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table WesiTeam

    if exists (select * from dbo.sysobjects where id = object_id(N'Bearbeiter') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Bearbeiter

    if exists (select * from dbo.sysobjects where id = object_id(N'AnschreibenTyp') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table AnschreibenTyp

    if exists (select * from dbo.sysobjects where id = object_id(N'Ansprechpartner') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Ansprechpartner

    if exists (select * from dbo.sysobjects where id = object_id(N'Ansprechpartner2Projekt') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Ansprechpartner2Projekt

    if exists (select * from dbo.sysobjects where id = object_id(N'Auftrag') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Auftrag

    if exists (select * from dbo.sysobjects where id = object_id(N'Projekt') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Projekt

    create table WesiTeam (
        id SMALLINT IDENTITY NOT NULL,
       Firma NVARCHAR(255) null,
       Stadt NVARCHAR(255) null,
       PLZ NVARCHAR(255) null,
       Strasse NVARCHAR(255) null,
       Bereich NVARCHAR(255) null,
       Email NVARCHAR(255) null,
       Niederlassung NVARCHAR(255) null,
       primary key (id)
    )

    create table Bearbeiter (
        idBearbeiter NVARCHAR(255) IDENTITY NOT NULL,
       Email NVARCHAR(255) null,
       Telefon NVARCHAR(255) null,
       Bearbeiter_Name NVARCHAR(255) null,
       Bearbeiter_Vorname NVARCHAR(255) null,
       primary key (idBearbeiter)
    )

    create table AnschreibenTyp (
        idBearbeiter SMALLINT IDENTITY NOT NULL,
       Bezeichnung NVARCHAR(255) null,
       primary key (idBearbeiter)
    )

    create table Ansprechpartner (
        idAnsprechpartner INT IDENTITY NOT NULL,
       Funktion NVARCHAR(255) null,
       Ansprechpartner_Name NVARCHAR(255) null,
       Ansprechpartner_Vorname NVARCHAR(255) null,
       Telefon NVARCHAR(255) null,
       Mobil NVARCHAR(255) null,
       Email NVARCHAR(255) null,
       Typ NVARCHAR(255) null,
       Bereich NVARCHAR(255) null,
       Homepage NVARCHAR(255) null,
       PLZ NVARCHAR(255) null,
       Straße NVARCHAR(255) null,
       Niederlassung NVARCHAR(255) null,
       NL-Abteilung NVARCHAR(255) null,
       PTI-Bereich NVARCHAR(255) null,
       Bemerkung NVARCHAR(255) null,
       Firma NVARCHAR(255) null,
       primary key (idAnsprechpartner)
    )

    create table Ansprechpartner2Projekt (
        idProjekt INT not null,
       elt INT not null,
       idAnsprechpartner INT not null,
       primary key (idAnsprechpartner, elt)
    )

    create table Auftrag (
        idAuftrag INT IDENTITY NOT NULL,
       SM_Nummer NVARCHAR(255) null,
       idProjekt INT null,
       primary key (idAuftrag)
    )

    create table Projekt (
        idProjekt INT IDENTITY NOT NULL,
       Projekt NVARCHAR(255) null,
       Bemerkung_Projekt NVARCHAR(255) null,
       primary key (idProjekt)
    )

    alter table Ansprechpartner2Projekt 
        add constraint FK_88062DE 
        foreign key (elt) 
        references Projekt

    alter table Ansprechpartner2Projekt 
        add constraint FK_2167DE0F 
        foreign key (idProjekt) 
        references Ansprechpartner

    alter table Ansprechpartner2Projekt 
        add constraint FK_731C7101 
        foreign key (idAnsprechpartner) 
        references Projekt

    alter table Auftrag 
        add constraint FK_A0D4BBC7 
        foreign key (idProjekt) 
        references Projekt

    alter table Auftrag 
        add constraint FK_A234C863 
        foreign key (idAuftrag) 
        references Projekt
