using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABSClassLibrary
{
    public interface IMainParametrsGetter
    {
        string GetMainParametr(string procName, Dictionary<string, object> response, bool hasError);
    }
    internal class FooMainParametrsGetter : IMainParametrsGetter
    {
        public string GetMainParametr(string procName, Dictionary<string, object> response, bool hasError)
        {
            throw new NotImplementedException();
        }
    }
}