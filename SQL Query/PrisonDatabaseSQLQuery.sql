CREATE DATABASE PrisonDatabase
use PrisonDatabase

select * from AppUser

use master
drop database PrisonDatabase


Create table Cell
(cellNo int PRIMARY KEY,
floor int not null,
blockNo int not null)

CREATE TABLE Guard(
guardNo int PRIMARY KEY IDENTITY,
fname varchar(25) not null,
lname varchar(25) not null,
dateOfBirth DATE not null,
phoneNo varchar(25) not null,
address varchar(100),
email varchar(100) not null,
blockNo int not null,
userId int not null
)

drop table Prisoner

CREATE TABLE Prisoner(
prisonerNo int PRIMARY KEY IDENTITY, 
fName varchar(25) not null, 
lName varchar(25) not null, 
dateOfBirth DATE not null, 
phoneNo varchar(25) unique,
address varchar(100), 
email varchar(100), 
dateIn DATE not null, 
dateOut DATE, 
cellNo int not null
)

CREATE TABLE Block(
blockNo int PRIMARY KEY,  
blockType varchar(25) not null)

CREATE TABLE Treatment(
doctorNo int, 
prisonerNo int, 
dateOfTreatment DATE not null, 
timeOfTreatment TIME not null, 
diagnosis varchar(255) not null, 
PRIMARY KEY(doctorNo, prisonerNo, dateOfTreatment)) 

CREATE TABLE Visitor(
visitorNo int PRIMARY KEY IDENTITY, 
fName varchar(25) not null, 
lName varchar(25) not null, 
dateOfBirth DATE not null, 
phoneNo varchar(25), 
address varchar(100),
) 

CREATE TABLE Doctor(
doctorNo int PRIMARY KEY IDENTITY, 
fName varchar(25) not null, 
lName varchar(25) not null, 
dateOfBirth DATE not null, 
phoneNo varchar(25) not null, 
address varchar(100), 
email varchar(100) unique not null,
userId int not null
)

create table Reception(
	receptionNo int primary key identity,
	fName varchar(25) not null,
	lName varchar(25) not null,
	dateOfBirth Date not null,
	phoneNo varchar(25) not null,
	address varchar(100),
	email varchar(100) not null,
	userId int not null
)

CREATE TABLE PrisonerCase(
caseNo int PRIMARY KEY, 
crimeType varchar(25) not null, 
dateOfCrime DATE not null, 
dateOfCaseClosed DATE, 
prisonerNo int not null, 
yearDecided int)

CREATE TABLE Visit(
visitorNo int,
prisonerNo int, 
dateOfVisit DATE not null, 
timeOfVisit TIME not null, 
PRIMARY KEY(visitorNo, prisonerNo, dateOfVisit))

ALTER TABLE Prisoner
ADD CONSTRAINT FK_PCELL
FOREIGN KEY (cellNo) references Cell(cellNo)

ALTER TABLE Guard
ADD CONSTRAINT FK_GBLOCK
FOREIGN KEY (blockNo) references Block(blockNo)

ALTER TABLE PrisonerCase
ADD CONSTRAINT FK_PCASE
FOREIGN KEY(prisonerNo) references Prisoner(prisonerNo)

ALTER TABLE Cell
ADD CONSTRAINT FK_CBLOCK
FOREIGN KEY (blockNo) references Block(blockNo)

ALTER TABLE Visit
ADD CONSTRAINT FK_VNO
FOREIGN KEY(visitorNo) references Visitor(visitorNo)

ALTER TABLE Visit
ADD CONSTRAINT FK_VPRISONER
FOREIGN KEY(prisonerNo) references Prisoner(prisonerNo)

ALTER TABLE Treatment
ADD CONSTRAINT FK_TDOCTOR
FOREIGN KEY(doctorNo) references Doctor(doctorNo)

ALTER TABLE Treatment
ADD CONSTRAINT FK_TPRISONER
FOREIGN KEY(prisonerNo) references Prisoner(prisonerNo)

alter table Doctor
add constraint fk_doctorUser
foreign key(userId) references AppUser(id)

alter table Guard
add constraint fk_guardUser
foreign key(userId) references AppUser(id)

