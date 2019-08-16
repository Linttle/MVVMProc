using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace MVVMProc.ViewModel
{
    public class TreeViewItemViewModel : INotifyPropertyChanged
    {
        ObservableCollection<TreeViewItemViewModel> children;
        TreeViewItemViewModel parent;

        bool isExpanded;
        bool isSelected;

        // Constructors
        protected TreeViewItemViewModel(TreeViewItemViewModel parent)
        {
            this.parent = parent;
            children = new ObservableCollection<TreeViewItemViewModel>();
        }

        public TreeViewItemViewModel() { }

        public TreeViewItemViewModel Parent
        {
            get { return parent; }
        }

        public ObservableCollection<TreeViewItemViewModel> Children
        {
            get { return children; }
        }

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                if (value != isSelected)
                {
                    isSelected = value;
                    this.OnPropertyChanged("IsSelected");
                }
            }
        }

        public bool IsExpanded
        {
            get { return isExpanded; }
            set
            {
                if (value != isExpanded)
                {
                    isExpanded = value;
                    this.OnPropertyChanged("IsExpanded");
                }

            }
        }

        // Invoked when child items need to be loaded on demand
        // Subclasses can override this to populate Children collection
        protected virtual void LoadChildren()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
