using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ADMINAPI.Helpers
{
    public class APIResponseCreator
    {
        public static ContentResult GetResponse(int code, string message, dynamic data, HttpStatusCode statusCode, int count = 0)
        {
            dynamic res = new ExpandoObject();
            res.code = code;
            res.message = message;
            res.data = data;

            return new ContentResult
            {
                Content = Newtonsoft.Json.JsonConvert.SerializeObject(res),
                ContentType = "text/json",
                StatusCode = (int)statusCode
            };
        }
    }
}
