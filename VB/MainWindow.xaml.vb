Imports DevExpress.Xpf.Reports.UserDesigner
Imports System.Windows


Namespace WpfApp_CustomNumericLabel
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub reportDesigner_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			ReportDesigner.RegisterControl(Of NumericLabel)()
			reportDesigner.OpenDocument(New XtraReport1())
		End Sub
	End Class
End Namespace
