using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Profinder_4._1.Services
{
    public abstract class Service
{
        protected HttpClient _client;
        protected string _BaseApiUrl = "https://api-profinder.azurewebsites.net/";

        public Service()
        {
            _client = new HttpClient();
        }
}
}
