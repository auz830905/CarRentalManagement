using CarRentalManagement.Server.Data;
using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Make> _makes;
        private IGenericRepository<Colour> _colours;
        private IGenericRepository<Model> _models;
        private IGenericRepository<Vehicle> _vehicles;
        private IGenericRepository<Booking> _bookings;
        private IGenericRepository<Customer> _customers;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IGenericRepository<Make> Makes => _makes ??= new GenericRepository<Make>(_context);

        public IGenericRepository<Colour> Colour => _colours ??= new GenericRepository<Colour>(_context);

        public IGenericRepository<Model> Model => _models ??= new GenericRepository<Model>(_context);

        public IGenericRepository<Vehicle> Vehicle => _vehicles ??= new GenericRepository<Vehicle>(_context);

        public IGenericRepository<Booking> Booking => _bookings ??= new GenericRepository<Booking>(_context);

        public IGenericRepository<Customer> Customer => _customers ??= new GenericRepository<Customer>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            var user = httpContext.User.Identity.Name;
            var entries = _context.ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);

            foreach (var item in entries)
            {
                ((BaseModel)item.Entity).UpdateDate = DateTime.Now;
                ((BaseModel)item.Entity).UpdateBy = user;

                if (item.State == EntityState.Added)
                {
                    ((BaseModel)item.Entity).CreateDate = DateTime.Now;
                    ((BaseModel)item.Entity).CreateBy = user;
                }
            }
            await _context.SaveChangesAsync();
        }
    }
}
