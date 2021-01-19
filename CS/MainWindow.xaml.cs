using DevExpress.Utils;
using DevExpress.Xpf.Core.Native;
using DevExpress.Xpf.Reports.UserDesigner;
using DevExpress.Xpf.Reports.UserDesigner.XRDiagram;
using System;
using System.Windows;
using System.Windows.Media;

namespace WpfApp_CustomNumericLabel {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            var resourceURI = AssemblyHelper.GetResourceUri(GetType().Assembly, "NumericLabel.svg");
            ImageSource icon = WpfSvgRenderer.CreateImageSource(resourceURI);
            ReportDesigner.RegisterControl<NumericLabel>(() => new DefaultXRControlDiagramItem(), icon);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            reportDesigner.OpenDocument(new XtraReport1());
        }
    }
}
