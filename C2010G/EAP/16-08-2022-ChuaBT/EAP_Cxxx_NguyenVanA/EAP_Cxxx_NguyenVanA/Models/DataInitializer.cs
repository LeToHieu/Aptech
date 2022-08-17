using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EAP_Cxxx_NguyenVanA.Models
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            base.Seed(context);
            //fake data
            try
            {
                context.Classes.Add(new Class
                {
                    ClassId = 1,
                    ClassName = "VIP Member"
                });
                context.Classes.Add(new Class
                {
                    ClassId = 2,
                    ClassName = "Newslater discount group"
                });
                context.Classes.Add(new Class
                {
                    ClassId = 3,
                    ClassName = "Institutional Education"
                });
                context.SaveChanges();
                context.Customers.Add(new Customer { 
                    CustomerId = 1,
                    FullName = "Nguyen Van X",
                    BirthDate = DateTime.Parse("1955-02-24"),
                    UserName = "nguyenvanx",
                    Password = "Abc@1234",
                    ConfirmPassword = "Abc@1234",
                    ClassId = 1,
                    Address = "address aa111"

                });
                context.Customers.Add(new Customer
                {
                    CustomerId = 2,
                    FullName = "Ngufdmikfyen Van X",
                    BirthDate = DateTime.Parse("1985-02-24"),
                    UserName = "hfduhg",
                    Password = "Abc@1234",
                    ConfirmPassword = "Abc@1234",
                    ClassId = 1,
                    Address = "addressnfdjf  aa111"

                });
                context.Customers.Add(new Customer
                {
                    CustomerId = 3,
                    FullName = "Nguyen Vmkmmkan X",
                    BirthDate = DateTime.Parse("1955-02-24"),
                    UserName = "nghuuhgby",
                    Password = "Abc@1234",
                    ConfirmPassword = "Abc@1234",
                    ClassId = 1,
                    Address = "address aa111"

                });
                context.Customers.Add(new Customer
                {
                    CustomerId = 4,
                    FullName = "Nguymmnmen Van X",
                    BirthDate = DateTime.Parse("2002-02-24"),
                    UserName = "nguyenvanx",
                    Password = "Abc@1234",
                    ConfirmPassword = "Abc@1234",
                    ClassId = 1,
                    Address = "address aa111"

                });
                context.Customers.Add(new Customer
                {
                    CustomerId = 5,
                    FullName = "Nguyenjnhn Van X",
                    BirthDate = DateTime.Parse("1955-02-24"),
                    UserName = "jijkiklk",
                    Password = "Abc@1234",
                    ConfirmPassword = "Abc@1234",
                    ClassId = 1,
                    Address = "address aa111"

                });
                context.Customers.Add(new Customer
                {
                    CustomerId = 6,
                    FullName = "Nguyen Van X",
                    BirthDate = DateTime.Parse("1955-02-24"),
                    UserName = "nmdnndss",
                    Password = "Abc@1234",
                    ConfirmPassword = "Abc@1234",
                    ClassId = 1,
                    Address = "address aa111"

                });
                context.Customers.Add(new Customer
                {
                    CustomerId = 7,
                    FullName = "Nguyen dmdmVan X",
                    BirthDate = DateTime.Parse("1955-02-24"),
                    UserName = "enndddd",
                    Password = "Abc@1234",
                    ConfirmPassword = "Abc@1234",
                    ClassId = 1,
                    Address = "address aa111"

                });
                context.Customers.Add(new Customer
                {
                    CustomerId = 8,
                    FullName = "Nguyen Vfdmmfan X",
                    BirthDate = DateTime.Parse("1955-02-24"),
                    UserName = "ngmdsijf",
                    Password = "Abc@1234",
                    ConfirmPassword = "Abc@1234",
                    ClassId = 1,
                    Address = "address aa111"

                });
                context.Customers.Add(new Customer
                {
                    CustomerId = 9,
                    FullName = "Nguyefmd n Van X",
                    BirthDate = DateTime.Parse("1999-02-24"),
                    UserName = "nguyenvanx",
                    Password = "Abc@1234",
                    ConfirmPassword = "Abc@1234",
                    ClassId = 1,
                    Address = "address aa111"

                });
                context.Customers.Add(new Customer
                {
                    CustomerId = 10,
                    FullName = "Nguyendds Van X",
                    BirthDate = DateTime.Parse("1955-02-24"),
                    UserName = "niirerenvanx",
                    Password = "Abc@1234",
                    ConfirmPassword = "Abc@1234",
                    ClassId = 1,
                    Address = "address aa111"

                });
                context.Customers.Add(new Customer
                {
                    CustomerId = 11,
                    FullName = "Ngumfdjfyen Van X",
                    BirthDate = DateTime.Parse("1955-02-24"),
                    UserName = "ngmndmsvanx",
                    Password = "Abc@1234",
                    ConfirmPassword = "Abc@1234",
                    ClassId = 1,
                    Address = "address aa111"

                });
                context.SaveChanges();
            }
            catch (Exception e) {
                Console.WriteLine($"Error in DB: {e.Message}");
            }

        }
    }
}