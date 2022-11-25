SELECT * FROM  Wards;
SELECT surname,phone FROM Doctors;
SELECT _Floor FROM Wards GROUP BY _Floor;
SELECT name as [Name of Disease],
	   severity as [Severity of Disease]
FROM Diseases ;
SELECT name FROM Departments WHERE building=5 and Financing<30000;
SELECT name FROM Departments WHERE building=3 or building=6 and (Financing between 12000 and 15000);
SELECT name FROM Wards WHERE building=4 or building=5 and _Floor=1;
SELECT name,
	   building,
	   Financing
FROM Departments WHERE building=3 or building=6 and (Financing<11000 or Financing>25000);

SELECT surname From Doctors WHERE premium+salary>1500;
SELECT surname From Doctors WHERE salary/2>premium*3;
SELECT name FROM Examinations WHERE _dayOfweek<4 and (starttime between '12:00:00' and '15:00:00') GROUP BY name;
SELECT name,building FROM Departments WHERE building IN (1,3,8,10);
SELECT name FROm Diseases WHERE severity!=1 and severity!=2;
SELECT name FROM Departments WHERE building!=1 and building!=3;
SELECT name FROM Departments WHERE building=1 or building=3;
SELECT surname FROM Doctors WHERE surname LIKE 'N%';