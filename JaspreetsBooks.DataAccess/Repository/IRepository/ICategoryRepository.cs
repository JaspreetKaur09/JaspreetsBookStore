using JaspreetsBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaspreetsBooks.DataAccess.Repository.IRepository
{
    interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
