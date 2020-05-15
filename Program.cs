using System;
using System.Net;
namespace WhatHttpCode
{
    class Program
    {
        static void Main(string[] args)
        {
            if(hasNoArgs(args)){
               writeAllStatusCodes();
               return;
            }

            var httpCode = getHttpCode(args[0]);

            if(isInValidCode(httpCode)){
                Console.WriteLine("Tisk Tisk ... That's not a valid HttpStatusCode");
                return;
            }

            Console.WriteLine($"{(int)httpCode} => {httpCode.ToString()}");
        }

        // Helpers
        private static bool hasArgs(string[] args) => args.Length > 0;
        private static bool hasNoArgs(string[] args) => !hasArgs(args);
        private static bool isInValidCode(HttpStatusCode code) => !isValidCode(code);
        private static bool isValidCode(HttpStatusCode code) => !int.TryParse(code.ToString(), out var invalidCode);
        private static HttpStatusCode getHttpCode(string httpCode){
            var isInt = int.TryParse(httpCode, out var code);
            var httpCodeOut = (HttpStatusCode)code;
            return httpCodeOut;
        }

        private static void writeAllStatusCodes(){
                Console.WriteLine("Fetching Status Codes ...");
               foreach(HttpStatusCode status in Enum.GetValues(typeof(HttpStatusCode))){
                   Console.WriteLine($"{(int)status} => {status.ToString()}");
               }
               Console.WriteLine("That's all of them... Next time you can pass in an statusCode and I'll tell you what that number means!");
        }
    }
}
