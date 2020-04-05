using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.ViewModels
{
    class MainWinViewModel
    {
        public string CurrentTime
        {
            get
            {
                DateTime current = DateTime.Now;
                return current.ToString("HH:mm:ss");
            }
        }
        public event EventHandler CurrentTimeChanged;

        public MainWinViewModel()
        {
        }

        public void RefreshTime()
        {
            CurrentTimeChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
