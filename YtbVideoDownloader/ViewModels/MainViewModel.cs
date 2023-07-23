using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using YtbVideoDownloader.Commands;

namespace YtbVideoDownloader.ViewModels
{
    public class MainViewModel
    {
        public MainWindow MainWindow { get; set; }
        public RelayCommand DownloadCommand { get; set; }
        public MainViewModel(MainWindow mainWindow)
        {
            MainWindow=mainWindow;
            DownloadCommand=new RelayCommand(obj =>
            {
                MessageBox.Show("Hele ki hazir deyil!");
               
                for (int i = 0; i < 100; i++)
                {
                    mainWindow.progressBar.Value++;
                }
            });
        }
    }
}
