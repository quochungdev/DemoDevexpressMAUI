
using AndroidX.Lifecycle;
using DemoDevExpress1.Models;
using DemoDevExpress1.ViewModels;
using Microsoft.Maui.Controls;

namespace DemoDevExpress1.Pages;


public partial class CategoriesPage : ContentPage
{
    private CategoryViewModel viewModel = App.CategoryViewModel;

    public CategoriesPage()
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}