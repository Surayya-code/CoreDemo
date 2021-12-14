using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CoreDemo.Controllers
{
    internal class EfNewsLetterRepository : GenericRepository<NewsLetter>, INewsLetterDal
    {
      
    }
}