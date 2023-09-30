using Data.Access.Layer.Interface;
using Data.Access.Layer.Models;
using System.Xml.Linq;
using GE = Global.Entity;

namespace Data.Access.Layer
{
    public class CategoryDA : ICategoryDA
    {
        private readonly BulkyContext _context;

        public CategoryDA(BulkyContext bulkyContext)
        {
            _context = bulkyContext;
        }

        public List<GE::Category> GetCategories() 
        { 
            var _data = _context.Categories.ToList();
            var categories = new List<GE::Category>();
            if (_data.Count > 0 && _data != null ) 
            { 
                foreach(var category in _data) 
                {
                    categories.Add(new GE.Category()
                    {
                                Id = category.Id,
                                Name = category.Name,
                                DisplayOrder = category.DisplayOrder,
                                CreatedDateTime = category.CreatedDateTime
                    });
                }
            }
            return categories;
        }
    }
}