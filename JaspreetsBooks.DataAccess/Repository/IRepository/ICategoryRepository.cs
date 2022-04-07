using JaspreetsBooks.Models;
using JaspreetsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace JaspreetsBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
