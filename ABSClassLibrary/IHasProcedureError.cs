using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABSClassLibrary
{
    internal interface IHasProcedureError
    {
        bool HasProcedureError(string procName, Dictionary<string, object> response);
    }
    internal class FooHasProcedureError : IHasProcedureError
    {
        public bool HasProcedureError(string procName, Dictionary<string, object> response)
        {
            throw new NotImplementedException();
        }
    }
}