alter table Reception
add constraint fk_receptionUser
foreign key(userId) references AppUser(id)

CREATE INDEX ix_Pcell
ON Prisoner(cellNo)

CREATE INDEX ix_Gblock
ON Guard(blockNo)

CREATE INDEX ix_CasePrisoner
ON PrisonerCase(prisonerNo)

CREATE INDEX ix_CBlock
ON Cell(blockNo)

DROP VIEW ReceptionsInfo


CREATE VIEW [GuardsInfo]
AS
SELECT 
	G.guardNo, 
	G.fname as FirstName,
	G.lname as LastName,
	G.dateOfBirth, 
	G.phoneNo, 
	G.address, 
	G.email, 
	G.blockNo,
	U.userName
From Guard as G 
join AppUser as U
on G.userId = U.id



create view [DoctorsInfo]
as
select
	D.doctorNo,
	D.fName as FirstName,
	D.lName as LastName,
	D.dateOfBirth,
	D.phoneNo,
	D.address,
	D.email,
	U.userName
from Doctor as D
join AppUser as U
on D.userId = U.id

create view [VisitorsInfo]
as 
select
	vr.visitorNo,
	vr.fName,
	vr.lName,
	vr.dateOfBirth, 
	vr.phoneNo,
	vr.address,
	Count(vt.visitorNo) as numberOfVisits
from Visitor as vr
left join Visit as vt
on vr.visitorNo = vt.visitorNo
Group by
	vr.visitorNo,
	vr.fName,
	vr.lName,
	vr.dateOfBirth, 
	vr.phoneNo,
	vr.address


create view [ReceptionsInfo]
as 
select
	R.receptionNo,
	R.fName as FirstName,
	R.lName as LastName,
	R.dateOfBirth,
	R.phoneNo,
	R.address,
	R.email,
	U.userName
from Reception as R
join AppUser as U
on R.userId = U.id


DROP VIEW PrisonersInfo

CREATE VIEW PrisonersInfo
AS
SELECT p.prisonerNo, 
	p.fName,
	p.lName,
	p.dateOfBirth, 
	p.phoneNo, 
	p.address, 
	p.email, 
	p.dateIn, 
	p.dateOut,
	p.cellNo,
	COUNT(c.caseNo) as numberOfCases
FROM Prisoner as p
LEFT JOIN PrisonerCase as c on c.prisonerNo = p.prisonerNo
GROUP BY 
	p.prisonerNo,
	p.fName,
	p.lName,
	p.dateOfBirth,
	p.phoneNo, 
	p.address, 
	p.email, 
	p.dateIn, 
	p.dateOut,
	p.cellNo

CREATE VIEW BlocksInfo
AS
SELECT 
	b.blockNo, 
	blockType, 
	COUNT(c.cellNo) as numberOfCells,
	COUNT(p.prisonerNo) as numberOfPrisoners,
	COUNT(DISTINCT c.floor) as numberOfFloors
FROM Block as b
JOIN Cell as c on c.blockNo = b.blockNo
JOIN Prisoner as p on p.cellNo = c.cellNo
GROUP BY b.blockNo, b.blockType


CREATE VIEW DoctorsView
AS
SELECT 
	p.prisonerNo as PrisonerNumber,
	p.fName as PrisonerFirstName,
	p.lName as PrisonerLastName,
	t.dateOfTreatment,
	t.timeOfTreatment,
	d.doctorNo as DoctorNumber,
	d.fName as DoctorFirstName,
	d.lName as DoctorLastName,
	t.diagnosis
FROM Treatment as t
JOIN Prisoner as p on t.prisonerNo = p.prisonerNo
JOIN Doctor as d on d.doctorNo = t.doctorNo


DROP VIEW ReceptionsView

CREATE VIEW ReceptionsView
AS
SELECT
	v.visitorNo as VisitorNumber,
	v.fName as VisitorFirstName,
	v.lName as VisitorLastName,
	v.address as VisitorAddress,
	v.phoneNo as VisitorPhoneNumber,
	p.prisonerNo as PrisonerNumber,
	p.fName as PrisonerFirstName,
	p.lName as PrisonerLastName,
	vi.dateOfVisit,
	vi.timeOfVisit
