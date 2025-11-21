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
            // Ambos IDs definidos como STRING para evitar conversiones
            public static string CurrentCoachId { get; private set; }

            public static void StartSession(string coachId)
            {
                CurrentCoachId = coachId;
            }
        }

    }
}
