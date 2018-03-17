# Getting started

API for Ecommerce Partners. This document includes Cart, Discount, Payment, Order and Return related endpoints provided by Global Miles.

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (GlobalMilesEcommerceAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Global%20Miles%20Ecommerce%20API-CSharp&workspaceName=GlobalMilesEcommerceAPI&projectName=GlobalMilesEcommerceAPI.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the GlobalMilesEcommerceAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Global%20Miles%20Ecommerce%20API-CSharp&workspaceName=GlobalMilesEcommerceAPI&projectName=GlobalMilesEcommerceAPI.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Global%20Miles%20Ecommerce%20API-CSharp&workspaceName=GlobalMilesEcommerceAPI&projectName=GlobalMilesEcommerceAPI.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Global%20Miles%20Ecommerce%20API-CSharp&workspaceName=GlobalMilesEcommerceAPI&projectName=GlobalMilesEcommerceAPI.Standard)

### 3. Add reference of the library project

In order to use the GlobalMilesEcommerceAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Global%20Miles%20Ecommerce%20API-CSharp&workspaceName=GlobalMilesEcommerceAPI&projectName=GlobalMilesEcommerceAPI.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` GlobalMilesEcommerceAPI.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```GlobalMilesEcommerceAPI.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Global%20Miles%20Ecommerce%20API-CSharp&workspaceName=GlobalMilesEcommerceAPI&projectName=GlobalMilesEcommerceAPI.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Global%20Miles%20Ecommerce%20API-CSharp&workspaceName=GlobalMilesEcommerceAPI&projectName=GlobalMilesEcommerceAPI.Standard)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| oAuthClientId | OAuth 2 Client ID |
| oAuthClientSecret | OAuth 2 Client Secret |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string oAuthClientId = "oAuthClientId"; // OAuth 2 Client ID
string oAuthClientSecret = "oAuthClientSecret"; // OAuth 2 Client Secret

GlobalMilesEcommerceAPIClient client = new GlobalMilesEcommerceAPIClient(oAuthClientId, oAuthClientSecret);
```


You must now authorize the client.

### Authorizing your client

This SDK uses *OAuth 2.0 authorization* to authorize the client.

The `Authorize()` method will exchange the OAuth client credentials for an *access token*.
The access token is an object containing information for authorizing client requests.


```csharp
try
{
    client.Auth.Authorize();
}
catch (OAuthProviderException e)
{
    //handle exception here
}
```

The client can now make authorized endpoint calls.


### Storing an access token for reuse

It is recommended that you store the access token for reuse.

You can store the access token in a file or a database.

```csharp
// store token
SaveTokenToDatabase(Configuration.OAuthToken);
```

### Creating a client from a stored token

To authorize a client from a stored access token, just set the access token after creating the client:

```csharp
client = GlobalMilesEcommerceAPIClient();
Configuration.UpdateAccessToken(LoadTokenFromDatabase());
```

### Complete example
```csharp
using GlobalMilesEcommerceAPI.Standard;
using GlobalMilesEcommerceAPI.Standard.Models;
using GlobalMilesEcommerceAPI.Standard.Exceptions;
using System.Collections.Generic;

namespace OAuthTestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuration parameters and credentials
           string oAuthClientId = "oAuthClientId"; // OAuth 2 Client ID
           string oAuthClientSecret = "oAuthClientSecret"; // OAuth 2 Client Secret
           
            GlobalMilesEcommerceAPIClient client = new GlobalMilesEcommerceAPIClient(oAuthClientId, oAuthClientSecret);

            //callback for storing token for reuse when token is updated
            Configuration.OAuthTokenUpdateCallback = SaveTokenToDatabase;

            //obtain access token, needed for client to be authorized
            OAuthToken storedToken = LoadTokenFromDatabase();
            if (storedToken != null)
            {
                Configuration.OAuthToken = storedToken;
            }
            else
            {
                try
                {
                    storedToken = client.Auth.Authorize();
                    SaveTokenToDatabase(storedToken);
                }
                catch (OAuthProviderException e)
                {
                    //Handle Exception here
                }
            }
        }

        //function for storing token to database
        static void SaveTokenToDatabase(OAuthToken token)
        {
            //Save token here
        }

        //function for loading token from database
        static OAuthToken LoadTokenFromDatabase()
        {
            OAuthToken token = null;
            //token = Get token here
            return token;
        }
    }
}

