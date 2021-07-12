using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth.server {
    public static class Config {
        public static IEnumerable<Client> Clients => new Client[] {

        };  
        public static IEnumerable<IdentityResource> IdentityResources => new IdentityResource[] {

        };  
        public static IEnumerable<ApiResource> ApiResources => new ApiResource[] {

        }; 
        public static IEnumerable<ApiScope> ApiScopes => new ApiScope[] {

        };
        public static List<TestUser> TestUsers => new List<TestUser> {

        };

    }
}
