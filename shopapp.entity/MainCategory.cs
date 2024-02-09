using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.entity
{
    public class MainCategory
    {
        public int MainCategoryId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public List<Category> Categories { get; set; }

    }
}