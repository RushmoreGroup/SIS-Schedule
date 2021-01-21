using System;
using System.Collections.Generic;
using System.Text;

namespace SISSchedule_Utilities
{
    /// <summary>
    /// Service response class
    /// </summary>
    public class ServiceResponse<T>
    {
        public ServiceCode Code { get; set; }
        public string Message { get; set; }

        public T Result { get; set; }
        public string Token { get; set; }
        public int Id { get; set; }
    }

    public enum ServiceCode
    {
        Success=1,
        Failure =0
    }
}


