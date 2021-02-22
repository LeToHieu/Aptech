using EAP_Music_NguyenVanA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EAP_Music_NguyenVanA
{
    public class DataContext:DbContext
    {
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

        public DataContext()
        {
            
        }
    }
}