FROM Visit as vi
LEFT JOIN Visitor as v on v.visitorNo = vi.visitorNo
LEFT JOIN Prisoner as p on p.prisonerNo = vi.prisonerNo

create VIEW CasesInfo
AS
SELECT 
	c.caseNo,
	p.prisonerNo,
	CONCAT(p.fname, ' ', p.lname) as DefendantName,
	c.crimeType,
	c.dateOfCrime,
	c.dateOfCaseClosed,
	c.yearDecided
FROM PrisonerCase as c
JOIN Prisoner as p on c.prisonerNo = p.prisonerNo


-- Sample Data

INSERT INTO Block VALUES
(1, 'Minimum Security'),
(2, 'Medium Security'),
(3, 'Minimum Security'),
(4, 'Maximum Security'),
(5, 'Medium Security')
select * from Block

INSERT INTO Cell Values
(101, 0 , 1),
(102, 0, 1),
(103, 0, 1),
(111, 1, 1),
(112, 1, 1),
(113, 1, 1),
(201, 0, 2),
(202, 0, 2),
(211, 1, 2),
(212, 1, 2),
(221, 2, 2),
(301, 0, 3),
(302, 0, 3),
(311, 1, 3),
(312, 1, 3),
(321, 2, 3),
(331, 3, 3)

INSERT INTO Prisoner VALUES
('Abebe', 'Belayneh', '1985-11-04', '+251911454888', 'Lebu M/Hail', 'abebel@yahoo.com', '2011-12-15', '2021-12-15', 201),
('Mulugeta', 'Belachew', '1990-01-04', '+251912481966', 'Arat Kilo', 'mulugetabe@yahoo.com', '2011-07-05', '2021-07-05', 111),
('Bekele', 'Abebaw', '1987-11-04', '+251947525559', 'Bole Michael', 'Bekele21@yahoo.com', '2020-09-21', '2030-09-21', 221),
('Tariku', 'Asfaw', '1986-11-04', '+251915447859', ' - ', null, '2020-12-15', '2025-12-15', 103),
('Gedlu', 'Bizuneh', '1975-11-04', '+251926554811', 'Jemo', null, '2015-11-15', '2022-11-15', 101),
('Abrham', 'Belayneh', '1995-11-04', '+251927447855', 'Kazanchis', null, '2016-02-05', '2025-02-05', 212),
('Ketema', 'Sintayehu', '1989-11-04', '+251933696674', 'Lideta', 'ketemasint@gmail.com', '2010-12-15', null, 211),
('Chala', 'Gemechu', '1992-11-04', '+251911454888', 'Mercato', null, '2005-11-15', '2015-11-15', 301)

INSERT INTO Guard VALUES
('Jemal', 'Kerim', '1984-09-25', '+251911789588', 'Sarbet', 'jemalkerim99@gmail.com', 1),
('Seifu', 'Bekele', '1974-09-25', '+251978447821', 'Piassa', 'swordgrew@gmail.com', 2),
('Tamrat', 'Layne', '1979-09-25', '+251994112374', 'Kolfe', 'tametame@gmail.com', 3)

INSERT INTO Visitor VALUES
('Fasil', 'Abreha',  '1984-09-25', '+251911789588', 'Sarbet'),
('Yenenesh', 'Molla', '1974-09-25', '+251978447821', 'Piassa'),
('Tafese', 'Dawit', '1979-09-25', '+251994112374', 'Kolfe')

INSERT INTO Doctor VALUES
('Ketema', 'Sintayehu', '1989-11-04', '+251933696674', 'Lideta', 'ketemasint@gmail.com', 151),
('Chala', 'Gemechu', '1992-11-04', '+251911454888', 'Mercato', 'drchalagemeche@yahoo.com',151)

