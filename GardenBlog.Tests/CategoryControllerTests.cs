using System;
using Xunit;
using NSubstitute;
using GardenBlog.Repositories;
using GardenBlog.Controllers;
using GardenBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace GardenBlog.Tests
{
    public class CategoryControllerTests
    {
        CategoryController underTest;
        IRepository<Category> catRepos;

        public CategoryControllerTests()
        {
            catRepos = Substitute.For<IRepository<Category>>();
            underTest = new CategoryController(catRepos);
        }

        [Fact]
        public void CatIndex_Returns_A_View()
        {
            var result = underTest.CategoryIndex();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void SingleCategory_Returns_View_Based_On_ID()
        {
            var expectedCategory = new Category();
            catRepos.GetById(1).Returns(expectedCategory);

            var result = underTest.SingleCategory(1);

            Assert.Equal(expectedCategory, result.Model);
        }

    }
}
