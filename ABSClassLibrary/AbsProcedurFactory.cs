using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABSClassLibrary
{
    abstract internal class AbsProcedurFactory
    {
        abstract internal AbsProcedure CreateAbsProcedure(string AbsProcedurName);
        Dictionary<string, AbsProcedure> ProcedurFactory = new Dictionary<string, AbsProcedure>
        {
            {"FooAbsProcedure", new FooAbsProcedureFactory().CreateAbsProcedure("FooAbsProcedure") }
        };
    }

    internal class FooAbsProcedureFactory : AbsProcedurFactory
    {

        internal override AbsProcedure CreateAbsProcedure(string AbsProcedurName)
        {
            IProcedureDataLoader dataLoader = new FooDataLoader();
            IMainParametrsGetter parametrsGetter = new FooMainParametrsGetter();
            IHasProcedureError procedureError = new FooHasProcedureError();
            IRequestDataLoader requestDataLoader = new FooRequestDataLoader();
            AbsProcedure absProcedure = new FooAbsProcedure(AbsProcedurName, dataLoader, parametrsGetter, procedureError, requestDataLoader);
            absProcedure.LoadProcedureData();
            absProcedure.LoadRequestData();
            return absProcedure;
        }
    }
}