using DemoDevExpress1.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DemoDevExpress1.ViewModels;

public class UserViewModel : INotifyPropertyChanged
{
    private ObservableCollection<User> users = new ObservableCollection<User>();

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<User> Users
    {
        get { return users; }
        set
        {
            users = value;
            OnPropertyChanged();
        }
    }

    public void AddUser(string fullname, string username, string password, string email, DateTime birthday)
    {
        var user = new User
        {
            Fullname = fullname,
            Username = username,
            Password = password,
            Email = email,
            Birthday = birthday,
        };

        Users.Add(user);
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}