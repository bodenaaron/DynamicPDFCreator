
    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK_2D4F8B40]') and parent_object_id = OBJECT_ID(N'tblAnsprechpartner2Projekt'))
alter table tblAnsprechpartner2Projekt  drop constraint FK_2D4F8B40


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK_2F850803]') and parent_object_id = OBJECT_ID(N'tblAnsprechpartner2Projekt'))
alter table tblAnsprechpartner2Projekt  drop constraint FK_2F850803


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK_A84EFCA2]') and parent_object_id = OBJECT_ID(N'tblAnsprechpartner2Projekt'))
alter table tblAnsprechpartner2Projekt  drop constraint FK_A84EFCA2


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK_CA96A8D4]') and parent_object_id = OBJECT_ID(N'tblAnsprechpartner2Projekt'))
alter table tblAnsprechpartner2Projekt  drop constraint FK_CA96A8D4


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK_97EA931B]') and parent_object_id = OBJECT_ID(N'tblAuftraege'))
alter table tblAuftraege  drop constraint FK_97EA931B


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK_AF26A49A]') and parent_object_id = OBJECT_ID(N'tblAuftraege'))
alter table tblAuftraege  drop constraint FK_AF26A49A


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK_515AFA3C]') and parent_object_id = OBJECT_ID(N'tblPDFs'))
alter table tblPDFs  drop constraint FK_515AFA3C


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK_B7D36CB2]') and parent_object_id = OBJECT_ID(N'tblPDFs'))
alter table tblPDFs  drop constraint FK_B7D36CB2


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK_BD12165A]') and parent_object_id = OBJECT_ID(N'tblPDFs'))
alter table tblPDFs  drop constraint FK_BD12165A


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK_E422AE6E]') and parent_object_id = OBJECT_ID(N'tblPDFs'))
alter table tblPDFs  drop constraint FK_E422AE6E


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK_D8AD87AD]') and parent_object_id = OBJECT_ID(N'tblPDFs'))
alter table tblPDFs  drop constraint FK_D8AD87AD


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK_15595A9A]') and parent_object_id = OBJECT_ID(N'tblPDFs'))
alter table tblPDFs  drop constraint FK_15595A9A


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK_419D9A5C]') and parent_object_id = OBJECT_ID(N'tblPDFs'))
alter table tblPDFs  drop constraint FK_419D9A5C


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK_11D7A606]') and parent_object_id = OBJECT_ID(N'tblZusatzanlagen'))
alter table tblZusatzanlagen  drop constraint FK_11D7A606


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK_7C0DB9B5]') and parent_object_id = OBJECT_ID(N'tblZusatzanlagen'))
alter table tblZusatzanlagen  drop constraint FK_7C0DB9B5


    if exists (select * from dbo.sysobjects where id = object_id(N'tblWesiTeam') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table tblWesiTeam

    if exists (select * from dbo.sysobjects where id = object_id(N'tblBearbeiter') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table tblBearbeiter

    if exists (select * from dbo.sysobjects where id = object_id(N'tblAnschreibenTyp') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table tblAnschreibenTyp

    if exists (select * from dbo.sysobjects where id = object_id(N'tblAnsprechpartner') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table tblAnsprechpartner

    if exists (select * from dbo.sysobjects where id = object_id(N'tblAnsprechpartner2Projekt') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table tblAnsprechpartner2Projekt

    if exists (select * from dbo.sysobjects where id = object_id(N'tblAuftraege') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table tblAuftraege

    if exists (select * from dbo.sysobjects where id = object_id(N'tblProjekte') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table tblProjekte

    if exists (select * from dbo.sysobjects where id = object_id(N'tblPDFs') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table tblPDFs

    if exists (select * from dbo.sysobjects where id = object_id(N'tblAnsprechpartnerTyp') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table tblAnsprechpartnerTyp

    if exists (select * from dbo.sysobjects where id = object_id(N'tblZusatzanlagen') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table tblZusatzanlagen

    create table tblWesiTeam (
        id SMALLINT IDENTITY NOT NULL,
       firma NVARCHAR(255) null,
       stadt NVARCHAR(255) null,
       plz NVARCHAR(255) null,
       strasse NVARCHAR(255) null,
       bereich NVARCHAR(255) null,
       email NVARCHAR(255) null,
       niederlassung NVARCHAR(255) null,
       primary key (id)
    )

    create table tblBearbeiter (
        idBearbeiter NVARCHAR(255) IDENTITY NOT NULL,
       Email NVARCHAR(255) null,
       Telefon NVARCHAR(255) null,
       Bearbeiter_Name NVARCHAR(255) null,
       Bearbeiter_Vorname NVARCHAR(255) null,
       primary key (idBearbeiter)
    )

    create table tblAnschreibenTyp (
        id SMALLINT IDENTITY NOT NULL,
       Bezeichnung NVARCHAR(255) null,
       primary key (id)
    )

    create table tblAnsprechpartner (
        idAnsprechpartner INT IDENTITY NOT NULL,
       [Funktion] NVARCHAR(255) null,
       [Ansprechpartner_Name] NVARCHAR(255) null,
       [Ansprechpartner_Vorname] NVARCHAR(255) null,
       [Telefon] NVARCHAR(255) null,
       [Mobil] NVARCHAR(255) null,
       [Email] NVARCHAR(255) null,
       [Typ] NVARCHAR(255) null,
       [Bereich] NVARCHAR(255) null,
       [Homepage] NVARCHAR(255) null,
       [PLZ] NVARCHAR(255) null,
       [Straße] NVARCHAR(255) null,
       [Niederlassung] NVARCHAR(255) null,
       [NL-Abteilung] NVARCHAR(255) null,
       [PTI-Bereich] NVARCHAR(255) null,
       Bemerkung NVARCHAR(255) null,
       [Firma] NVARCHAR(255) null,
       primary key (idAnsprechpartner)
    )

    create table tblAnsprechpartner2Projekt (
        [idAnsprechpartner] INT not null,
       idProjekt INT not null,
       [idProjekt] INT not null,
       idAnsprechpartner INT not null,
       primary key ([idProjekt], idAnsprechpartner)
    )

    create table tblAuftraege (
        idAuftrag INT IDENTITY NOT NULL,
       SM_Nummer NVARCHAR(255) null,
       idProjekt INT null,
       [idAuftrag] INT null,
       primary key (idAuftrag)
    )

    create table tblProjekte (
        [idProjekt] INT IDENTITY NOT NULL,
       [Projekt] NVARCHAR(255) null,
       [Bemerkung_Projekt] NVARCHAR(255) null,
       primary key ([idProjekt])
    )

    create table tblPDFs (
        id NVARCHAR(255) not null,
       auftrag INT null,
       anschreibenTyp SMALLINT null,
       empfaenger INT null,
       absender NVARCHAR(255) null,
       ansprechpartner NVARCHAR(255) null,
       ansprechpartnerBau INT null,
       wesiTeam SMALLINT null,
       erstellungsZeitpunkt DateTime not null,
       ausfuehrungszeitraum DateTime not null,
       ausfuehrungszeitraumEnde DateTime not null,
       ortDerMassnahme NVARCHAR(255) null,
       abgesprochenMit NVARCHAR(255) null,
       beschreibungMassnahme NVARCHAR(255) null,
       plansaetze BIT null,
       untervollmacht BIT null,
       listeBeteiligte BIT null,
       techBeschreibung BIT null,
       primary key (id)
    )

    create table tblAnsprechpartnerTyp (
        idAnsprechpartnerTyp NVARCHAR(255) IDENTITY NOT NULL,
       Bezeichnung NVARCHAR(255) null,
       primary key (idAnsprechpartnerTyp)
    )

    create table tblZusatzanlagen (
        id INT IDENTITY NOT NULL,
       anlage NVARCHAR(255) null,
       idPDF NVARCHAR(255) null,
       primary key (id)
    )

    alter table tblAnsprechpartner2Projekt 
        add constraint FK_2D4F8B40 
        foreign key (idProjekt) 
        references tblProjekte

    alter table tblAnsprechpartner2Projekt 
        add constraint FK_2F850803 
        foreign key ([idAnsprechpartner]) 
        references tblAnsprechpartner

    alter table tblAnsprechpartner2Projekt 
        add constraint FK_A84EFCA2 
        foreign key (idAnsprechpartner) 
        references tblAnsprechpartner

    alter table tblAnsprechpartner2Projekt 
        add constraint FK_CA96A8D4 
        foreign key ([idProjekt]) 
        references tblProjekte

    alter table tblAuftraege 
        add constraint FK_97EA931B 
        foreign key (idProjekt) 
        references tblProjekte

    alter table tblAuftraege 
        add constraint FK_AF26A49A 
        foreign key ([idAuftrag]) 
        references tblProjekte

    alter table tblPDFs 
        add constraint FK_515AFA3C 
        foreign key (auftrag) 
        references tblAuftraege

    alter table tblPDFs 
        add constraint FK_B7D36CB2 
        foreign key (anschreibenTyp) 
        references tblAnschreibenTyp

    alter table tblPDFs 
        add constraint FK_BD12165A 
        foreign key (empfaenger) 
        references tblAnsprechpartner

    alter table tblPDFs 
        add constraint FK_E422AE6E 
        foreign key (absender) 
        references tblBearbeiter

    alter table tblPDFs 
        add constraint FK_D8AD87AD 
        foreign key (ansprechpartner) 
        references tblBearbeiter

    alter table tblPDFs 
        add constraint FK_15595A9A 
        foreign key (ansprechpartnerBau) 
        references tblAnsprechpartner

    alter table tblPDFs 
        add constraint FK_419D9A5C 
        foreign key (wesiTeam) 
        references tblWesiTeam

    alter table tblZusatzanlagen 
        add constraint FK_11D7A606 
        foreign key (idPDF) 
        references tblPDFs

    alter table tblZusatzanlagen 
        add constraint FK_7C0DB9B5 
        foreign key ([id]) 
        references tblPDFs
