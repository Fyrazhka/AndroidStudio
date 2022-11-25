CREATE TABLE Departments(
      id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	  Financing MONEY DEFAULT 0 NOT NULL,
	  CHECK (Financing>=0),	  
	  name nvarchar(100) NOT NULL  UNIQUE,
);
CREATE TABLE Faculties(
	id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	name nvarchar(100) NOT NULL UNIQUE,
	Dean nvarchar(max) NOT NULL , 
);

CREATE TABLE Groups(
	id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	name nvarchar(10) NOT NULL UNIQUE,
	raiting int NOT NULL,
	CHECK (raiting between 0 and 5),
	_year int NOT NULL,
	CHECK (_year between 1 and 5),


);
CREATE TABLE Teachers(
	id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	EmploymentDate date NOT NULL,
	CHECK (EmploymentDate>'1990-01-01'),
	isAssistant bit NOT NULL DEFAULT 0,
	isProfessor bit NOT NULL DEFAULT 0,
	name nvarchar(max) NOT NULL,
	position nvarchar(max) NOT NULL,
	premium money NOT NULL DEFAULT 0,
	CHECK(premium>0),
	salary money NOT NULL,
	CHECK(salary>=0),
	Surname nvarchar(max) NOT NULL
);
