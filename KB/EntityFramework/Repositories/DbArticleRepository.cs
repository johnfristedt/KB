using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KB.Models.EntityModels;

namespace KB.EntityFramework.Repositories
{
    public class DbArticleRepository : IArticleRepository
    {
        public Article[] GetArticles()
        {
            throw new NotImplementedException();
        }
    }
}