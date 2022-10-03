using System;

namespace EPAM_TAO_M3_ConsoleApp.CustomException
{
    class InvalidStringExceptionClass : Exception
    {
        //Custom String Exception to be thrown if the string contains any special character or numeric value
        public InvalidStringExceptionClass(string Str)
        : base(String.Format("Invalid String: {0}", Str))
        {

        }
    }
}
