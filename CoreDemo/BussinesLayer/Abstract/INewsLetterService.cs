﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
   public interface INewsLetterService
    {
        void AddNewsLetter(NewsLetter newsLetter);
       // void NewsLetterDelete(NewsLetter newsLetter);
        //void BlogUpdate(Blog blog);
        //List<Blog> GetList();
        //Blog GetById(int id);
        //List<Blog> GetBlogListWithCategory();
        //List<Blog> GetBlogListWithWriter(int id);
    }
}
