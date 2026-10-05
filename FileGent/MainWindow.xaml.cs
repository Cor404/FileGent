using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace FileGent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                // Можно проверить, готов ли диск (например, DVD может быть не вставлен)
                if (drive.IsReady)
                {
                    ListViewItem item = new ListViewItem();
                    TextBlock tbl = new TextBlock();

                    tbl.Text = $"Диск: {drive.Name}\n" +
                                    $"Тип: {drive.DriveType}\n" +
                                    $"Файловая система: {drive.DriveFormat}\n" +
                                    $"Метка: {drive.VolumeLabel}\n" +
                                    $"Всего: {drive.TotalSize / 1024 / 1024 / 1024} ГБ\n" +
                                    $"Свободно: {drive.AvailableFreeSpace / 1024 / 1024 / 1024} ГБ\n";
                                    

                    item.Content = tbl;
                    item.Margin = new Thickness(4);
                    lvListDisk.Items.Add(item);

                    // Или детальная информация
                    // txtInfo.Text += $"Диск: {drive.Name}\n" +
                    //                $"Тип: {drive.DriveType}\n" +
                    //                $"Файловая система: {drive.DriveFormat}\n" +
                    //                $"Метка: {drive.VolumeLabel}\n" +
                    //                $"Свободно: {drive.AvailableFreeSpace} байт\n\n";
                }
            }
        }
    }
}