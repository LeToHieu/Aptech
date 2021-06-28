using System;
using Microsoft.EntityFrameworkCore;
namespace MyProject.Models
{
    public class MyDatabaseContext: DbContext
    {
        public MyDatabaseContext() : base();        
    }
}
