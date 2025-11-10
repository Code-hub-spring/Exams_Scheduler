CREATE DATABASE ExamSchedulerDB;
USE ExamSchedulerDB;
GO

CREATE TABLE Courses (
    CourseID INT IDENTITY(1,1) PRIMARY KEY,
    CourseName VARCHAR(100) NOT NULL,
    Category VARCHAR(50) NOT NULL
);
GO

CREATE TABLE Rooms (
    RoomID INT IDENTITY(1,1) PRIMARY KEY,
    RoomName VARCHAR(50) NOT NULL UNIQUE,
    Capacity INT NOT NULL CHECK (Capacity > 0)
);
GO

CREATE TABLE Invigilators (
    InvigilatorID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Available BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE Students (
    StudentID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    HasSpecialNeeds BIT NOT NULL DEFAULT 0
);
GO

CREATE TABLE Exams (
    ExamID INT IDENTITY(1,1) PRIMARY KEY,
    CourseID INT NOT NULL FOREIGN KEY REFERENCES Courses(CourseID),
    ExamDate DATE NOT NULL,
    ExamTime TIME NOT NULL,
    DurationMinutes INT NOT NULL CHECK (DurationMinutes > 0),
    RoomID INT NULL FOREIGN KEY REFERENCES Rooms(RoomID),
    InvigilatorID INT NULL FOREIGN KEY REFERENCES Invigilators(InvigilatorID),
    SpecialNeeds BIT DEFAULT 0
);
GO




