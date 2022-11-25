CREATE TABLE Departments(
      id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  building int NOT NULL,
	  CHECK (building BETWEEN 1 and 5),
	  Financing MONEY DEFAULT 0 NOT NULL,
	  CHECK (Financing>=0),
	  _Floor INT NOT NULL,
	  CHECK (_FLoor>=1),
	  name nvarchar(100) NOT NULL  UNIQUE,

);
CREATE TABLE Diseases(
	id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	name nvarchar(100) NOT NULL UNIQUE,
	severity int NOT NULL DEFAULT 1,
	CHECK (severity>=1)
);




CREATE TABLE Doctors(
	id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	name nvarchar(max) NOT NULL,
	phone char(10),
	premium money NOT NULL DEFAULT 0,
	CHECK (premium>=0),
	salary money NOT NULL,
	CHECK (salary>0),
	surname nvarchar(max) NOT NULL,


);
CREATE TABLE Examinations(
	id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	_dayOfweek int NOT NULL,
	CHECK (_dayofweek BETWEEN 1 and 7),
	starttime time NOT NULL,
	check (starttime between '08:00:00' and '18:00:00'),
	endtime time NOT NULL,
	check (starttime<endtime),
	name nvarchar(100) NOT NULL

);
CREATE TABLE Wards(
	  id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  building int NOT NULL,
	  CHECK (building BETWEEN 1 and 5),
	  _Floor INT NOT NULL,
	  CHECK (_FLoor>=1),
	  name nvarchar(20) NOT NULL  UNIQUE
);
