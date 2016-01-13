using System.Threading.Tasks;
using Bode.Services.Core.Dtos.User;
using Bode.Services.Core.Models.User;
using OSharp.Core.Context;
using OSharp.Utility.Data;
using OSharp.Core.Dependency;

namespace Bode.Services.Core.Contracts
{
    public partial interface IBugContract : IScopeDependency
    {
        OperationResult GetBugCount(string userName, string password);
    }
}
