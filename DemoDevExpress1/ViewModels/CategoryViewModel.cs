using Android.Webkit;
using DemoDevExpress1.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace DemoDevExpress1.ViewModels;

public class CategoryViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Category> categories = new ObservableCollection<Category>();

    public event PropertyChangedEventHandler PropertyChanged;

    public CategoryViewModel()
    {
        if (categories != null)
        {
            categories.Add(new Category { Name = "Category 1", Price = 35, ImageUrl = "hoodie.png" });
            categories.Add(new Category { Name = "Category 2", Price = 35, ImageUrl = "jacket.png" });
            categories.Add(new Category { Name = "Category 3", Price = 35, ImageUrl = "tshirt.png" });
        }

        PullToRefreshCommand = new Command(ExecutePullToRefreshCommand);
    }

    public ObservableCollection<Category> Categories
    {
        get { return categories; }
        set
        {
            categories = value;
            OnPropertyChanged();
        }
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public void AddCategory(string name, double price, string imageUrl)
    {
        var category = new Category
        {
            Name = name,
            Price = price,
            ImageUrl = imageUrl
        };

        categories.Add(category);
    }


    bool isRefreshing = false;
    public bool IsRefreshing
    {
        get { return isRefreshing; }
        set
        {
            if (isRefreshing != value)
            {
                isRefreshing = value;
                OnPropertyChanged("IsRefreshing");
            }
        }
    }

    ICommand pullToRefreshCommand = null;
    public ICommand PullToRefreshCommand
    {
        //get
        //{
        //    return new Command(async () =>
        //    {
        //        AddCategory("Category 4", 40, "shoes.png");
        //        IsRefreshing = false;
        //    });
        //}
        get { return pullToRefreshCommand; }
        set
        {
            if (pullToRefreshCommand != value)
            {
                pullToRefreshCommand = value;
                OnPropertyChanged("PullToRefreshCommand");
            }
        }
    }

    void ExecutePullToRefreshCommand()
    {
        Task.Run(() =>
        {
            IsRefreshing = false;
        });
    }
}
