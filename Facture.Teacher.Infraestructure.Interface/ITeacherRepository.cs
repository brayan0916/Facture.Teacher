using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facture.Teacher.Domain.Entity;


    public interface ITeacherRepository
    {
         Task<List<Teacher>> GetAllTeacher();
    Task<Teacher> GetTeacher(int id);
    Task<Teacher> AddTeacher(Teacher teacher);
}

