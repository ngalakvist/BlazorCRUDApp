using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDApp.Data
{
  public class SqlDBContext :DbContext
  {
    public SqlDBContext(DbContextOptions<SqlDBContext> options)
        : base(options)
    {
    }
    public DbSet<BlazorCRUDApp.Data.CustomerMaster> CustomerMaster { get; set; }
  }
}
