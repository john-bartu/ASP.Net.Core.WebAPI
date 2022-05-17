using Data.Repos;
using Models.DbEntities;
using Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Services.Concrete
{
    public class LoginLogService : ILoginLogService
    {
        private readonly IGenericRepository<LoginLog> _repository;
        public LoginLogService(IGenericRepository<LoginLog> repository)
        {
            _repository = repository;
        }
        public async Task Add(LoginLog model)
        {
            await _repository.InsertAsync(model);
        }

        public async Task<List<LoginLog>> Get(string email)
        {
            var content = await _repository.FindAllAsync(x => x.UserEmail.Equals(email));
            return content.ToList();
        }
    }
}
