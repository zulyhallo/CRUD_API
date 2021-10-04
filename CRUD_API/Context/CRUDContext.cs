using CRUD_API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_API.Context
{
    public class CRUDContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public CRUDContext(DbContextOptions<CRUDContext> options):base(options)
        {

        }

        public System.Data.Entity.DbSet<Producer> Producer { get; set; }
    }
}
