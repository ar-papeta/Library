using DAL.Db.Repositories;
using DAL.Models;
using System;
using System.Collections.Generic;

namespace DAL.Db.Uof;

public class LibraryUnitOfWork : IUnitOfWork
{
   
    private readonly LibraryContext _context;
    private IRepository<User> _userRepository;
    //add another repositories here

    public LibraryUnitOfWork(LibraryContext context)
    {
        _context = context;
    }

    public IRepository<User> Users
    {
        get
        {
            _userRepository ??= new GenericRepository<User>(_context);  //використовуємо повторно уже створений репозиторій при повторних зверненнях
            return _userRepository;
        }
    }

    public void Save()
    {
        _context.SaveChanges();
    }
    
}
