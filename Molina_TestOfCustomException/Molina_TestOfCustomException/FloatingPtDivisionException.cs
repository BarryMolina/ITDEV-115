using System;
using System.Collections.Generic;
using System.Text;

namespace Molina_TestOfCustomException
{
    class FloatingPtDivisionException : ApplicationException
    {
        public FloatingPtDivisionException(string exceptionType) : base(exceptionType) { }
    }
}
