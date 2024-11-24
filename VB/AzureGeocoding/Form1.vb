Imports DevExpress.XtraMap
Imports System.Text
Imports System.Runtime.InteropServices

Namespace AzureGeocoding

    Public Partial Class Form1
        Inherits Form

        Const key As String = "your key"

        Const msgMinMaxErrorFormatString As String = "The {0} must be less than or equal to {2} and greater than or equal to {1}. Correct the input value."

        Const latitudeName As String = "Latitude"

        Const minLatitude As Double = -90

        Const maxLatitude As Double = 90

        Const longitudeName As String = "Longitude"

        Const minLongitude As Double = -180

        Const maxLongitude As Double = 180

        Private geocodeProvider As AzureGeocodeDataProvider

        Private imageProvider As AzureMapDataProvider

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            imageProvider = New AzureMapDataProvider With {.AzureKey = key}
            ' Create a geocode data provider.
            geocodeProvider = New AzureGeocodeDataProvider With {.AzureKey = key, .MaxVisibleResultCount = 1}
            Me.geocodeProvider.LocationInformationReceived += AddressOf OnLocationInformationReceived
            Me.geocodeProvider.LayerItemsGenerating += AddressOf OnLayerItemsGenerating
            Me.simpleButton1.Click += AddressOf requestLocation_Click
            informationLayer.DataProvider = geocodeProvider
            imageLayer.DataProvider = imageProvider
        End Sub

        Private Sub requestLocation_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim searchPoint As GeoPoint
            If TryGetLocationArguments(searchPoint) Then
                geocodeProvider.RequestLocationInformation(searchPoint)
            End If
        End Sub

        Private Function TryGetLocationArguments(<Out> ByRef point As GeoPoint) As Boolean
            Dim latitude As Double
            Dim longitude As Double
            If Me.TryConvertLocationCoordinate(textEdit1.Text, minLatitude, maxLatitude, latitudeName, latitude) AndAlso Me.TryConvertLocationCoordinate(textEdit2.Text, minLongitude, maxLongitude, longitudeName, longitude) Then
                point = New GeoPoint(latitude, longitude)
                Return True
            End If

            point = Nothing
            Return False
        End Function

        Private Function TryConvertLocationCoordinate(ByVal str As String, ByVal minValue As Double, ByVal maxValue As Double, ByVal valueName As String, <Out> ByRef value As Double) As Boolean
            Dim convertedValue As Double = If([String].IsNullOrEmpty(str), 0, [Double].Parse(str))
            If convertedValue > maxValue OrElse convertedValue < minValue Then
                MessageBox.Show([String].Format(msgMinMaxErrorFormatString, valueName, minValue, maxValue))
                value = 0
                Return False
            End If

            value = convertedValue
            Return True
        End Function

        Private Sub OnLocationInformationReceived(ByVal sender As Object, ByVal e As LocationInformationReceivedEventArgs)
            If e.Cancelled Is True Then Return
            If e.Result.ResultCode IsNot RequestResultCode.Success Then
                memoEdit1.Text = "The Bing Geocode service does not work for this location."
                Return
            End If

            Dim resultList As StringBuilder = New StringBuilder("")
            Dim resCounter As Integer = 1
            For Each locations As LocationInformation In e.Result.Locations
                resultList.Append([String].Format("Request Result {0}:" & Microsoft.VisualBasic.Constants.vbCrLf, resCounter))
                resultList.Append([String].Format(locations.EntityType & Microsoft.VisualBasic.Constants.vbCrLf))
                resultList.Append([String].Format(locations.Address.FormattedAddress & Microsoft.VisualBasic.Constants.vbCrLf))
                resultList.Append([String].Format("Coordinates: {0}" & Microsoft.VisualBasic.Constants.vbCrLf, locations.Location))
                resultList.Append([String].Format("______________________________" & Microsoft.VisualBasic.Constants.vbCrLf))
                resCounter += 1
            Next

            memoEdit1.Text = resultList.ToString()
        End Sub

        Private Sub OnLayerItemsGenerating(ByVal sender As Object, ByVal e As LayerItemsGeneratingEventArgs)
            mapControl1.ZoomToFit(e.Items, 0.4)
        End Sub
    End Class
End Namespace
