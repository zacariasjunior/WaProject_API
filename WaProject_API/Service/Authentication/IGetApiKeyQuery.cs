using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaProject_API.Service.Authentication
{
    public interface IGetApiKeyQuery
    {
        Task<ApiKey> Execute(string providedApiKey);
    }
}
