using Final_BLL.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_BLL.Services._GenericService
{
    public interface IGenericService<DTO> where DTO : class
    {
        ApiResponse<IEnumerable<DTO>> GetAll();
        ApiResponse<DTO> GetById(int id);
        ApiResponse<DTO> Add(DTO T);
        ApiResponse<DTO> Update(DTO T);
        ApiResponse<bool> Delete(int id);
        ApiResponse<bool> Delete(DTO T);
    }
}
