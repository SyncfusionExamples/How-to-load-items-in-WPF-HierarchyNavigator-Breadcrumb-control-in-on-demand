using System.IO;
using System.Windows;

namespace HierarchyNavigator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Hierarchy_HierarchyNavigatorSelectedItemChanged(object sender, Syncfusion.Windows.Tools.Controls.HierarchyNavigatorSelectedItemChangedEventArgs e)
        {
            if (hierarchy.SelectedItem == null)
                return;
            HierarchicalModel selectedItem = hierarchy.SelectedItem as HierarchicalModel;
            string[] dirs = Directory.GetDirectories(selectedItem.Content, "*", SearchOption.TopDirectoryOnly);
            foreach (string dir in dirs)
            {
                selectedItem.FileItems.Add(new HierarchicalModel(dir));
            }
        }
    }    
}

