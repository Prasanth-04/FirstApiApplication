using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Datingapp.Entities;

namespace Datingapp.Interface
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
