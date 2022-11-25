SELECT * FROM Departments
ORDER BY id DESC;
SELECT  name as [Group Name],raiting as [Group Raiting] FROM Groups;
SELECT surname,(salary/premium)*100 as [S%P], (salary/(premium+salary))*100 as [S%P+S]  FROM Teachers ;
SELECT surname FROM Teachers WHERE isProfessor=1 and salary>1050;
SELECT name FROM Departments WHERE Financing<11000 or Financing>25000
SELECT name FROM Faculties WHERE name!='Computer Science';
SELECT name,position FROM Teachers WHERE isProfessor=0;
SELECT name,position,salary,premium FROM Teachers WHERE isProfessor=0 and (premium between 160 and 550);
SELECT name,salary FROM Teachers WHERE isProfessor=0 ;
SELECT surname,position FROM Teachers WHERE EmploymentDate<'2000-01-01' ;
SELECT name AS [Name of Department]
FROM Departments 
WHERE name<'Software Development'
ORDER BY name desc;

SELECT surname FROM Teachers WHERE isProfessor=0 and salary+premium<1200;
SELECT name FROM Groups WHERE _year=5 and raiting between 2 and 4;
SELECT surname FROM Teachers WHERE isProfessor=0 and (salary>550 or premium<200);