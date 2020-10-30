using Exam2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Exam2.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("EXample2")
        {

        }
        public DBSet<Employee> Employee { get; set; }

        public System.Data.Entity.DbSet<Exam2.Models.Employee> Employees { get; set; }
    }
}