
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.ViewComponents
{
    public class CommentList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    Id=1,
                    UserName = "Oğuzhan"
                },
                new UserComment
                {
                    Id=2,
                    UserName = "Eslem"
                },
                new UserComment
                {
                    Id=3,
                    UserName = "Orhan"
                }
            };
            return View(commentValues);
        }
    }
}
