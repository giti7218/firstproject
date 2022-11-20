using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace MyProject.Repositories.Repositories
{
    class ClaimRepositories:IClaim
    {
        List<Claim> GetAll()
        {
            return 
        }
        Claim GetById(int id)
        {
            for (int i = 0; i < length; i++)
            {

            }
        }
        Claim Add(int id, string name);
        Claim Update(Claim Role);
        void Delete(int id);

    }
}
