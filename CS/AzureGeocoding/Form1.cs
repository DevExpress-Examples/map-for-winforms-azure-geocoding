using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.Utils.Design;
using DevExpress.XtraMap;
using System.Text;
using System.Windows.Forms;

namespace AzureGeocoding {
    public partial class Form1 : Form {
        const string key = "your key";
        const string msgMinMaxErrorFormatString = "The {0} must be less than or equal to {2} and greater than or equal to {1}. Correct the input value.";
        const string latitudeName = "Latitude";
        const double minLatitude = -90;
        const double maxLatitude = 90;
        const string longitudeName = "Longitude";
        const double minLongitude = -180;
        const double maxLongitude = 180;

        AzureGeocodeDataProvider geocodeProvider;
        AzureMapDataProvider imageProvider;
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            imageProvider = new AzureMapDataProvider {
                AzureKey = key
            };
           
            // Create a geocode data provider.
            geocodeProvider = new AzureGeocodeDataProvider {
                AzureKey = key,
                MaxVisibleResultCount = 1
            };
            geocodeProvider.LocationInformationReceived += OnLocationInformationReceived;
            geocodeProvider.LayerItemsGenerating += OnLayerItemsGenerating;
            simpleButton1.Click += requestLocation_Click;
            informationLayer.DataProvider = geocodeProvider;
            imageLayer.DataProvider = imageProvider;

        }
        private void requestLocation_Click(object sender, System.EventArgs e) {
            GeoPoint searchPoint;
            if (TryGetLocationArguments(out searchPoint)) {
                geocodeProvider.RequestLocationInformation(searchPoint);
            }
        }
        bool TryGetLocationArguments(out GeoPoint point) {
            double latitude;
            double longitude;
            if (
                TryConvertLocationCoordinate(textEdit1.Text, minLatitude, maxLatitude, latitudeName, out latitude) &&
                TryConvertLocationCoordinate(textEdit2.Text, minLongitude, maxLongitude, longitudeName, out longitude)) {
                point = new GeoPoint(latitude, longitude);
                return true;
            }
            point = null;
            return false;
        }
        bool TryConvertLocationCoordinate(string str, double minValue, double maxValue, string valueName, out double value) {
            double convertedValue = String.IsNullOrEmpty(str)
                ? 0
                : Double.Parse(str);
            if ((convertedValue > maxValue) || (convertedValue < minValue)) {
                MessageBox.Show(String.Format(msgMinMaxErrorFormatString, valueName, minValue, maxValue));
                value = 0;
                return false;
            }
            value = convertedValue;
            return true;

        }
        private void OnLocationInformationReceived(object sender, LocationInformationReceivedEventArgs e) {
            if (e.Cancelled == true) return;
            if (e.Result.ResultCode != RequestResultCode.Success) {
                memoEdit1.Text = "The Bing Geocode service does not work for this location.";
                return;
            }
            StringBuilder resultList = new StringBuilder("");
            int resCounter = 1;
            foreach (LocationInformation locations in e.Result.Locations) {
                resultList.Append(String.Format("Request Result {0}:\r\n", resCounter));
                resultList.Append(String.Format(locations.EntityType + "\r\n"));
                resultList.Append(String.Format(locations.Address.FormattedAddress + "\r\n"));
                resultList.Append(String.Format("Coordinates: {0}\r\n", locations.Location));
                resultList.Append(String.Format("______________________________\r\n"));
                resCounter++;
            }
            memoEdit1.Text = resultList.ToString();
        }
        private void OnLayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs e) {
            mapControl1.ZoomToFit(e.Items, 0.4);
        }
    }
}
