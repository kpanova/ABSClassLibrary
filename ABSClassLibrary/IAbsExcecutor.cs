using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABSClassLibrary
{
    internal interface IAbsExcecutor
    {
        void Excecut(string absProcedureName);
    }

    internal class AbsProcedureExcecutor : IAbsExcecutor
    {
        public void Excecut(string absProcedureName)
        {
            /*Any Code For Excecuting*/
            var absProcedure = AbsProcedurFactory.ProcedurFactory(absProcedureName);
            absProcedure.GetProcedureError();
            absProcedure.GetMainParametrs();
            absProcedure.StateChanged += c_StateChanged;
        }


        static void c_StateChanged(object sender, EventArgs e)
        {
            Console.WriteLine("The current State Changed.");
            Environment.Exit(0);
        }
    }
}