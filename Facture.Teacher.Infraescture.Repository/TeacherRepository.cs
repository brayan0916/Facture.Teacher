using Facture.Teacher.Infraetrucsture.Data;

namespace Facture.Teacher.Infraestructure.Repository
{
    public class TeacherRepository : ITeacherRepository
    {

        private readonly DapperContext context;

        public TeacherRepository (DapperContext context)
        {
            this.context = context;
        }

        public Task<Domain.Entity.Teacher> AddTeacher(Domain.Entity.Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public Task<List<Domain.Entity.Teacher>> GetAllTeacher()
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Entity.Teacher> GetTeacher(int id)
        {
            throw new NotImplementedException();
        }
    }
}
