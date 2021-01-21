using System;
using System.Collections.Generic;
using System.Text;

using System;

using System.IO;

//using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using System.Web;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;


namespace SISSchedule_Utilities
{
    public static class ExceptionHandler
    {



        private static String ErrorlineNo, Errormsg, extype, exstacktrace, hostIp, ErrorLocation, HostAdd;
        /// <summary>
        /// Exception handler to text file
        /// </summary>
        /// <param name="ex"></param>
        public static void SendErrorToText(Exception ex, string FilePath)
        {

            var line = Environment.NewLine + Environment.NewLine;
            // var httpRequestFeature = request.HttpContext.Features.Get<IHttpRequestFeature>();
            ErrorlineNo = ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7);
            Errormsg = ex.GetType().Name.ToString();
            extype = ex.GetType().ToString();

            //exurl = httpcontext.Request.GetEncodedUrl(); // context.Current.Request.Url.ToString();
            exstacktrace = ex.StackTrace.ToString();
            ErrorLocation = ex.Message.ToString();

            try
            {
                string filepath = FilePath; // context.Current.Server.MapPath("~/ExceptionDetailsFile/");  //Text File Path

                if (!Directory.Exists(filepath))
                {
                    Directory.CreateDirectory(filepath);

                }
                filepath = filepath + DateTime.Today.ToString("dd-MM-yy") + ".txt";   //Text File Name
                if (!File.Exists(filepath))
                {


                    File.Create(filepath).Dispose();

                }
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    string error = "Log Written Date:" + " " + DateTime.Now.ToString() + line + "Error Line No :" + " " + ErrorlineNo + line + "Error Message:" + " " + Errormsg + line + "Exception Type:" + " " + extype + line + "Error Location :" + " " + ErrorLocation + line + " Error stacktrace:" + " " + exstacktrace + line + "User Host IP:" + " " + hostIp + line;
                    sw.WriteLine("-----------Exception Details on " + " " + DateTime.Now.ToString() + "-----------------");
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(line);
                    sw.WriteLine(error);
                    sw.WriteLine("--------------------------------*End*------------------------------------------");
                    sw.WriteLine(line);
                    sw.Flush();
                    sw.Close();

                }

            }
            catch (Exception e)
            {
                e.ToString();

            }
        }


        public static void ConfigureExceptionHandler(this IApplicationBuilder app, string Filepath)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                            //logger.LogError($"Something went wrong: {contextFeature.Error}");
                            SendErrorToText(contextFeature.Error, Filepath);
                        await context.Response.WriteAsync(new Error()
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = "Internal Server Error."
                        }.ToString());
                    }
                });
            });
        }

    }
}





