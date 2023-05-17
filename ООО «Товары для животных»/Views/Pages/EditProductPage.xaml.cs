using System.Windows.Controls;
using ООО__Товары_для_животных_.Models;
using ООО__Товары_для_животных_.ViewModels;
using ООО__Товары_для_животных_.ViewModels.ClasesOfInterfaces;

namespace ООО__Товары_для_животных_.Views.Pages;

public partial class EditProductPage : Page
{
    public EditProductPage(Product product, MainViewModel mainViewModel)
    {
        InitializeComponent();

        DataContext = new EditProductViewModel(product, mainViewModel, new ALGetModels());
    }
}