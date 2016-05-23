using System;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Http.Features;

namespace Mobile.Models
{
    public class SessionDetails
    {
        private readonly IHttpContextAccessor _Context;
        private ISession _session => _Context.HttpContext.Session;

        public SessionDetails(IHttpContextAccessor httpContextAccessor)
        {
            _Context = httpContextAccessor;
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

    }
}
