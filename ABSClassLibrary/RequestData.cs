using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABSClassLibrary
{
    internal abstract class RequestData
    {

    }
    internal class FooRequestData : RequestData
    {

    }
    internal interface IRequestDataLoader
    {
        RequestData LoadRequestData();
    }

    internal class FooRequestDataLoader : IRequestDataLoader
    {
        public RequestData LoadRequestData()
        {
            throw new NotImplementedException();
        }
    }
}
