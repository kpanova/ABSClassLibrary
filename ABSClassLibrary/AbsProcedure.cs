using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABSClassLibrary
{
    internal abstract class AbsProcedure
    {
        public event EventHandler StateChanged; // For Logging Changed State
        internal string Name
        {
            get => default(string);
            set
            {
            }
        }

        internal string ErrorParametrName
        {
            get => default(string);
            set
            {
            }
        }

        internal string MainParametrName
        {
            get => default(string);
            set
            {
            }
        }

        internal IAbsExcecutor AbsExcecutor
        {
            get => default(IAbsExcecutor);
            set
            {
            }
        }

        internal IProcedureDataLoader DataLoader
        {
            get => default(IProcedureDataLoader);
            set
            {
            }
        }

        internal IHasProcedureError HasProcedureError
        {
            get => default(IHasProcedureError);
            set
            {
            }
        }

        internal IMainParametrsGetter MainParametrsGetter
        {
            get => default(IMainParametrsGetter);
            set
            {
            }
        }

        internal Dictionary<string, object> Response
        {
            get => default(Dictionary<string, object>);
            set
            {
            }
        }

        internal bool HasError
        {
            get => default(bool);
            set
            {
            }
        }

        internal string QueryText
        {
            get => default(string);
            set
            {
            }
        }

        internal IRequestDataLoader RequestDataLoader
        {
            get => default(IRequestDataLoader);
            set
            {
            }
        }

        internal RequestData RequestData
        {
            get => default(RequestData);
            set
            {
            }
        }

        protected virtual void OnStateChanged(EventArgs e)
        {
            EventHandler handler = StateChanged;
            handler?.Invoke(this, e);
        }

        internal void LoadData()
        {
            DataLoader.LoadData(Name);
        }
        internal void GetMainParametrs()
        {
            MainParametrsGetter.GetMainParametr(Name, Response, HasError);
        }
        internal void GetProcedureError()
        {
            HasError = HasProcedureError.HasProcedureError(Name, Response);
        }
        internal void LoadRequestData()
        {
            RequestData = RequestDataLoader.LoadRequestData();
        }
    }
}