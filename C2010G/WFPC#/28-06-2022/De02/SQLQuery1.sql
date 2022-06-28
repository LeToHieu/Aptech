CREATE TABLE tblUser(
	id INT IDENTITY(1, 1),
	userName NVARCHAR(100) NOT NULL,
	password NVARCHAR(100) NOT NULL
);
INSERT INTO tblUser(userName, password) VALUES
('admin', 'admin');
SELECT * FROM tblUser;