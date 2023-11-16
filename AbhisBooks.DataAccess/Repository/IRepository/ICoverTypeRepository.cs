using AbhisBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbhisBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
