using System;

namespace Wizard
{
    public class KookpotOntploffingException: Exception
    {
        public KookpotOntploffingException()
            : base("BOOM! de kookpot is ontploft!")
        {
        }
    }
}
