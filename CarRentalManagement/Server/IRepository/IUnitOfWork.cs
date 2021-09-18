using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.IRepository
{
    public interface IUnitOfWork: IDisposable
    {
        IGenericRepository<Make> Makes { get; }
        IGenericRepository<Colour> Colour { get; }
        IGenericRepository<Model> Model { get; }
        IGenericRepository<Vehicle> Vehicle { get; }
        IGenericRepository<Booking> Booking { get; }
        IGenericRepository<Customer> Customer { get; }
        Task Save(HttpContext httpContext);
    }
}
