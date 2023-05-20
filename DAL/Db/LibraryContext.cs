
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Db;

public class LibraryContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<User> Users { get; set; }

    //інші "таблиці" нашої БД за аналогією реєструються тут 
    //.
    //.
    //.

    public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options) { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        //Цей метод викликається автоматично при першому створенні таблички бази даних,
        //тут можна завантажити стартові дані в бд (наприклад першого бібліотекаря або якісь тестові книжки)
        //або налаштування полів сутностей наприклад унікальність
        modelBuilder.Entity<User>().HasIndex(u => u.EMail).IsUnique();

        var initialUserAdmin = new User
        {
            Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
            EMail = "artem@gmail.com",
            Name = "Artem",
            Role = Role.Admin,
            Password = "Owve1iNLlEKKrO3hQplQLBNN3TfIkzMEXwF8EkikVN4="  //це хеш паролю а не сам пароль, так як ми використовуємо шифрування
                                                                       // тому в базі не зберігаються паролі, а їх хеші.
        };

        modelBuilder.Entity<User>().HasData(initialUserAdmin);
    }
}
