using AuthencationWebapi.Model;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AuthencationWebapi.Repositry
{
    public interface IUserRepositry
    {
        Task<IdentityResult> register(tbluser user);
        Task<ICollection<tbluser>> userlists();
        Task<string> LoginAsync(loginmodel singin);
    }
}