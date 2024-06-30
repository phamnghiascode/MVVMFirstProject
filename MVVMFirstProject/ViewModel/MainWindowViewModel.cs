using MVVMFirstProject.Model;
using MVVMFirstProject.MVVM;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVMFirstProject.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }

        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();
            Items.Add(new Item()
            {
                Name = "Product1",
                Description = "Description1",
                Quantity = 1,
            });
            Items.Add(new Item()
            {
                Name = "Product2",
                Description = "Description2",
                Quantity = 2,
            });
            Items.Add(new Item()
            {
                Name = "Product3",
                Description = "Description3",
                Quantity = 3,
            });

        }

        private Item selectedItem;


        public Item SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged();
            }
        }

       

    }
}
