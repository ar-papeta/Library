
using DAL.Entities.AuxiliaryEntities;
using DAL.Entities.PersonsEntities;
using DAL.Entities.PublicationEnteties;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace DAL.Db;

public class LibraryContext : DbContext
{
    public DbSet<Author> Authors { get; set; } = null!;
    public DbSet<Book> Books { get; set; } = null!;
    public DbSet<Ebook> Ebooks { get; set; } = null!;
    public DbSet<Journal> Journals { get; set; } = null!;
    public DbSet<PublicationItem> PublicationItems { get; set; } = null!;
    public DbSet<Publisher> Publishers { get; set; } = null!;
    public DbSet<Review> Reviews { get; set; } = null!;
    public DbSet<Tag> Tags { get; set; } = null!;
    public DbSet<Visitor> Visitors { get; set; } = null!;
    public DbSet<Address> Addresses { get; set; } = null!;
    public DbSet<Contact> Contacts { get; set; } = null!;
    public DbSet<LibraryInfo> LibraryInfos { get; set; } = null!;
    public DbSet<SeasonTicket> SeasonTickets { get; set; } = null!;
    public DbSet<ActiveItem> ActiveItems { get; set; } = null!;

    public string DbPath { get; }

    public LibraryContext()
    {
        //var folder = Environment.SpecialFolder.LocalApplicationData;
        //var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join("LibraryDb.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}