INSERT INTO PrisonerCase VALUES
(' 11570','Grand Larceny', '2017-05-11', '2018-01-20', 1, 2018),
(' 11571','Armed Robbery', '2017-05-11', '2018-01-20', 2, 2018),
(' 11572','First Degree Murder', '2017-05-11', '2018-01-20', 3, 2018),
(' 11574','Arson', '2017-05-11', '2018-01-20', 3, 2018),
(' 11575','Rape', '2017-05-11', '2018-01-20', 4, 2018),
(' 11577','Double Homicide', '2017-05-11', '2018-01-20', 5, 2018),
(' 11580','Armed Robbery', '2017-05-11', '2018-01-20', 6, 2018),
(' 11581','Assault and Battery', '2017-05-11', '2018-01-20', 7, 2018),
(' 11585','Fraud', '2017-05-11', '2018-01-20', 8, 2018),
(' 11590','Shoplifting', '2017-05-11', '2018-01-20', 8, 2018)

INSERT INTO Visit VALUES
(1, 1, '2021-05-22', '14:30'),
(2, 2, '2021-05-22', '15:00'),
(3, 2, '2021-05-23', '14:00')

select *from Visitor
delete from Visitor
where visitorNo > 3

INSERT INTO Treatment VALUES
(12, 5, '2021-06-14', '21:00', 'Broken Rib and Pelvic Bone'),
(13, 7, '2021-06-14',  '20:30', 'Stab Wound')


--Application User

create table AppUser
(
	id int identity(101, 1) primary key,
	userName nvarchar(50) not null unique,
	password nvarchar(50) not null,	
	role varchar(50) not null
)

drop table AppUser

alter table AppUser
add constraint chk_UserRole
check(role in('Administrator', 'Doctor', 'Guard', 'Reception'))

select * from Prisoner


create proc spLogin
	@userName nvarchar(50),
	@password nvarchar(50)
as
begin
	select role from AppUser
	where @userName = userName and @password = password
end

create proc spAddUser
	@userName nvarchar(50),
	@password nvarchar(50),
	@role varchar(40)
as
begin
	insert into AppUser values
	(@userName, @password, @role)
end

create proc spGetId
	@userName nvarchar(50)
as
begin
	select id from AppUser
	where userName = @userName
end


create proc spCountUsers
as
begin
	select COUNT(id) as numberOfUsers from AppUser
end

create proc spGetBlocks
as
begin
	select blockNo from Block
end

create proc spGetCells
as 
begin
	select cellNo from Cell
end

create proc spAddReception	
	@firstName varchar(25),
	@lastName varchar(25),
	@dateOfBirth Date,
	@phoneNumber varchar(25),
	@address varchar(100),
	@email varchar(100),
	@userId int
as
begin
	insert into Reception values
	(@firstName, @lastName,@dateOfBirth, @phoneNumber, @address, @email, @userId)
end

create proc spAddDoctor	
	@firstName varchar(25), 
	@lastName varchar(25), 
	@dateOfBirth Date, 
	@phoneNumber varchar(25),
	@address varchar(100), 
	@email varchar(100),
	@userId int
as
begin
	insert into Doctor values
	(@firstName, @lastName, @dateOfBirth, @phoneNumber, @address, @email, @userId)
end

create proc spAddGuard	
	@firstName varchar(25),
	@lastName varchar(25),
	@dateOfBirth DATE,
	@phoneNumber varchar(25),
	@address varchar(100),
	@email varchar(100),
	@blockNo int,
	@userId int
as
begin
	insert into Guard values
	(@firstName, @lastName, @dateOfBirth, @phoneNumber, @address, @email, @blockNo, @userId)
end

create proc spAddPrisoner
	@firstName varchar(25),
	@lastName varchar(25),
	@dateOfBirth Date,
	@phoneNumber varchar(25),
	@address varchar(25),
	@email varchar(25),
	@dateIn Date,
	@cellNo int
as
begin
	insert into Prisoner (fName, lName, dateOfBirth,phoneNo,address,email,dateIn,cellNo) values
	(@firstName,@lastName,@dateOfBirth, @phoneNumber, @address, @email, @dateIn, @cellNo)	
end

create proc spAddPrisonerCase
	@caseNo int,
	@crimeType varchar(25),
	@dateOfCrime date,
	@dateOfVerdict date,
	@prisonerNo int,
	@yearsDecided int
as
begin
	insert into PrisonerCase values
	(@caseNo, @crimeType, @dateOfCrime, @dateOfVerdict, @prisonerNo, @yearsDecided)
end

create proc spAddTreatment
	@prisonerNo int,
	@doctorNo int,
	@dateOfTreatment date,
	@timeOfTreatment time,
	@diagnosis varchar(100)
