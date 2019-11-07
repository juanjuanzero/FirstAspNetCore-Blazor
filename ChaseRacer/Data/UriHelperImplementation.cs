using Microsoft.AspNetCore.Blazor.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChaseRacer.Data
{
    public class UriHelperImplementation : IUriHelper
    {
        public event EventHandler<string> OnLocationChanged;

        public string GetAbsoluteUri()
        {
            throw new NotImplementedException();
        }

        public string GetBaseUri()
        {
            throw new NotImplementedException();
        }

        public void NavigateTo(string uri)
        {
            throw new NotImplementedException();
        }

        public Uri ToAbsoluteUri(string href)
        {
            throw new NotImplementedException();
        }

        public string ToBaseRelativePath(string baseUri, string locationAbsolute)
        {
            throw new NotImplementedException();
        }
    }
}
