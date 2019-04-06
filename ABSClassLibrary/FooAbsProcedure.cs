using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABSClassLibrary
{
    internal class FooAbsProcedure : AbsProcedure
    {
        public FooAbsProcedure(
            string procName,
            IProcedureDataLoader dataLoader,
            IMainParametrsGetter parametrsGetter,
            IHasProcedureError procedureError,
            IRequestDataLoader requestDataLoader
            )
        {
            this.Name = procName;
            DataLoader = dataLoader;
            MainParametrsGetter = parametrsGetter;
            HasProcedureError = procedureError;
        }
    }
}