as
begin
	insert into Treatment values
	(@doctorNo, @prisonerNo, @dateOfTreatment, @timeOfTreatment, @diagnosis)
end

create proc spAddVisitor
	@firstName varchar(25),
	@lastName varchar(25),
	@dateOfBirth date,
	@phoneNumber varchar(25),
	@address varchar(100)
as
begin
	insert into Visitor values
	(@firstName, @lastName, @dateOfBirth, @phoneNumber,@address)	
end

create proc spAddVisit
	@prisonerNo int,
	@visitorNo int,
	@dateOfVisit date,
	@timeOfVisit time
as
begin
	insert into Visit values
	(@visitorNo, @prisonerNo, @dateOfVisit, @timeOfVisit)
end


create proc spGetLastPrisoner
as
begin
	select MAX(prisonerNo) as prisonerId from Prisoner 
end

create proc spGetLastVisitor
as
begin
	select MAX(visitorNo) as visitorId from Visitor
end

create proc spViewAllGuards
as
begin
	select * from [GuardsInfo]
end

create proc spViewAllDoctors
as 
begin
	select * from [DoctorsInfo]
end

create proc spViewAllReceptions
as
begin
	select * from [ReceptionsInfo]
end

create proc spViewAllVisitors
as
begin
	select * from [VisitorsInfo]
end

create proc spViewAllTreatments
as
begin
	select * from DoctorsView
end

create proc spViewAllVisits
as
begin
	select * from ReceptionsView
end

create proc spViewPrisonerCase
	@prisonerNo int
as
begin
	select * from CasesInfo as C
	where C.prisonerNo = @prisonerNo	
end


create proc spDeleteReception
	@receptionNo int
as
begin
	delete from Reception
	where receptionNo = @receptionNo
end

create proc spDeleteDoctor
	@doctorNo int
as 
begin
	delete from Doctor
	where doctorNo = @doctorNo
end

create proc spDeletePrisoner
	@prisonerNo int
as 
begin
	delete from Prisoner
	where prisonerNo = @prisonerNo
end

create proc spSearchDoctorById
	@doctorNo int
as
begin
	select 
		D.doctorNo,
		D.fName as FirstName,
		D.lName as LastName,
		D.dateOfBirth,
		D.phoneNo,
		D.address,
		D.email,
		U.userName
	from Doctor as D
	join AppUser as U
	on D.userId = U.id
	where D.doctorNo = @doctorNo
end

create proc spSearchDoctor	
	@firstName varchar(25) = '',
	@lastName varchar(25) = '',
	@phoneNo varchar(25) = '',
	@email varchar(100) = ''
as
begin
	select 
		D.doctorNo,
		D.fName as FirstName,
		D.lName as LastName,
		D.dateOfBirth,
		D.phoneNo,
		D.address,
		D.email,
		U.userName
	from Doctor as D
	join AppUser as U
	on D.userId = U.id
	where D.fName like @firstName + '%'
		and D.lName like @lastName + '%'
		and D.phoneNo like @phoneNo + '%'
		and D.email like @email + '%'
end


create proc spSearchGuardById
	@guardNo int
as
begin
	select 
		G.guardNo,
		G.fname as FirstName,
		G.lname as LastName,
		G.dateOfBirth,
		G.phoneNo,
		G.address,
		G.email,
		U.userName
	from Guard as G
	join AppUser as U
	on G.userId = U.id
	where G.guardNo = @guardNo
end


create proc spSearchGuard	
	@firstName varchar(25) = '',
	@lastName varchar(25) = '',
	@phoneNo varchar(25) = '',
	@email varchar(100) = ''
as
begin
	select 
		G.guardNo,
		G.fname as FirstName,
		G.lname as LastName,
		G.dateOfBirth,
		G.phoneNo,
		G.address,
		G.email,
		U.userName
	from Guard as G
	join AppUser as U
	on G.userId = U.id
	where G.fName like @firstName + '%'
		and G.lName like @lastName + '%'
		and G.phoneNo like @phoneNo + '%'
		and G.email like @email + '%'
end

create proc spSearchReceptionById
	@receptionNo int
