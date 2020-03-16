using System.Collections.ObjectModel;

namespace HierarchyNavigator
{
    public class HierarchicalModel
    {
        public HierarchicalModel(string content, params HierarchicalModel[] items)
        {
            Content = content;
            fileItems = new ObservableCollection<HierarchicalModel>();
            foreach (var item in items)
            {
                fileItems.Add(item);
            }
        }

        private ObservableCollection<HierarchicalModel> fileItems;

        public ObservableCollection<HierarchicalModel> FileItems
        {
            get { return fileItems; }
            set
            {
                if (fileItems != value)
                {
                    fileItems = value;
                }
            }
        }

        public string Content { get; set; }
    }
}