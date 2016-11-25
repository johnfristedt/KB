using KB.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.EntityFramework.Repositories
{
    interface IArticleRepository
    {
        Article[] GetArticles();
    }
}
