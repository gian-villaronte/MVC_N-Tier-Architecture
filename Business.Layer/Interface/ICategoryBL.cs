using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GE = Global.Entity;

namespace Business.Layer.Interface
{
    public interface ICategoryBL
    {
        List<GE::Category> GetCategories();
    }
}
