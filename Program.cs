using System;
using System.Net;
namespace WhatHttpCode
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length<= 0 ){
               Console.WriteLine("Fetching Status Codes ...");
               foreach(HttpStatusCode status in Enum.GetValues(typeof(HttpStatusCode))){
                   if(status == HttpStatusCode.NetworkAuthenticationRequired){
                       var foo = "temp";
                   }
                   Console.WriteLine($"{(int)status} => {status.ToString()}");
               }
               Console.WriteLine("That's all of them... Next time you can pass in an statusCode and I'll tell you what that number means!");
               return;
            }
            var httpCodeIn =  args[0];
            var code = int.TryParse(httpCodeIn, out var httpCode);
            var description = (HttpStatusCode)httpCode;
            if(int.TryParse(description.ToString(), out var invalidCode )){
                Console.WriteLine("Tisk Tisk ... That's not a valid HttpStatusCode");
                return;
            }
            Console.WriteLine($"{httpCode.ToString()} => {description.ToString()}");
        }
    }
}
