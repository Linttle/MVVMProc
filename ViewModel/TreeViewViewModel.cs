using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MVVMProc.ViewModel
{
    class TreeViewViewModel
    {
        readonly ObservableCollection<RootViewModel> rootList;

        public TreeViewViewModel(List<RootViewModel> list)
        {
            rootList = new ObservableCollection<RootViewModel>(list);
        }

        public ObservableCollection<RootViewModel> Roots
        {
            get { return rootList; }
        }
    }
}
