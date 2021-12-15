using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Files.Core.PartailViews.Models;

namespace Files.Core.PartailViews.Repository
{
    public interface IFilms
    {
        List<Films> ListofFilms();
    }
}
