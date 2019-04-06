using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABSClassLibrary
{
    internal interface IProcedureDataLoader
    {
        Dictionary<string, object> LoadProcedureData(string ProcName);
    }

    internal class FooDataLoader : IProcedureDataLoader
    {
        public Dictionary<string, object> LoadProcedureData(string ProcName)
        {
            throw new NotImplementedException();
        }
    }

}