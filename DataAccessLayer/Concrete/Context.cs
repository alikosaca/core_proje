﻿using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        //Bağlantı string'i tutan ve veritabanına yansıtılacak olan tabloları tutan classtır.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Konfigürasyon metodu
        {
            optionsBuilder.UseSqlServer("server=MYLOCALSERVER\\SQLEXPRESS01; database=CoreProjeDB; integrated security=true");
        }
        
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<UserMessage> UserMessages{ get; set; }
        public DbSet<ToDoList> ToDoLists{ get; set; }

    }
}
