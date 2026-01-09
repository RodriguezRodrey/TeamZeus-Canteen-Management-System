// FILE: logic/services/CategoryManager.cs
using System;
using System.Collections.Generic;
using CanteenManagementSystem.logic.models;
using CanteenManagementSystem.logic.interfaces;

namespace CanteenManagementSystem.logic.services
{
    public class CategoryManager
    {
        private ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Category GetCategoryById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public List<Category> GetAllCategories()
        {
            return _categoryRepository.GetAll();
        }

        public void AddCategory(Category category)
        {
            _categoryRepository.Save(category);
        }

        public void UpdateCategory(Category category)
        {
            _categoryRepository.Update(category);
        }

        public void DeleteCategory(int categoryId)
        {
            _categoryRepository.Delete(categoryId);
        }
    }
}