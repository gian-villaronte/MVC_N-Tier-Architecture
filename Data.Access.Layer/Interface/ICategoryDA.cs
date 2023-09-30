using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GE = Global.Entity;

namespace Data.Access.Layer.Interface
{
    public interface ICategoryDA
    {
        List<GE::Category> GetCategories();

    }
}