as
begin
	select 
		R.receptionNo,
		R.fName as FirstName,
		R.lName as LastName,
		R.dateOfBirth,
		R.phoneNo,
		R.address,
		R.email,
		U.userName
	from Reception as R
	join AppUser as U
	on R.userId = U.id
	where R.receptionNo = @receptionNo
end

create proc spSearchReception	
	@firstName varchar(25) = '',
	@lastName varchar(25) = '',
	@phoneNo varchar(25) = '',
	@email varchar(100) = ''
as
begin
	select 
		R.receptionNo,
		R.fName as FirstName,
		R.lName as LastName,		
		R.dateOfBirth,
		R.phoneNo,
		R.address,
		R.email,
		U.userName
	from Reception as R
	join AppUser as U
	on R.userId = U.id
	where R.fName like @firstName + '%'
		and R.lName like @lastName + '%'
		and R.phoneNo like @phoneNo + '%'
		and R.email like @email + '%'
end

create proc spDeleteGuard
	@guardNo int	
as
begin
	delete from Guard
	where guardNo = @guardNo
end


create proc spUpdateGuard
	@guardNo int,
	@firstName varchar(25),
	@lastName varchar(25),
	@dateOfBirth DATE,
	@phoneNumber varchar(25),
	@address varchar(100),
	@email varchar(100),
	@blockNo int
as
begin
	update Guard
	set fname = @firstName,
		lname = @lastName,
		dateOfBirth = @dateOfBirth,
		phoneNo = @phoneNumber,
		address = @address,
		email = @email,
		blockNo = @blockNo
	where guardNo = @guardNo
end

update Guard
set fname = 'Esrom Mulugeta',
	lname = 'Tadesse'
where guardNo = 3


select * from Guard

create proc spUpdateDoctor
	@doctorNo int,
	@firstName varchar(25),
	@lastName varchar(25),
	@dateOfBirth DATE,
	@phoneNumber varchar(25),
	@address varchar(100),
	@email varchar(100)
as
begin
	update Doctor
	set fname = @firstName,
		lname = @lastName,
		dateOfBirth = @dateOfBirth,
		phoneNo = @phoneNumber,
		address = @address,
		email = @email
	where doctorNo = @doctorNo
end

create proc spUpdateReception
	@receptionNo int,
	@firstName varchar(25),
	@lastName varchar(25),
	@dateOfBirth DATE,
	@phoneNumber varchar(25),
	@address varchar(100),
	@email varchar(100)
as
begin
	update Reception
	set fname = @firstName,
		lname = @lastName,
		dateOfBirth = @dateOfBirth,
		phoneNo = @phoneNumber,
		address = @address,
		email = @email
	where receptionNo = @receptionNo
end

create proc spUpdateTreatment
	@prisonerNo int,
	@doctorNo int,
	@dateOfTreatment date,
	@diagnosis varchar(100)
as
begin
	update Treatment 
	set diagnosis = @diagnosis
	where prisonerNo = @prisonerNo and
		doctorNo = @doctorNo and
		dateOfTreatment = @dateOfTreatment
end


create proc spDeleteUser
	@userId int
as
begin
	delete from AppUser
	where id = @userId;
end

create proc spDeleteTreatment
	@prisonerNo int
as
begin
	delete from Treatment 
	where prisonerNo = @prisonerNo
end

create proc spDeleteCase
	@prisonerNo int
as
begin
	delete from PrisonerCase
	where prisonerNo = @prisonerNo
end

create proc spDeleteVisitByPrisoner
	@prisonerNo int
as
begin
	delete from Visit
	where prisonerNo = @prisonerNo
end



create proc spDeleteVisit
	@prisonerNo int,
	@visitorNo int,
	@dateOfVisit date
as
begin
	delete from Visit
	where prisonerNo = @prisonerNo 
		and visitorNo = @visitorNo
		and dateOfVisit = @dateOfVisit
end

create proc spDeleteVisitor
	@visitorNo int
as 
begin
	delete from Visitor
	where visitorNo = @visitorNo
end

create proc spDeleteVisitByVisitor
	@visitorNo int
as
begin
	delete from Visit
	where visitorNo = @visitorNo
end

