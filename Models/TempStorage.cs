using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarkerAssignment3.Models
{
    public static class TempStorage
    {
        private static List<FormResponse> responses = new List<FormResponse>();

        public static IEnumerable<FormResponse> Responses => responses;

        public static void AddResponse(FormResponse movieResponse)
        {
            responses.Add(movieResponse);
        }
        //This will add the movies to the list every time it is updated
    }
}
