using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teste_webmotors.Models;

namespace teste_webmotors.DbContex
{
    public class WebMotorContext : DbContext
    {
        public WebMotorContext(DbContextOptions<WebMotorContext> options) : base(options) { }
        public DbSet<WebMotorsModel> tb_AnuncioWebmotors { get; set; }

       
    }
}
