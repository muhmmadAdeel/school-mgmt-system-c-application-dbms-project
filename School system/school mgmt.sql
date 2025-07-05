create database school_mgmt_sytem

create table Users (user_ID int identity,
Name varchar(50) null,
username nvarchar(100) not null,
Password nvarchar(100) not null)


create table student (student_id int primary key identity, student_name varchar(50),DOB nvarchar(50),gender char default 'M',phoneNo nvarchar(50),email nvarchar(50) unique not null)
create table course (course_id int primary key identity, course_name nvarchar(100), credit_h int)
INSERT INTO course (course_name, credit_h) 
VALUES 
('Introduction to Computer Science', 3),
('Database Systems', 4),
('Web Development Fundamentals', 3),
('Data Structures and Algorithms', 4),
('Software Engineering Principles', 3),
('Computer Networks', 4),
('Operating Systems', 4),
('Artificial Intelligence', 3),
('Mobile Application Development', 3),
('Cybersecurity Basics', 3);


create table course_assign(assignment_id int primary key identity,course_id int,foreign key (course_id) references course(course_id),student_id int , foreign key (student_id) references student(student_id))
CREATE TABLE teacher (teacher_id INT IDENTITY(1,1) PRIMARY KEY,teacher_name NVARCHAR(100) NOT NULL,gender CHAR(1) CHECK (gender IN ('M','F','O')) DEFAULT 'M',phone NVARCHAR(20),email NVARCHAR(100) UNIQUE NOT NULL);
CREATE TABLE enrollment (
    enrollment_id INT IDENTITY(1,1) PRIMARY KEY,
    student_id INT NOT NULL,
    course_id INT NOT NULL,
    enrollment_date DATETIME DEFAULT GETDATE(),
    grade CHAR(2) NULL,
    status VARCHAR(20) DEFAULT 'Active',
    CONSTRAINT FK_Enrollment_Student FOREIGN KEY (student_id) REFERENCES student(student_id),
    CONSTRAINT FK_Enrollment_Course FOREIGN KEY (course_id) REFERENCES course(course_id),
    CONSTRAINT UC_Enrollment UNIQUE (student_id, course_id)
);


CREATE TABLE attendance (
    AID INT IDENTITY(1,1) PRIMARY KEY,
    studentID INT NOT NULL,
    description VARCHAR(50),
    date DATE DEFAULT GETDATE(),
    CONSTRAINT FK_Attendance_Student FOREIGN KEY (studentID) REFERENCES student(student_id)
);

