using CodePulseAPI.Data;
using CodePulseAPI.Models.Domain;
using CodePulseAPI.Models.Domain.DTO;
using CodePulseAPI.Models.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodePulseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDto request)
        {
           
            var category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle
            };

            await categoryRepository.CreateAsync(category);
            var response = new Category
            {
                Id = category.Id,
                Name = category.Name,
                UrlHandle = category.UrlHandle


            };

            return Ok(response);
        }
    }
}
