using System;
using System.Collections;
using Data;

namespace Web.Models
{
    public static class CategoriesViewModel
    {
        public static IEnumerable GetCategories()
        {
            return Enum.GetValues(typeof(Category));
        }
    }
}
