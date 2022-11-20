using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;


namespace MyProject.Repositories.Interfaces
{
   public interface IClaim
    {
        List<Claim> GetAll();
        Claim GetById(int id);
        Claim Add(int id, string name);
        Claim Update(Claim Role);
       void Delete(int id);

    }
}
