using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace w07p01_okna
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_otwieranie_pliku_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog oknoOtwieraniaPliku = new Microsoft.Win32.   OpenFileDialog();
            oknoOtwieraniaPliku.Title = "Wybierz plik do otwarcia";
            oknoOtwieraniaPliku.Filter = "Pliki c++ (*.cpp)|*.cpp|Wszystkie pliki (*.*)|*.*";
            oknoOtwieraniaPliku.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            oknoOtwieraniaPliku.ShowDialog();
            textBlock.Text = oknoOtwieraniaPliku.FileName.ToString();

        }

        private void btn_zapios_dozapis_pliku_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog okno_zapisu = new Microsoft.Win32.SaveFileDialog();
            okno_zapisu.Title = "Zapisz plik";
            okno_zapisu.Filter = "Pliki c++ (*.cpp)|*.cpp|Wszystkie pliki (*.*)|*.*";
            okno_zapisu.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            okno_zapisu.DefaultExt = ".cpp";
            okno_zapisu.ShowDialog();
            textBlock.Text = okno_zapisu.FileName.ToString();
        }

        private void btn_wybor_fontowu_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FontDialog okno_wyboru_fontow = new System.Windows.Forms.FontDialog();
            
            okno_wyboru_fontow.ShowDialog();
            textBlock.FontFamily = new System.Windows.Media.FontFamily(okno_wyboru_fontow.Font.Name);
            textBlock.FontSize = okno_wyboru_fontow.Font.Size;
            textBlock.Text = okno_wyboru_fontow.Font.ToString();

        }

        private void btn_wybor_koloru_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.ColorDialog okno_wyboru_koloru = new System.Windows.Forms.ColorDialog();
            okno_wyboru_koloru.ShowDialog();
            textBlock.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(okno_wyboru_koloru.Color.R, okno_wyboru_koloru.Color.G, okno_wyboru_koloru.Color.B));
        }
    }
}