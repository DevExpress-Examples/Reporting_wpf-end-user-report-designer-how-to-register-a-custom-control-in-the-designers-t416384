using DevExpress.Xpf.Reports.UserDesigner;
using System.Windows;


namespace WpfApp_CustomNumericLabel {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void reportDesigner_Loaded(object sender, RoutedEventArgs e) {
            ReportDesigner.RegisterControl<NumericLabel>();
            reportDesigner.OpenDocument(new XtraReport1());
        }
    }
}
