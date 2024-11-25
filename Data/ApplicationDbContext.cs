using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace app.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions){}

        //Dbset is use to connect class in the application and table in the database
        //Suppose person class in the application and against this class what table name in the database.
        
        // public DbSet<{classname}> {tablename} { get; set; }
    }
}