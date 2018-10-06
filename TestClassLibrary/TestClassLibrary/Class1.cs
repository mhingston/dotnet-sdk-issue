using Newtonsoft.Json.Linq;
using System;

namespace TestClassLibrary
{
    public class Class1
    {
        public static string Method1()
        {
            return new JObject(
                new JProperty("status", "ok")
            ).ToString();
        }
    }
}
