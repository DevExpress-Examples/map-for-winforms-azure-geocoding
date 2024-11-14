<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/888567088/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1263354)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->


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
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=map-for-winforms-azure-geocoding&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=map-for-winforms-azure-geocoding&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
