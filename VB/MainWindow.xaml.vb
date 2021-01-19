Imports DevExpress.Utils
Imports DevExpress.Xpf.Core.Native
Imports DevExpress.Xpf.Reports.UserDesigner
Imports DevExpress.Xpf.Reports.UserDesigner.XRDiagram
Imports System
Imports System.Windows
Imports System.Windows.Media

Namespace WpfApp_CustomNumericLabel
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
			Dim resourceURI = AssemblyHelper.GetResourceUri(Me.GetType().Assembly, "NumericLabel.svg")
'INSTANT VB NOTE: The variable icon was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim icon_Renamed As ImageSource = WpfSvgRenderer.CreateImageSource(resourceURI)
			ReportDesigner.RegisterControl(Of NumericLabel)(Function() New DefaultXRControlDiagramItem(), icon_Renamed)
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			reportDesigner.OpenDocument(New XtraReport1())
		End Sub
	End Class
End Namespace
