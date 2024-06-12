using PX.Data.BQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCRLog
{
    public static class Messages
    {
        public const string NCR = "Non-Conformance Record";
        public const string ECN = "Engineers Change Notice";

        public const string NCRLog = "Non-Conformance Record Log";
        public const string ECNLog = "Engineers Change Notice Log";

        public const string F = "Full";
        public const string C = "Consignment";
        public const string D = "Deviation";

        public const string ISO = "ISO Records";
        public const string ISOSetup = "ISO Records Setup/Preferences";

        public const string QualityControl = "End of Line Quality Checks";

        public const string O = "O";

        public class move : BqlString.Constant<move>
        {
            public move() : base(O)
            {
            }
        }

        public const string MoveNotFound = "Move not Found";
        public const string PressGlueLog = "Press & Glue Log";
        public const string QCDetails = "Qualit Control Details";
    }
}
