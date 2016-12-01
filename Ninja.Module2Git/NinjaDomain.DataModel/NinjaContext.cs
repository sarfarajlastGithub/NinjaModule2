using NinjaDomain.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaDomain.DataModel
{
    public class NinjaContext : DbContext
    {
        DbSet<Ninja> Ninjas { get; set; }
        DbSet<Clan> Clans { get; set; }
        DbSet<NinjaEquipment> Equipment { get; set; }
    }
}