// the client is now authorized and you can use controllers to make endpoint calls
```


# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [PayWithMilesPointsController](#pay_with_miles_points_controller)
* [EarnMilesPointsController](#earn_miles_points_controller)
* [AuthenticationController](#authentication_controller)
* [ReturnController](#return_controller)

## <a name="pay_with_miles_points_controller"></a>![Class: ](https://apidocs.io/img/class.png "GlobalMilesEcommerceAPI.Standard.Controllers.PayWithMilesPointsController") PayWithMilesPointsController

### Get singleton instance

The singleton instance of the ``` PayWithMilesPointsController ``` class can be accessed from the API Client.

```csharp
PayWithMilesPointsController payWithMilesPoints = client.PayWithMilesPoints;
```

### <a name="list_point_payments"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesEcommerceAPI.Standard.Controllers.PayWithMilesPointsController.ListPointPayments") ListPointPayments

> This endpoint allows to get list of payments. In order to get detailed payment history and reconciliation you can use this API.


```csharp
Task<Models.ListPointPaymentResponse> ListPointPayments(
        string accept,
        string contentType,
        string authorization,
        string storeCode,
        string filterByCreatedAt,
        string filterByStatus = null,
        string sortBy = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accept |  ``` Required ```  ``` DefaultValue ```  | It advertises which content type is able to understand. |
| contentType |  ``` Required ```  ``` DefaultValue ```  | It tells the client what the content type of the returned. |
| authorization |  ``` Required ```  | It includes OAuth2 token. |
| storeCode |  ``` Required ```  | An identifier for online store. |
| filterByCreatedAt |  ``` Required ```  | Filter for created_at field. It is accepted a valid date range value. The format is YYYY-MM-DD...YYYY-MM-DD. |
| filterByStatus |  ``` Optional ```  | Filter for status field. It is accepted a valid status value of payment. |
| sortBy |  ``` Optional ```  | Sort for some selected fields. In order to sort descending "-" value will be used before the field. Valid field values are "created_at",  "updated_at", "status". |


#### Example Usage

```csharp
string accept = "application/json";
string contentType = "application/json";
string authorization = "Authorization";
string storeCode = "StoreCode";
string filterByCreatedAt = "FilterByCreatedAt";
string filterByStatus = "FilterByStatus";
string sortBy = "SortBy";

Models.ListPointPaymentResponse result = await payWithMilesPoints.ListPointPayments(accept, contentType, authorization, storeCode, filterByCreatedAt, filterByStatus, sortBy);

```


### <a name="create_refund_point_payment"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesEcommerceAPI.Standard.Controllers.PayWithMilesPointsController.CreateRefundPointPayment") CreateRefundPointPayment

> This endpoint allows to refund a payment.


```csharp
Task<Models.Response> CreateRefundPointPayment(
        string accept,
        string contentType,
        string authorization,
        Models.RefundPointPaymentRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accept |  ``` Required ```  ``` DefaultValue ```  | It advertises which content type is able to understand. |
| contentType |  ``` Required ```  ``` DefaultValue ```  | It tells the client what the content type of the returned. |
| authorization |  ``` Required ```  | It includes OAuth2 token. |
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
string accept = "application/json";
string contentType = "application/json";
string authorization = "Authorization";
var body = new Models.RefundPointPaymentRequest();

Models.Response result = await payWithMilesPoints.CreateRefundPointPayment(accept, contentType, authorization, body);

```


### <a name="delete_cancel_point_payment"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesEcommerceAPI.Standard.Controllers.PayWithMilesPointsController.DeleteCancelPointPayment") DeleteCancelPointPayment

> This endpoint allows to cancel a payment.


```csharp
Task<Models.Response> DeleteCancelPointPayment(
        string accept,
        string contentType,
        string authorization,
        Models.CancelPointPaymentRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accept |  ``` Required ```  ``` DefaultValue ```  | It advertises which content type is able to understand. |
| contentType |  ``` Required ```  ``` DefaultValue ```  | It tells the client what the content type of the returned. |
| authorization |  ``` Required ```  | It includes OAuth2 token. |
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
string accept = "application/json";
string contentType = "application/json";
string authorization = "Authorization";
var body = new Models.CancelPointPaymentRequest();

Models.Response result = await payWithMilesPoints.DeleteCancelPointPayment(accept, contentType, authorization, body);

```


### <a name="update_complete_point_payment"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesEcommerceAPI.Standard.Controllers.PayWithMilesPointsController.UpdateCompletePointPayment") UpdateCompletePointPayment

> This endpoint allows to complete a payment.


```csharp
Task<Models.Response> UpdateCompletePointPayment(
        string accept,
        string contentType,
        string authorization,
        Models.CompletePointPaymentRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accept |  ``` Required ```  ``` DefaultValue ```  | It advertises which content type is able to understand. |
| contentType |  ``` Required ```  ``` DefaultValue ```  | It tells the client what the content type of the returned. |
| authorization |  ``` Required ```  | It includes OAuth2 token. |
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
string accept = "application/json";
string contentType = "application/json";
string authorization = "Authorization";
var body = new Models.CompletePointPaymentRequest();

Models.Response result = await payWithMilesPoints.UpdateCompletePointPayment(accept, contentType, authorization, body);

```


### <a name="create_start_point_payment"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesEcommerceAPI.Standard.Controllers.PayWithMilesPointsController.CreateStartPointPayment") CreateStartPointPayment

> After successful authentication and retrieving needed token,this endpoint allows to start a payment transaction. To be able to complete whole sale process successfully  also check "Complete Point Payment endpoint" please.


```csharp
Task<Models.StartPointPaymentResponse> CreateStartPointPayment(
        string accept,
        string contentType,
        string authorization,
        Models.StartPointPaymentRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accept |  ``` Required ```  ``` DefaultValue ```  | It advertises which content type is able to understand. |
| contentType |  ``` Required ```  ``` DefaultValue ```  | It tells the client what the content type of the returned. |
| authorization |  ``` Required ```  | It includes OAuth2 token. |
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
string accept = "application/json";
string contentType = "application/json";
string authorization = "Authorization";
var body = new Models.StartPointPaymentRequest();

Models.StartPointPaymentResponse result = await payWithMilesPoints.CreateStartPointPayment(accept, contentType, authorization, body);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="earn_miles_points_controller"></a>![Class: ](https://apidocs.io/img/class.png "GlobalMilesEcommerceAPI.Standard.Controllers.EarnMilesPointsController") EarnMilesPointsController

### Get singleton instance

The singleton instance of the ``` EarnMilesPointsController ``` class can be accessed from the API Client.

```csharp
EarnMilesPointsController earnMilesPoints = client.EarnMilesPoints;
```

### <a name="create_order_info"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesEcommerceAPI.Standard.Controllers.EarnMilesPointsController.CreateOrderInfo") CreateOrderInfo

> This endpoint allows to create an order for earn a miles / points. It may also include discounts and payments.


```csharp
Task<Models.OrderResponse> CreateOrderInfo(
        string accept,
        string contentType,
        string authorization,
        Models.OrderRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accept |  ``` Required ```  ``` DefaultValue ```  | It advertises which content type is able to understand. |
| contentType |  ``` Required ```  ``` DefaultValue ```  | It tells the client what the content type of the returned. |
| authorization |  ``` Required ```  | It includes OAuth2 token. |
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
string accept = "application/json";
string contentType = "application/json";
string authorization = "Authorization";
var body = new Models.OrderRequest();

Models.OrderResponse result = await earnMilesPoints.CreateOrderInfo(accept, contentType, authorization, body);

```


### <a name="create_cart_info"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesEcommerceAPI.Standard.Controllers.EarnMilesPointsController.CreateCartInfo") CreateCartInfo

> This endpoint allows to get available amount of money, based on miles / points of user and their discounts which is based on cart or items.


```csharp
Task<Models.CartResponse> CreateCartInfo(
        string accept,
        string contentType,
        string authorization,
        Models.CartRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accept |  ``` Required ```  ``` DefaultValue ```  | It advertises which content type is able to understand. |
| contentType |  ``` Required ```  ``` DefaultValue ```  | It tells the client what the content type of the returned. |
| authorization |  ``` Required ```  | It includes OAuth2 token. |
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
string accept = "application/json";
string contentType = "application/json";
string authorization = "Bearer {{auth_token}}";
var body = new Models.CartRequest();

Models.CartResponse result = await earnMilesPoints.CreateCartInfo(accept, contentType, authorization, body);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="authentication_controller"></a>![Class: ](https://apidocs.io/img/class.png "GlobalMilesEcommerceAPI.Standard.Controllers.AuthenticationController") AuthenticationController

### Get singleton instance

The singleton instance of the ``` AuthenticationController ``` class can be accessed from the API Client.

```csharp
AuthenticationController authentication = client.Authentication;
```

### <a name="create_authentication"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesEcommerceAPI.Standard.Controllers.AuthenticationController.CreateAuthentication") CreateAuthentication

> *Tags:*  ``` Skips Authentication ``` 

> An access token will allow you to make requests for the system. We support only one type of token: client_credentials


```csharp
Task<Models.OAuthResponse> CreateAuthentication(string accept, string contentType, Models.OAuthRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accept |  ``` Required ```  ``` DefaultValue ```  | It advertises which content type is able to understand. |
| contentType |  ``` Required ```  ``` DefaultValue ```  | It tells the client what the content type of the returned. |
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
string accept = "application/json";
string contentType = "application/json";
string bodyValue = "{\n  \"client_id\": \"{{client_id}}\",\n  \"client_secret\": \"{{client_secret}}\",\n  \"grant_type\": \"{{grant_type}}\"\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.OAuthRequest>(bodyValue);

Models.OAuthResponse result = await authentication.CreateAuthentication(accept, contentType, body);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="return_controller"></a>![Class: ](https://apidocs.io/img/class.png "GlobalMilesEcommerceAPI.Standard.Controllers.ReturnController") ReturnController

### Get singleton instance

The singleton instance of the ``` ReturnController ``` class can be accessed from the API Client.

```csharp
ReturnController mreturn = client.Return;
```

### <a name="create_start_return"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesEcommerceAPI.Standard.Controllers.ReturnController.CreateStartReturn") CreateStartReturn

> This endpoint allows to start a return for a specific order.


```csharp
Task<Models.StartReturnResponse> CreateStartReturn(
        string accept,
        string contentType,
        string authorization,
        Models.StartReturnRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accept |  ``` Required ```  ``` DefaultValue ```  | It advertises which content type is able to understand. |
| contentType |  ``` Required ```  ``` DefaultValue ```  | It tells the client what the content type of the returned. |
| authorization |  ``` Required ```  | It includes OAuth2 token. |
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
string accept = "application/json";
string contentType = "application/json";
string authorization = "Authorization";
var body = new Models.StartReturnRequest();

Models.StartReturnResponse result = await mreturn.CreateStartReturn(accept, contentType, authorization, body);

```


### <a name="update_complete_return"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesEcommerceAPI.Standard.Controllers.ReturnController.UpdateCompleteReturn") UpdateCompleteReturn

> This endpoint allows to complete a return.


```csharp
Task<Models.Response> UpdateCompleteReturn(
        string accept,
        string contentType,
        string authorization,
        Models.CompleteReturnRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accept |  ``` Required ```  ``` DefaultValue ```  | It advertises which content type is able to understand. |
| contentType |  ``` Required ```  ``` DefaultValue ```  | It tells the client what the content type of the returned. |
| authorization |  ``` Required ```  | It includes OAuth2 token. |
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
string accept = "application/json";
string contentType = "application/json";
string authorization = "Authorization";
var body = new Models.CompleteReturnRequest();

Models.Response result = await mreturn.UpdateCompleteReturn(accept, contentType, authorization, body);

```


### <a name="delete_cancel_return"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesEcommerceAPI.Standard.Controllers.ReturnController.DeleteCancelReturn") DeleteCancelReturn

> This endpoint allows to cancel a return.


```csharp
Task<Models.Response> DeleteCancelReturn(
        string accept,
        string contentType,
        string authorization,
        Models.CancelReturnRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accept |  ``` Required ```  ``` DefaultValue ```  | It advertises which content type is able to understand. |
| contentType |  ``` Required ```  ``` DefaultValue ```  | It tells the client what the content type of the returned. |
| authorization |  ``` Required ```  | It includes OAuth2 token. |
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
string accept = "application/json";
string contentType = "application/json";
string authorization = "Authorization";
var body = new Models.CancelReturnRequest();

Models.Response result = await mreturn.DeleteCancelReturn(accept, contentType, authorization, body);

```


[Back to List of Controllers](#list_of_controllers)



