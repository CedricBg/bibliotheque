
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace bibliotheque.ViewModel
{
    public partial class IndexPageviewModel: BaseViewModel
    {
        [ObservableProperty]
        string? _login;

        [RelayCommand]
        public void Testing()
        {
                Login = "test";
        }

        


    }
}
