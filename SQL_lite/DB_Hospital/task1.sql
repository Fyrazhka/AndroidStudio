IF EXISTS (SELECT * FROM  sysobjects WHERE name='Departments' and xtype='U')
BEGIN
	INSERT INTO Departments(building,Financing,_Floor,name)
	VALUES(1,13299,4,'IDK')

	INSERT INTO Departments(building,Financing,_Floor,name)
	VALUES(2,13299,3,'DIK')

	INSERT INTO Departments(building,Financing,_Floor,name)
	VALUES(3,13299,2,'DKI')

	INSERT INTO Departments(building,Financing,_Floor,name)
	VALUES(4,13299,1,'IKD')
END

IF EXISTS (SELECT * FROM  sysobjects WHERE name='Diseases' and xtype='U')
BEGIN
	INSERT INTO Diseases(name,severity)
	VALUES('Puio',1)

	INSERT INTO Diseases(name,severity)
	VALUES('Jupl',2)

	INSERT INTO Diseases(name,severity)
	VALUES('Efkg',3)

	INSERT INTO Diseases(name,severity)
	VALUES('Potlot',4)
END

IF EXISTS (SELECT * FROM  sysobjects WHERE name='Doctors' and xtype='U')
BEGIN
	INSERT INTO Doctors(name,phone,premium,salary,surname)
	VALUES('Vika',1329967,476,999,'Kit')

	INSERT INTO Doctors(name,phone,premium,salary,surname)
	VALUES('Dima',7829167,476,1019,'Kit')

	INSERT INTO Doctors(name,phone,premium,salary,surname)
	VALUES('Loli',1111111,999,999,'Lips')

	INSERT INTO Doctors(name,phone,premium,salary,surname)
	VALUES('Shasha',2222222,0,234,'Lips')
END

IF EXISTS (SELECT * FROM  sysobjects WHERE name='Examinations' and xtype='U')
BEGIN
	INSERT INTO Examinations(_dayOfweek,starttime,endtime,name)
	VALUES(1,'08:00:00','09:00:00','X-RAY')

	INSERT INTO Examinations(_dayOfweek,starttime,endtime,name)
	VALUES(2,'11:00:00','19:00:00','SHOWER')

	INSERT INTO Examinations(_dayOfweek,starttime,endtime,name)
	VALUES(4,'08:00:00','10:00:00','RUN')

	INSERT INTO Examinations(_dayOfweek,starttime,endtime,name)
	VALUES(6,'14:00:00','14:30:00','X-RAY')
END

IF EXISTS (SELECT * FROM  sysobjects WHERE name='Wards' and xtype='U')
BEGIN
	INSERT INTO Wards(building,_Floor,name)
	VALUES(1,1,'Number one')

	INSERT INTO Wards(building,_Floor,name)
	VALUES(2,2,'Number two')

	INSERT INTO Wards(building,_Floor,name)
	VALUES(3,3,'Number three')

	INSERT INTO Wards(building,_Floor,name)
	VALUES(4,4,'Number four')
END