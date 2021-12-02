using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    UserName="Surayya"
                },
                 new UserComment
                {
                    ID=2,
                    UserName="User2"
                }
                 ,
                 new UserComment
                {
                    ID=3,
                    UserName="User3"
                }
            };
            return View(commentValues);
        }
    }
}
