IF EXISTS (SELECT * FROM  sysobjects WHERE name='Departments' and xtype='U')
BEGIN
	INSERT INTO Departments(Financing,name)
	VALUES(13299,'IDK')

	INSERT INTO Departments(Financing,name)
	VALUES(13299,'DIK')

	INSERT INTO Departments(Financing,name)
	VALUES(13299,'DKI')

	INSERT INTO Departments(Financing,name)
	VALUES(13299,'IKD')
END

IF EXISTS (SELECT * FROM  sysobjects WHERE name='Faculties' and xtype='U')
BEGIN
	INSERT INTO Faculties(name,Dean)
	VALUES('Puio','Pro100')

	INSERT INTO Faculties(name,Dean)
	VALUES('Jupl','4EPRO100')

	INSERT INTO Faculties(name,Dean)
	VALUES('Efkg','RANDOM')

	INSERT INTO Faculties(name,Dean)
	VALUES('Potlot','DRIPLA')
END

IF EXISTS (SELECT * FROM  sysobjects WHERE name='Groups' and xtype='U')
BEGIN
	INSERT INTO Groups(name,raiting,_year)
	VALUES('10701321',4,4)

	INSERT INTO Groups(name,raiting,_year)
	VALUES('10701221',3,2)

	INSERT INTO Groups(name,raiting,_year)
	VALUES('10701121',2,1)

	INSERT INTO Groups(name,raiting,_year)
	VALUES('10701421',1,1)
END

IF EXISTS (SELECT * FROM  sysobjects WHERE name='Teachers' and xtype='U')
BEGIN
	INSERT INTO Teachers(EmploymentDate,isAssistant,isProfessor,name,position,premium,salary,surname)
	VALUES('2020-01-01T10:00:00',0,1,'Vika','St.Teacher',476,999,'Kit')

	INSERT INTO Teachers(EmploymentDate,isAssistant,isProfessor,name,position,premium,salary,surname)
	VALUES('2019-07-01T19:00:00',1,0,'Dima','Teacher',476,1019,'Kit')

	INSERT INTO Teachers(EmploymentDate,isAssistant,isProfessor,name,position,premium,salary,surname)
	VALUES('2022-01-08T15:30:00',0,1,'Loli','St.Teacher',999,999,'Lips')

	INSERT INTO Teachers(EmploymentDate,isAssistant,isProfessor,name,position,premium,salary,surname)
	VALUES('2021-09-01T10:00:00',1,0,'Shasha','Teacher',100,234,'Lips')
END


