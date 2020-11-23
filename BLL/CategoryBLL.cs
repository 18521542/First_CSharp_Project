﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class CategoryBLL
    {
        private CategoryDAL categoryDAL = null;

        public CategoryBLL() { categoryDAL = new CategoryDAL(); }

        public List<Category> GetCategories()
        {
            return categoryDAL.getCategories();
        }

        public bool AddCategory(string CategoryName)
        {
            return categoryDAL.AddCategory(CategoryName);
        }
    }
}
