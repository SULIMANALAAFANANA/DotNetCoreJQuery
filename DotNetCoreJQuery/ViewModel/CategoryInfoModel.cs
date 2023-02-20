using DotNetCoreJQuery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreJQuery.ViewModel
{
    public class CategoryInfoModel
    {
        public Category Category { get; set; } = new Category();
        private List<Category> Categories = new List<Category>();
        public List<Category> CategoryList
        {
            get { return Categories; }
            set { Categories = value; }
        }
    }
}
