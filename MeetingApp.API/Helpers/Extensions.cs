using Microsoft.AspNetCore.Http;

namespace MeetingApp.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError( this HttpResponse response, string message )
        {
            response.Headers.Add("Application-Header", message);
            response.Headers.Add("Access-Control-Expose-Headers", message);
            response.Headers.Add("Access-Control-Allow-Origin", message);
        }

    }
}