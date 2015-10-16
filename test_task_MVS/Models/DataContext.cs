using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace test_task_MVS.Models
{
    public class DataContext : DbContext
    {
        public DbSet<ListModel> Lists { get; set; }
    }
}