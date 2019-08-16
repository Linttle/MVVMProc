using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MVVMProc.Model;
using System.Collections.ObjectModel;

namespace MVVMProc.ViewModel
{
    public class RootViewModel : TreeViewItemViewModel
    {
        readonly ObservableCollection<ProcedureViewModel> procedures;
        readonly string rootName = "Root";

        public RootViewModel(List<Procedure> proceduresList)
            : base(null)
        {
            List<ProcedureViewModel> childrenProcs = new List<ProcedureViewModel>();
            foreach (Procedure p in proceduresList)
            {
                ProcedureViewModel procViewModel = new ProcedureViewModel(this, p);
                childrenProcs.Add(procViewModel);
                base.Children.Add(procViewModel);
            }
            procedures = new ObservableCollection<ProcedureViewModel>(childrenProcs);
        }

        public ObservableCollection<ProcedureViewModel> Procedures
        {
            get { return procedures; }
        }

        public string RootName
        {
            get { return rootName; }
        }
    }
}
