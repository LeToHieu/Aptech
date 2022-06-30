using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
CREATE TABLE tblUser(
	id INT PRIMARY KEY IDENTITY(1, 1),
	userName NVARCHAR(100) NOT NULL,
    password NVARCHAR(100) NOT NULL,
);
INSERT INTO tblUser(className, studentName, userName, password, address) VALUES
('C2010G','Nguyen van X', 'admin', 'admin', 'street A, Hanoi'),
('A1908G','rdndhfuf hu','hoangnd', 'hoangnd', 'dmsiftreet A, Hanoi'),
('N2100F','rdndhfuf hu','luannc', 'luannc', 'somewhere B, Hanoi');


className, studentName, address
ALTER TABLE tblUser ADD  className NVARCHAR(50);
ALTER TABLE tblUser ADD studentName NVARCHAR(100);
ALTER TABLE tblUser ADD address TEXT;
SELECT * FROM tblUser;

*/
namespace De02.Models
{
    public class User
    {
        public int id { get; set; }
        public String studentName { get; set; }
        public String username { get; set; }
        public String className { get; set; }
        public String password { get; set; }
        public String address { get; set; }
    }
}