create proc spViewAllPrisoners
as
begin
	select * from PrisonersInfo
end

create proc spViewPrisonerTreatment
	@prisonerNo int
as
begin
	SELECT 
		p.prisonerNo as PrisonerNumber,
		p.fName as PrisonerFirstName,
		p.lName as PrisonerLastName,
		t.dateOfTreatment,
		t.timeOfTreatment,
		d.doctorNo as DoctorNumber,
		d.fName as DoctorFirstName,
		d.lName as DoctorLastName,
		t.diagnosis
	FROM Treatment as t
	LEFT JOIN Prisoner as p on t.prisonerNo = p.prisonerNo
	LEFT JOIN Doctor as d on d.doctorNo = t.doctorNo
	where t.prisonerNo = @prisonerNo
end

create proc spViewPrisonerVisit
	@prisonerNo int
as 
begin
	select
		v.visitorNo as VisitorNumber,
		v.fName as VisitorFirstName,
		v.lName as VisitorLastName,
		v.address,
		v.phoneNo,
		v.dateOfBirth,
		p.prisonerNo as PrisonerNumber,
		p.fName as PrisonerFirstName,
		p.lName as PrisonerLastName,
		vi.dateOfVisit,
		vi.timeOfVisit
	FROM Visit as vi
	LEFT JOIN Visitor as v on v.visitorNo = vi.visitorNo
	LEFT JOIN Prisoner as p on p.prisonerNo = vi.prisonerNo
	where vi.prisonerNo = @prisonerNo
end

create proc spViewVisitorVisit
	@visitorNo int
as
begin
	select
		v.visitorNo as VisitorNo,
		v.fName as VisitorFirstName,
		v.lName as VisitorLastName,
		p.prisonerNo as PrisonerNumber,
		p.fName as PrisonerFirstName,
		p.lName as PrisonerLastName,
		vi.dateOfVisit,
		vi.timeOfVisit
	FROM Visit as vi
	LEFT JOIN Visitor as v on v.visitorNo = vi.visitorNo
	LEFT JOIN Prisoner as p on p.prisonerNo = vi.prisonerNo
	where vi.visitorNo = @visitorNo		
end

create proc spSearchPrisonerById
	@prisonerNo int
as
begin
	SELECT 
		p.prisonerNo, 
		p.fName,
		p.lName,
		p.dateOfBirth, 
		p.phoneNo, 
		p.address, 
		p.email, 
		p.dateIn, 
		p.dateOut,
		p.cellNo,
		COUNT(c.caseNo) as numberOfCases
	FROM Prisoner as p
	LEFT JOIN PrisonerCase as c on c.prisonerNo = p.prisonerNo
	where p.prisonerNo = @prisonerNo
	GROUP BY 
		p.prisonerNo,
		p.fName,
		p.lName,
		p.dateOfBirth,
		p.phoneNo, 
		p.address, 
		p.email, 
		p.dateIn, 
		p.dateOut,
		p.cellNo
end

create proc spSearchPrisoner
	@firstName varchar(25) = '',
	@lastName varchar(25) = '',
	@phoneNo varchar(25) = '',
	@email varchar(100) = ''
as
begin
	SELECT p.prisonerNo, 
	p.fName,
	p.lName,
	p.dateOfBirth, 
	p.phoneNo, 
	p.address, 
	p.email, 
	p.dateIn, 
	p.dateOut,
	p.cellNo,
	COUNT(c.caseNo) as numberOfCases
FROM Prisoner as p
LEFT JOIN PrisonerCase as c on c.prisonerNo = p.prisonerNo
where p.fName like @firstName + '%'
		and p.lName like @lastName + '%'
		and p.phoneNo like @phoneNo + '%'
		and p.email like @email + '%'
GROUP BY 
	p.prisonerNo,
	p.fName,
	p.lName,
	p.dateOfBirth,
	p.phoneNo, 
	p.address, 
	p.email, 
	p.dateIn, 
	p.dateOut,
	p.cellNo
	
end

create proc spSearchVisitorById
	@visitorNo int
