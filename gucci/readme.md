Welcome to project gucci. A fun hack around geolocation and route management.

<http://gucciapp.azurewebsites.net/>

## Tech stack

* ASP.NET Core MVC
* jQuery
* ESRI ArcGIS
* SQL Server


## Template options

<https://themes.getbootstrap.com/product/dashboard/>
<https://startbootstrap.com/template-overviews/sb-admin/>

To integrate into an ASP.NET Core MVC solution:

* Copy theme folders (CSS, JS, Vendor and SCSS) to your ASP.NET Core 2.0 Project (in wwwroot folder)
* Replace the Layout.cshtml with blank.html code (comes with temlpate
* Make sure to add RenderBody() in content section
* Update all references such as "vendor/bootstrap/css/bootstrap.min.css" will become "~/wwwroot/vendor/bootstrap/css/bootstrap.min.css"
