using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public interface IBookstoreRepository
    {
        //Get book objects from SeedData and store in an array
        IQueryable<Book> Books { get; }
    }
}
