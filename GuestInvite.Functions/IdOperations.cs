using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestInvite.Functions
{
    internal static class IdOperations
    {
        public static long ContactId { get; private set; }

        public static long AssignId()
        {
            //Data.Globals.LastUsedId
            return 0;
        }

    }
}
