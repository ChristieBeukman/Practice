using GalaSoft.MvvmLight;
using Listing.Model;
using System.Windows;
using System.Collections.ObjectModel;
using System.Linq;
using GalaSoft.MvvmLight.Command;

namespace Listing.ViewModel
{
   
    public class MainViewModel : ViewModelBase
    {
        ListModelContext ctx = new ListModelContext();

        #region CategoryItems

        public CategoryItem SelectedCategoryItem
        {
            get
            {
                return selectedCategoryItem;
            }

            set
            {
                selectedCategoryItem = value;
                RaisePropertyChanged("SelectedCategoryItem");
            }
        }

        private CategoryItem selectedCategoryItem;
        public RelayCommand AddCategoryCommand { get; set; }

        public ObservableCollection<CategoryItem> CategoryItems
        {
            get
            {
                return categoryItems;
            }

            set
            {
                categoryItems = value;
                RaisePropertyChanged("CategoryItems");
            }
        }

        private ObservableCollection<CategoryItem> categoryItems;

        void GetCategories()
        {
            CategoryItems = new ObservableCollection<CategoryItem>();
            
            var Query = from a in ctx.CategoryItems
                        select a;
            foreach (var item in Query)
            {
                CategoryItems.Add(item);
            }
        }

        void AddCategory()
        {
            CategoryItem cat = new CategoryItem() { CategoryDescription = "Test", CategoryName = "Test" };
            ctx.CategoryItems.Add(cat);
            ctx.SaveChanges();
            categoryItems.CollectionChanged(RaisePropertyChanged("CategoryItems"));
            MessageBox.Show(cat.CategoryName + " has been added");
            GetCategories();

        }
       
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            GetCategories();
            AddCategoryCommand = new RelayCommand(AddCategory);
        }


        #endregion
    }
}