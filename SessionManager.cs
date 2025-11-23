using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymRoomExMachina
{
    namespace PetitPlannerIntegrador
    {
        public static class SessionManager
        {
            public static string CurrentUserId { get; private set; }

            public static void StartSession(string userId)
            {
                CurrentUserId = userId;
            }

            public static void EndSession()
            {
                CurrentUserId = null;
            }
        }

    }
}
