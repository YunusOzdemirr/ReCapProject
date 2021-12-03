using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
namespace Core.Extensions
{
    public static class SessionExtensionMethods
    {
        public static void SetObject(this ISession session, string key, string value)
        {
            var SetStringObject = JsonConvert.SerializeObject(value);
            //session.SetObject(key, SetStringObject);
            //session.SetString(key, SetStringObject);
        }
    }
}