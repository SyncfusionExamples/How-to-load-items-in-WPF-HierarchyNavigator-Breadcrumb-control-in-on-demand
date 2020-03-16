using System.Collections.ObjectModel;

namespace HierarchyNavigator
{
    public class HierarchicalViewModel
    {
        public HierarchicalViewModel()
        {
            hierarchyItems = new ObservableCollection<HierarchicalModel>();
            this.hierarchyItems.Add(
                new HierarchicalModel("My Files",
                new HierarchicalModel("D:\\"),
                new HierarchicalModel("C:\\"))
                );
        }

        private ObservableCollection<HierarchicalModel> hierarchyItems;

        public ObservableCollection<HierarchicalModel> HierarchyItems
        {
            get { return hierarchyItems; }
            set { hierarchyItems = value; }
        }       
    }
}
