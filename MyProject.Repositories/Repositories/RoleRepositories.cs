using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Repositories
{
    class RoleRepositories:
    {
        List<Role> GetAll();
        Role GetById(int id);
        Role Add(int id, string name);
        Role Update(Role Role);
        void Delete(int id);
    }
}
