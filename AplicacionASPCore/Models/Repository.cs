using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacionASPCore.Models
{
    public static class Repository
    {
        private static List<RespuestaInvitado> responses = new List<RespuestaInvitado>();

        public static IEnumerable<RespuestaInvitado> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(RespuestaInvitado response)
        {
            responses.Add(response);
        }
    }
}
