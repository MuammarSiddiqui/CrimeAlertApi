//using CrimeAlertApi.Models;
//using dreamjob.JWTModels;
//using dreamjob.Models;
//using dreamjob.Repository.RolesRepository;

//namespace dreamjob.Services.RolesService
//{
//    public class RolesService : IRolesService
//    {
//        private readonly IRolesRepository _repository;

//        public RolesService(IRolesRepository repository)
//        {
//            _repository = repository;
//        }

//        public async Task<Roles> Add(Roles RolesDto)
//        {
//            try
//            {
//                RolesDto.Active = "Y";
//                RolesDto.CreatedDate = DateTime.Now;
//                await _repository.Add(RolesDto);
//                return RolesDto;

//            }
//            catch (Exception ex)
//            {

//                throw;
//            }
//        }

//        public async Task<IEnumerable<Roles>> GetAll()
//        {
//            try
//            {
//                var Roless = await _repository.GetAll();

//                return (from ar in Roless.Where(r => r.Active == "Y")
//                        select new Roles
//                        {
//                            Id = ar.Id,
//                            Name = ar.Name,
//                            RolesCode = ar.RolesCode,
//                            Courses = ar.Courses,
//                            Description = ar.Description,
//                            CreatedDate = ar.CreatedDate,
//                            CreatedBy = ar.CreatedBy,
//                            UpdateBy = ar.UpdateBy,
//                            UpdateDate = ar.UpdateDate,
//                            Active = ar.Active
//                        }).ToList();
//            }
//            catch (Exception ex)
//            {

//                throw;
//            }
//        }

//        public async Task<Roles> GetById(Guid id)
//        {
//            try
//            {
//                return await _repository.GetById(id);
//            }
//            catch (Exception ex)
//            {

//                throw;
//            }
//        }

//        public Task<Roles> GetByIdNoTraces(Guid id)
//        {
//            return _repository.GetByIdNoTraces(id);
//        }

//        public async Task<bool> Remove(Roles RolesDto)  {
//            try
//            {
//                RolesDto.Active = "N";
//                RolesDto.UpdateDate = DateTime.Now;
//                await _repository.Remove(RolesDto);
//                return true;
//            }
//            catch (Exception ex)
//            {

//                throw;
//            }
//        }

//        public async Task<Roles> Update(Guid id, Roles RolesDto)
//        {
//            try
//            {
//                RolesDto.UpdateDate = DateTime.Now;
//                RolesDto.Active = "Y";
//                await _repository.Update(id,RolesDto);
//                return RolesDto;
//            }
//            catch (Exception ex)
//            {

//                throw;
//            }
//        }
//    }
//}
