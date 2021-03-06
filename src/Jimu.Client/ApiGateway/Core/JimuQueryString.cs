﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Specialized;
using System.Web;

namespace Jimu.Client.ApiGateway.Core
{
    [ModelBinder(BinderType = typeof(JimuQueryStringModelBinder))]
    public class JimuQueryString
    {
        public string Query { get; set; }

        public NameValueCollection Collection { get; set; }
        public JimuQueryString(string query)
        {
            Query = query;
            Collection = HttpUtility.ParseQueryString(query);
        }
    }
}
