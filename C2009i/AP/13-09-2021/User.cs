using System;
namespace _13_09_2021
{
    public class User
    {
        //C# style - recommend
        private String fullName; //field = variable
        private String email;
        private String phoneNumber;
        private DateTime dateOfBirth;
        //private int age;//NO, not neccessary !

        //getter like "calculated property"
        public int Age {
            get {
                Console.WriteLine("haha");
                return DateTime.Now.Year - dateOfBirth.Year;
            }
        }
        public DateTime DateOfBirth {
            set {
                dateOfBirth = value;
            }
            get {
                return dateOfBirth;
            }
        }

        //getter, setter is Function!
        //property = function
        public String FullName {
            get {
                return fullName;
            }
            set {
                fullName = value;
            }
        }
        public String Email
        {
            get
            {
                Console.WriteLine("This is getter");
                return email;
            }
            set
            {
                Console.WriteLine("This is setter");
                email = value;
            }
        }
        public String PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
        //NO need constructor
        public override string ToString() =>
            $"name = {this.fullName}," +
            $", email = {email}, " +
            $", phoneNumber = {phoneNumber}";
    }
}
