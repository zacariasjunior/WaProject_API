using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaProject_API.Service.Authentication
{
    public class InMemoryGetApiKeyQuery : IGetApiKeyQuery
    {
        private readonly IDictionary<string, ApiKey> _apiKeys;

        public InMemoryGetApiKeyQuery()
        {
            var existingApiKeys = new List<ApiKey>
            {
                 new ApiKey(1, "Management", "06795D9D-A770-44B9-9B27-03C6ABDB1BAE", new DateTime(2021, 04, 29),
                    new List<string>
                    {                        
                        Roles.Manager
                    }),
            };

            _apiKeys = existingApiKeys.ToDictionary(x => x.Key, x => x);
        }

        public Task<ApiKey> Execute(string providedApiKey)
        {
            _apiKeys.TryGetValue(providedApiKey, out var key);
            return Task.FromResult(key);
        }
    }
}
