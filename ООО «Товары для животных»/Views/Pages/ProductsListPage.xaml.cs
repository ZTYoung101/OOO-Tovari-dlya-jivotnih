﻿using System.Windows.Controls;
using ООО__Товары_для_животных_.ViewModels;
using ООО__Товары_для_животных_.ViewModels.ClasesOfInterfaces;

namespace ООО__Товары_для_животных_.Views.Pages;

public partial class ProductsListPage : Page
{
    public ProductsListPage(MainViewModel mainViewModel)
    {
        InitializeComponent();

        DataContext = new ProductsListViewModel(mainViewModel, new AlSearchProduct());
    }
}