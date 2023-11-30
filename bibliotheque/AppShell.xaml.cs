using bibliotheque.View;

namespace bibliotheque
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(IndexPage), typeof(IndexPage));
            Routing.RegisterRoute(nameof(AddBookPage), typeof(AddBookPage));

        }
    }
}
