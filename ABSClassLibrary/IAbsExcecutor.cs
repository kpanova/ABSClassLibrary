using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABSClassLibrary
{
    internal interface IAbsExcecutor
    {
        void Excecut(AbsProcedure absProcedure);
    }

    internal class AbsProcedureExcecutor : IAbsExcecutor
    {
        public void Excecut(AbsProcedure absProcedure)
        {
            /*Any Code For Excecuting*/
            absProcedure.GetProcedureError();
            absProcedure.GetMainParametrs();
            absProcedure.StateChanged += c_StateChanged;
        }


        static void c_StateChanged(object sender, EventArgs e)
        {
            Console.WriteLine("The threshold was reached.");
            Environment.Exit(0);
        }
    }
}