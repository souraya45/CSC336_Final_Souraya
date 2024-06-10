using Final_BLL.Responses;
using Final_BLL.Services._GenericService;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<DTO> : Controller where DTO : class
    {
        public readonly IGenericService<DTO> _genericService;
        public GenericController(IGenericService<DTO> genericService)
        {
            _genericService = genericService;
        }
        [HttpGet("GetAll")]
        public ApiResponse<IEnumerable<DTO>> GetAll()
        {
            return _genericService.GetAll();
        }

        [HttpGet("GetById")]
        public ApiResponse<DTO> GetById(int id)
        {
            return _genericService.GetById(id);
        }

        [HttpPost("Add")]
        public ApiResponse<DTO> Add(DTO dto)
        {
            return _genericService.Add(dto);
        }

        [HttpPut("Update")]
        public ApiResponse<DTO> Update(DTO dto)
        {
            return _genericService.Update(dto);
        }

        [HttpDelete("DeleteById")]
        public ApiResponse<bool> DeleteById(int id)
        {
            return _genericService.Delete(id);
        }

        [HttpDelete("Delete")]
        public ApiResponse<bool> Delete(DTO dto)
        {
            return _genericService.Delete(dto);
        }

    }
}
