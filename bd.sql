create database boiteMessages
use boiteMessages

create table msg(
id smallint identity Primary key,
titre varchar(100),
corps varchar(2000),
imp smallint default 0,
lu smallint default 0,
supp smallint default 0,
datee datetime,
emailOrigin varchar(40) references log_in(email),
emailExp varchar(40) references log_in(email),
emailDes varchar(40) references log_in(email)
)

create table log_in(
email varchar(40) primary key,
mdpss varchar(30),
username varchar(30),
naissance datetime,
derniereCon datetime,
dateCreation datetime
)

create table connexion( 
ID int identity primary key,
etat varchar(20) default 'deconnecté',
Dureé varchar(20),
DebutSession datetime,
FinSession datetime,
email varchar(40) references log_in(email)
)

drop table log_in
drop table connexion
drop table msg

insert into log_in values('el@gmail.com','123456','chou500','01/01/1999', null, GETDATE())
insert into log_in values('aa@hotmail.com','123456','Rifi','01/01/1999', null, GETDATE())


insert into msg values('Salam','afin asahbi labas elik',0,0,0,getdate(),'el@gmail.com','el@gmail.com','aa@hotmail.com')
insert into msg values('Salam','afin asahbi labas elik',0,0,0,getdate(),'aa@hotmail.com','aa@hotmail.com','el@gmail.com')


select * from log_in
select * from connexion
select * from msg

delete connexion
delete msg
delete log_in

create Trigger doublerMessage
on msg
after insert
as
	begin
		declare @id smallint = (select id from inserted)
		declare @titre varchar(100) = (select titre from inserted)
		declare @corps varchar(2000) = (select corps from inserted)
		declare @imp smallint = (select imp from inserted)
		declare @lu smallint = (select lu from inserted)
		declare @supp smallint = (select supp from inserted)
		declare @datee datetime = (select datee from inserted)
		declare @emailOrigin varchar(40) = (select emailDes from inserted)
		declare @emailExp varchar(40) = (select emailExp from inserted)
		declare @emailDes varchar(40) = (select emailDes from inserted)
		insert into msg values(@titre,@corps,@imp,@lu,@supp,@datee,@emailOrigin,@emailExp,@emailDes)
	end