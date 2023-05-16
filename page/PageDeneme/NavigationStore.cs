using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;


namespace PageDeneme
{
    public class NavigationStore
    {
        private ViewModelBase _CurrentViewModel;
        public ViewModelBase CurrentViewModel {
            get=>_CurrentViewModel; set
            {
                _CurrentViewModel = value;
            }
        }
    }
}
