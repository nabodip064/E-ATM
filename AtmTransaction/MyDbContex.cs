using AtmTransaction.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AtmTransaction
{
    public class MyDbContex : DbContext
    {
        public DbSet<UserData> userData { get; set; }
        public MyDbContex()
        {

        }
    }
}