
using bibliotheque.DataAccess.Services;
using bibliotheque.Model;
using bibliotheque.View;


namespace bibliotheque.ViewModel
{
    public partial class IndexPageviewModel: BaseViewModel
    {
        private readonly BookService bookService;

        [ObservableProperty]
        List<Book> _books;
        

        public IndexPageviewModel(BookService service)
        {
            bookService = service;
        }

        [RelayCommand]
        async Task Appearing()
        {
          Books =  await bookService.GetBooksAsync();
        }


        [RelayCommand]
        public async void AddBook()
        {
            await Shell.Current.GoToAsync(nameof(AddBookPage)); 
        }
    }
}
