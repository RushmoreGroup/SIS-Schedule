using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SISSchedule_Utilities
{
    /// <summary>
    /// Error vlass
    /// </summary>
    public class Error
    {
        public int StatusCode { get; set; }

        public string Message { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
