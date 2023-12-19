namespace ApiExample.Data
{
    using ApiExample.Classes;
    using ApiExample.Models;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;

    public class CharacterContext : DbContext
    {
        public DbSet<CharacterBase> Characters { get; set; }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Villain> Villains { get; set; }

        public string DbPath { get; }

        public CharacterContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "characters.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
