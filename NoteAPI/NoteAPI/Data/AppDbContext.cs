﻿using Microsoft.EntityFrameworkCore;
using NoteAPI.Models;

namespace NoteAPI.Data
{
    public class AppDbContext : DbContext {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Note> Notes { get; set; }


    }
       
    
}
