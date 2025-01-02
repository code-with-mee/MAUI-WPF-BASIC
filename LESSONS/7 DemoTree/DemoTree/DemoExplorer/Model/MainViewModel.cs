using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExplorer
{
    public class MainViewModel
    {
        public ObservableCollection<ListViewItemModel> Items { get; set; }

        public MainViewModel()
        {
            Items = new ObservableCollection<ListViewItemModel>
            {
                new ListViewItemModel { Icon = "pack://application:,,,/Images/folder.png", Name = "Documents" },
                new ListViewItemModel { Icon = "pack://application:,,,/Images/folder.png", Name = "Pictures" }
            };

            for(int i= 1; i < 10;i++)
            {
                Items.Add(new ListViewItemModel { Icon = "pack://application:,,,/Images/folder.png", Name = "Folder"+i });
            }

            for (int i = 1; i < 5; i++)
            {
                Items.Add(new ListViewItemModel { Icon = "pack://application:,,,/Images/file.png", Name = "File" + i });
            }
        }
    }

}
