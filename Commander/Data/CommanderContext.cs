using Commander.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }

        public DbSet<Command> Commands { get; set; }

        //dotnet tool install --global dotnet-ef
        //How to create migration: dotnet ef migrations add <Name of migration>
        //how to run migration: dotnet ef migrations update
    }
}
