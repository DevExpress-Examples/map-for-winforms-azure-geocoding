

## Map for WinForms - Obtain Information About a Geographical Point from the Microsoft Azure Maps Geocode Service

This example demonstrates how to obtain information about a geographical point from the Azure Geocode service.

> **NOTE:** You need a [key](https://learn.microsoft.com/en-us/azure/azure-maps/quick-demo-map-app#get-the-subscription-key-for-your-account) to use Azure Maps services in your application.

`TextEdit` elements specify a geographical point (GeoPoint.Longitude and GeoPoint.Latitude). The “Request Location Information” button initiates the geocoding request. It obtains the point information and passes it to the [RequestLocationInformation](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.AzureGeocodeDataProvider.RequestLocationInformation.overloads?v=24.2) method.

Results contain an address (LocationInformation.Address) and exact coordinates (LocationInformation.Location), shown in the `MemoEdit` element.

The following image illustrates the result:

![Resulting map](images/image.png)

## Files to Look At

* [Form1.cs](./CS/AzureGeocoding//Form1.cs) (VB: [Form1.vb](./VB/AzureGeocoding/Form1.vb))

## Documentation

* [Geocode](https://docs.devexpress.com/WindowsForms/16712/controls-and-libraries/map-control/gis-data/geocode)

## More Examples 