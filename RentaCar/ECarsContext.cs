using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar
{
    public class ECarsContext:DbContext
    {
     public DbSet<Car> car { get; set; }
    }
}
