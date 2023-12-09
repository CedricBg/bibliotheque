using bibliotheque.DataAccess.Services;
using bibliotheque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheque.ViewModel;
    public partial class AddBookPageViewModel : BaseViewModel
    {
    private readonly BookService bookService;


    public string name { get; set; }

    [ObservableProperty]
    string _description, _author, _title, _publishingHouse;

    [RelayCommand]
    public async void Back()
    {
        await Shell.Current.GoToAsync("..");
    }

    public AddBookPageViewModel(BookService Service)
    {
        bookService = Service;
    }

    [RelayCommand]
    public async void AddBook()
    {
        Book book = new Book
        {
            Description = Description,
            Author = Author,
            Language = "French",
            Title = Title,
            Type = "SF",
            PublishingHouse = PublishingHouse
        };
        await Shell.Current.DisplayAlert("Ok", book.Title,"Ok");
        int result = await bookService.SaveBookAsync(book);

    }


    
}
