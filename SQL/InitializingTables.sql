--DROP TABLE  if Exists Employee
--DROP Table if Exists EmployeeSkill
--DROP Table if Exists  Skill
--DROP TABLE  if Exists Person

--CREATE TABLE Person (
--	Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
--	First_Name varchar(255) NOT NULL,
--	Last_Name varchar(255) NOT NULL,
--	Middle_Name varchar(255),
--	Phone_Number varchar(255) NOT NULL,
--	Email varchar(255),

--);

--CREATE TABLE Skill(
--	Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
--	Name varchar(255) NOT NULL
--);


--CREATE TABLE EmployeeSkill (
--	Person_Id int NOT NULL,
--	Skill_Id int NOT NULL,
--	FOREIGN KEY (Person_Id) REFERENCES Person(Id),
--	FOREIGN KEY (Skill_Id) REFERENCES Skill(Id),
--    UNIQUE (Skill_Id, Person_Id) -- Ensure unique combinations of Skill_Id and PersonId
--);


--CREATE TABLE Employee(
--	Person_Id int,
--	Start_Date Date NOT NULL DEFAULT getDate(),
--	End_Date Date,
--	Active BIT NOT NULL default 1,
--	FOREIGN KEY (Person_Id) REFERENCES Person(Id),
--);

--CREATE TABLE Customer(
--	Person_Id int,
--	FOREIGN KEY (Person_Id) REFERENCES Person(Id),
--);

---- INITIAL DATA INSERTS
INSERT INTO Person(First_Name, Last_Name, Phone_Number)
VALUES
('Sam','Lopez','1255555559'),
('Jenn','House','1355555559'),
('Jo','Sh','1555555559');

INSERT INTO Skill(Name)
Values('Hair'), ('Mani'), ('Pedi')

INSERT INTO Employee(Person_Id)
VALUES (1),(2)

INSERT INTO Customer(Person_Id)
VALUES(3);

---- IN PROGRESS (INSERT EMPLOYEE with SKILLS - use SELECT INSERT)
INSERT INTO EmployeeSkill(person_id, skill_id)
VALUES
(1, 1),
(1, 2),
(3, 1)
-- ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

-- Queries
SELECT *
FROM Person

SELECT *
FROM employee

select * from skill

select * from employeeskill

SELECT * FROM person p
JOIN EmployeeSkill es ON p.Id = es.Person_Id
JOIN Skill s ON s.Id = es.Skill_Id

