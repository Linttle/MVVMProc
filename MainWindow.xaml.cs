using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MVVMProc.ViewModel;
using MVVMProc.Model;

namespace MVVMProc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Procedure proc = new Procedure("procedure a", "procA");
            Procedure proc2 = new Procedure("procedure b", "procB");
            List<Procedure> procList = new List<Procedure>();
            procList.Add(proc);
            procList.Add(proc2);
            RootViewModel rootViewModel = new RootViewModel(procList);
            base.DataContext = rootViewModel;
            List <RootViewModel> rootList = new List<RootViewModel>();
            rootList.Add(rootViewModel);
            TreeViewViewModel viewModel = new TreeViewViewModel(rootList);
            base.DataContext = viewModel;
        }

        public void Delete_Click(object sender, RoutedEventArgs e)
        {
            TreeViewItemViewModel item = (TreeViewItemViewModel)procedureTree.SelectedItem;
            if (item != null)
            {
                item.Parent.Children.Remove(item);
            }
        }

    }
}
