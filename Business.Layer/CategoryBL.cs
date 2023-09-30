using Business.Layer.Interface;
using Data.Access.Layer;
using Data.Access.Layer.Interface;
using GE = Global.Entity;

namespace Business.Layer
{
    public class CategoryBL : ICategoryBL
    {
        private readonly ICategoryDA _category;

        public CategoryBL(ICategoryDA category)
        {
            _category = category;
        }

        public List<GE::Category> GetCategories() 
        { 
            return _category.GetCategories();
        }


    }
}