using System.Collections.Generic;
namespace WebApplication1.Models
{
    public static class Repository
    {
        private static List<GuestResponse> guestResponses = new List<GuestResponse>();
        public static IEnumerable<GuestResponse> GuestResponses { get {  return guestResponses; } }
        public static void AddResponse(GuestResponse response)
        {
            guestResponses.Add(response);
        }
    }
}
