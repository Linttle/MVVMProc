using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMProc.Model;

namespace MVVMProc.ViewModel
{
    public class ProcedureViewModel : TreeViewItemViewModel
    {
        // Every ProcedureViewModel will have a procedure attached to itself
        // Note that every Procedure will have a list of Children Procedures in its TreeViewItemViewModel superclass
        readonly Procedure procedure;

        // For procedures that are a child of Root
        public ProcedureViewModel(RootViewModel parent, Procedure procedure)
            : base(parent)
        {
            this.procedure = procedure;
        }

        // For procedures that are a child of Procedure
        public ProcedureViewModel(ProcedureViewModel parent, Procedure procedure)
            : base(parent)
        {
            this.procedure = procedure;
        }

        public string ProcName
        {
            get { return procedure.ProcName; }
        }
    }
}
