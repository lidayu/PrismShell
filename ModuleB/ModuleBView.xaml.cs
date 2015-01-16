using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Practices.Prism.Events;

namespace Doy.Modules
{
    /// <summary>
    /// Interaction logic for ModuleB.xaml
    /// </summary>
    public partial class ModuleBView : UserControl
    {
        public ModuleBView(IVM_ModuleB viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
