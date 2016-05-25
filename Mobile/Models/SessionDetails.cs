using System;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Http.Features;
using Microsoft.Extensions.Configuration;

namespace Mobile.Models
{
    public class SessionDetails
    {
        private readonly IHttpContextAccessor _Context;
        private readonly IConfiguration _config;
        private ISession _session => _Context.HttpContext.Session;

        public SessionDetails(IHttpContextAccessor httpContextAccessor, IConfiguration config)
        {
            _Context = httpContextAccessor;
            _config = config;
        }

        /// <summary>
        /// Current logged in users Cascade session token
        /// </summary>
        public Guid CascadeSessionToken
        {
            get
            {
                return new Guid(_session.GetString("CascadeSessionToken"));
            }
            set
            {
                _session.SetString("CascadeSessionToken", value.ToString());
            }
        }

        public string GetWcfServicesRoot()
        {
            return _config.GetSection("AppSettings").GetSection("CascadeHrEndPointRoot").Value;
        }

    }
}
