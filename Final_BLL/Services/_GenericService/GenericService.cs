using AutoMapper;
using Final_BLL.Responses;
using Final_DAL.Repositories._GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_BLL.Services._GenericService
{
    public class GenericService<Entity, DTO> : IGenericService<DTO>
        where Entity : class
        where DTO : class
    {
        public readonly IGenericRepository<Entity> _genericRepository;
        public readonly IMapper _mapper;
        public GenericService(IGenericRepository<Entity> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public ApiResponse<DTO> Add(DTO dto)
        {
            var response = new ApiResponse<DTO>();
            var entity = _mapper.Map<Entity>(dto);
            if (entity == null)
            {
                throw new Exception("null");
            }
            var result = _genericRepository.Add(entity);
            return response;
        }
        //virtual: n3ml override
        public virtual ApiResponse<bool> Delete(int id)
        {
            var response = new ApiResponse<bool>();
            response.Data = _genericRepository.Delete(id);
            return response;
        }

        public virtual ApiResponse<bool> Delete(DTO dto)
        {
            var response = new ApiResponse<bool>();
            var entity = _mapper.Map<Entity>(dto);
            var result = _genericRepository.Delete(entity);
            return response;
        }

        public ApiResponse<IEnumerable<DTO>> GetAll()
        {
            var response = new ApiResponse<IEnumerable<DTO>>();
            var result = _genericRepository.GetAll();
            response.Data = _mapper.Map<IEnumerable<DTO>>(result);
            return response;
        }

        public ApiResponse<DTO> GetById(int id)
        {
            var response = new ApiResponse<DTO>();
            var result = _genericRepository.GetById(id);
            response.Data = _mapper.Map<DTO>(result);
            return response;
        }

        public ApiResponse<DTO> Update(DTO dto)
        {
            var response = new ApiResponse<DTO>();
            var entity = _mapper.Map<Entity>(dto);
            var result = _genericRepository.Update(entity);
            response.Data = _mapper.Map<DTO>(result);
            return response;
        }


    }
}
