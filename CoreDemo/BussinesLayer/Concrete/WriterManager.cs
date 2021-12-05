using BussinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writelDal;

        public WriterManager(IWriterDal writelDal)
        {
            _writelDal = writelDal;
        }

        public void WriterAdd(Writer writer)
        {
            _writelDal.Insert(writer);
        }
    }
}
