using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NvbLesson08CF.Models
{
    public class NvbBookStore : DbContext
    {
        public NvbBookStore():base("NvbBookStoreConnectionString")
        {

        }
        //Tạo các bảng
        public DbSet<NvbCategory> NvbCategories { get; set; }
        public DbSet<NvbBook> Books { get;}
    }
}