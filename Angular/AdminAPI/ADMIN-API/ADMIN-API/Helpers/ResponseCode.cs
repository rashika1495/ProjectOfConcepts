using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADMINAPI.Helpers
{
    public class ResponseCode
    {
        public static readonly int SUCCESS_CODE = 0;
        public static readonly int FAILED_CODE = -1;
        public static readonly int Invalid_Code = -2;
        public static readonly int Error_code = -3;
        public static readonly string Error = "Error";
        public static readonly int EMAIL_NOT_CONFIRMED_CODE = -2;
        public static readonly int DEACTIVATED = -5;
        public static readonly string SUCCESS = "success";
        public static readonly string FAILED = "failed";
        public static readonly string InvalidValue = "Invalid Value";
        public static readonly int NoContent = 204;
        public static readonly string NotFound = "No Record Found";
        public static readonly int NotModified = 304;
        public static readonly string PassNotUpdated = "Password not updated";
        public static readonly int Ok = 200;
    }
}
