using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ItemList>(entity =>
        //    {
             
        //        entity.Property(e => e.BodyText).IsRequired(false);
        //        entity.Property(e => e.Itemlist).IsRequired(false);
        //        entity.Property(e => e.ShortText).IsRequired(false);
        //        entity.Property(e => e.VideoUrl).IsRequired(false);
        //    });

        //    modelBuilder.Entity<Multimedia>(entity =>
        //    {

        //        entity.Property(e => e.SectionBgColor).IsRequired(false);
        //        entity.Property(e => e.Title).IsRequired(false);
        //        entity.Property(e => e.TitleBgColor).IsRequired(false);
        //    });


        
        //}
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<ItemList> ItemLists { get; set; }
        //public DbSet<Multimedia> Multimedias { get; set; }
        //public DbSet<NewsDetail> NewsDetails { get; set; }

        //jsondan çekileceği için yorum satırına alınmıştır.
    }
}
