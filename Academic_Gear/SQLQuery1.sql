
CREATE DATABASE AcademicGearDB;
GO

USE AcademicGearDB;
GO

CREATE TABLE tblLogin
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(50) NOT NULL,
    Role VARCHAR(20) NOT NULL
);
GO

-- Admin Account
INSERT INTO tblLogin (Username, Password, Role)
VALUES ('admin', 'admin123', 'Admin');

-- Cashier Account
INSERT INTO tblLogin (Username, Password, Role)
VALUES ('cashier', 'cashier123', 'Cashier');

-- View Accounts
SELECT * FROM tblLogin;