as
begin
	select
		vr.visitorNo,
		vr.fName,
		vr.lName,
		vr.dateOfBirth, 
		vr.phoneNo,
		vr.address,
		Count(vt.visitorNo) as numberOfVisits
	from Visitor as vr
	left join Visit as vt
	on vr.visitorNo = vt.visitorNo
	where vr.visitorNo = @visitorNo
	Group by
		vr.visitorNo,
		vr.fName,
		vr.lName,
		vr.dateOfBirth, 
		vr.phoneNo,
		vr.address
end

create proc spSearchVisitor
	@firstName varchar(25) = '',
	@lastName varchar(25) = '',
	@phoneNo varchar(25) = ''
as
begin
	select
		vr.visitorNo,
		vr.fName,
		vr.lName,
		vr.dateOfBirth, 
		vr.phoneNo,
		vr.address,
		Count(vt.visitorNo) as numberOfVisits
	from Visitor as vr	
	left join Visit as vt
	on vr.visitorNo = vt.visitorNo
	where vr.fName like @firstName + '%'
		and vr.lName like @lastName + '%'
		and vr.phoneNo like @phoneNo +'%'		
	Group by
		vr.visitorNo,
		vr.fName,
		vr.lName,
		vr.dateOfBirth, 
		vr.phoneNo,
		vr.address
end

create proc spSearchTreatmentByPrisonerNo
	@prisonerNo int
as
begin
	select * from DoctorsView as D
	where D.PrisonerNumber = @prisonerNo
end

create proc spSearchTreatmentByDoctorNo
	@doctorNo int
as
begin
	select * from DoctorsView as D
	where D.DoctorNumber = @doctorNo
end

create proc spSearchTreatment
	@prisonerFName varchar(25) = '',
	@prisonerLName varchar(25) = '',
	@doctorFName varchar(25) = '',
	@doctorLName varchar(25) = ''
as
begin
	select * from DoctorsView as D
	where D.DoctorFirstName like @doctorFName + '%' 
		and D.DoctorLastName like @doctorLName + '%'
		and D.PrisonerFirstName like @prisonerFName + '%'
		and D.PrisonerLastName like @prisonerLName + '%'
end

create proc spSearchVisitByPrisonerNo
	@prisonerNo int
as
begin
	select * from ReceptionsView as R
	where R.PrisonerNumber = @prisonerNo
end

create proc spSearchVisitByVisitorNo
	@visitorNo int
as
begin
	select * from ReceptionsView as R
	where R.VisitorNumber = @visitorNo
end

create proc spSearchVisit
	@prisonerFName varchar(25) = '',
	@prisonerLName varchar(25) = '',
	@visitorFName varchar(25) = '',
	@visitorLName varchar(25) = ''
as
begin
	select * from ReceptionsView as R
	where R.PrisonerFirstName like @prisonerFName + '%'
		and R.PrisonerLastName like @prisonerLName + '%'
		and R.VisitorFirstName like @visitorFName + '%'
		and R.VisitorLastName like @visitorLName + '%'
end

create proc spGetDoctorInfoByUser
	@userName nvarchar(50)
as
begin
	select D.doctorNo, D.fName, D.lName 
	from Doctor D
	join AppUser U
	on U.id = D.userId
	where U.userName = @userName
end

create proc spUpdateUser
	@oldUserName nvarchar(50),
	@newUserName nvarchar(50),
	@newPassword nvarchar(50)
as
begin
	update AppUser
	set userName = @newUserName,
		password = @newPassword
	where userName = @oldUserName
end

create proc spGetNumberOfPrisoners
as
begin
	select COUNT(prisonerNo) from Prisoner
end

create proc spGetNumberOfDoctors
as
begin
	select COUNT(doctorNo) from Doctor
end

create proc spGetNumberOfGuards
as
begin
	select COUNT(guardNo) from Guard
end

create proc spGetNumberOfReceptionists
as
begin
	select COUNT(receptionNo) from Reception
end

create proc spGetNumberOfVisitors
as
begin
	select COUNT(visitorNo) from Visitor
end

create proc spGetNumberOfTreatments
as
begin
	select COUNT(doctorNo) from Treatment
end

create proc spGetNumberOfVisits
as
begin
	select COUNT(visitorNo) from Visit
end

SP_Help AppUser


create role dbExecuteStoredProcedures

grant exec to dbExecutestoredProcedures

