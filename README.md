# Getting started

API for E-commerce Partners. This document includes Cart, Discount, Payment, Order and Return related endpoints provided by Global Miles.

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (GlobalMilesECommerceAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Global%20Miles%20E-commerce%20API-CSharp&workspaceName=GlobalMilesECommerceAPI&projectName=GlobalMilesECommerceAPI.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the GlobalMilesECommerceAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Global%20Miles%20E-commerce%20API-CSharp&workspaceName=GlobalMilesECommerceAPI&projectName=GlobalMilesECommerceAPI.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Global%20Miles%20E-commerce%20API-CSharp&workspaceName=GlobalMilesECommerceAPI&projectName=GlobalMilesECommerceAPI.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Global%20Miles%20E-commerce%20API-CSharp&workspaceName=GlobalMilesECommerceAPI&projectName=GlobalMilesECommerceAPI.Standard)

### 3. Add reference of the library project

In order to use the GlobalMilesECommerceAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Global%20Miles%20E-commerce%20API-CSharp&workspaceName=GlobalMilesECommerceAPI&projectName=GlobalMilesECommerceAPI.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` GlobalMilesECommerceAPI.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```GlobalMilesECommerceAPI.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Global%20Miles%20E-commerce%20API-CSharp&workspaceName=GlobalMilesECommerceAPI&projectName=GlobalMilesECommerceAPI.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Global%20Miles%20E-commerce%20API-CSharp&workspaceName=GlobalMilesECommerceAPI&projectName=GlobalMilesECommerceAPI.Standard)

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

GlobalMilesECommerceAPIClient client = new GlobalMilesECommerceAPIClient(oAuthClientId, oAuthClientSecret);
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
client = GlobalMilesECommerceAPIClient();
Configuration.UpdateAccessToken(LoadTokenFromDatabase());
```

### Complete example
```csharp
using GlobalMilesECommerceAPI.Standard;
using GlobalMilesECommerceAPI.Standard.Models;
using GlobalMilesECommerceAPI.Standard.Exceptions;
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
           
            GlobalMilesECommerceAPIClient client = new GlobalMilesECommerceAPIClient(oAuthClientId, oAuthClientSecret);

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

* [EarnMilesController](#earn_miles_controller)
* [AuthenticationController](#authentication_controller)
* [ReturnController](#return_controller)
* [PayWithMilesController](#pay_with_miles_controller)

## <a name="earn_miles_controller"></a>![Class: ](https://apidocs.io/img/class.png "GlobalMilesECommerceAPI.Standard.Controllers.EarnMilesController") EarnMilesController

### Get singleton instance

The singleton instance of the ``` EarnMilesController ``` class can be accessed from the API Client.

```csharp
EarnMilesController earnMiles = client.EarnMiles;
```

### <a name="list_orders"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesECommerceAPI.Standard.Controllers.EarnMilesController.ListOrders") ListOrders

> This endpoint allows to get list of orders. In order to get detailed order history and reconciliation you can use this endpoint.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.ListOrderResponse> ListOrders(
        string filterStoreCode,
        string filterCompletedAt,
        string filterStatus = null,
        string sort = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| filterStoreCode |  ``` Required ```  | Filter for an online store. |
| filterCompletedAt |  ``` Required ```  | Filter for completed_at field. It is accepted a valid date range value. The format is YYYY-MM-DD..YYYY-MM-DD. |
| filterStatus |  ``` Optional ```  | Filter for status field. It is accepted a valid status value of order. |
| sort |  ``` Optional ```  | Sort for some selected fields. In order to sort descending "-" value will be used before the field. Valid field values are "completed_at", "created_at",  "updated_at", "status". |


#### Example Usage

```csharp
string filterStoreCode = "filter[store_code]";
string filterCompletedAt = "filter[completed_at]";
string filterStatus = "filter[status]";
string sort = "sort";

Models.ListOrderResponse result = await earnMiles.ListOrders(filterStoreCode, filterCompletedAt, filterStatus, sort);

```


### <a name="create_order"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesECommerceAPI.Standard.Controllers.EarnMilesController.CreateOrder") CreateOrder

> This endpoint allows to create an order for earn miles. It may also include discounts and payments.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.OrderResponse> CreateOrder(Models.OrderRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.OrderRequest();

Models.OrderResponse result = await earnMiles.CreateOrder(body);

```


### <a name="retrieve_order"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesECommerceAPI.Standard.Controllers.EarnMilesController.RetrieveOrder") RetrieveOrder

> This endpoint allows to get an order.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.RetrieveOrderResponse> RetrieveOrder(string transactionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| transactionId |  ``` Required ```  | The ID of the transaction that represents the order. |


#### Example Usage

```csharp
string transactionId = "transaction_id";

Models.RetrieveOrderResponse result = await earnMiles.RetrieveOrder(transactionId);

```


### <a name="create_cart"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesECommerceAPI.Standard.Controllers.EarnMilesController.CreateCart") CreateCart

> This endpoint allows to get available amount of money, based on miles of user and their discounts which is based on cart or items.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.CartResponse> CreateCart(Models.CartRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.CartRequest();

Models.CartResponse result = await earnMiles.CreateCart(body);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="authentication_controller"></a>![Class: ](https://apidocs.io/img/class.png "GlobalMilesECommerceAPI.Standard.Controllers.AuthenticationController") AuthenticationController

### Get singleton instance

The singleton instance of the ``` AuthenticationController ``` class can be accessed from the API Client.

```csharp
AuthenticationController authentication = client.Authentication;
```

### <a name="create_authentication"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesECommerceAPI.Standard.Controllers.AuthenticationController.CreateAuthentication") CreateAuthentication

> *Tags:*  ``` Skips Authentication ``` 

> An access token will allow you to make requests for the system. We support only one type of token: client_credentials.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


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

## <a name="return_controller"></a>![Class: ](https://apidocs.io/img/class.png "GlobalMilesECommerceAPI.Standard.Controllers.ReturnController") ReturnController

### Get singleton instance

The singleton instance of the ``` ReturnController ``` class can be accessed from the API Client.

```csharp
ReturnController mreturn = client.Return;
```

### <a name="retrieve_return"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesECommerceAPI.Standard.Controllers.ReturnController.RetrieveReturn") RetrieveReturn

> This endpoint allows to get a return.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.RetrieveReturnResponse> RetrieveReturn(string returnProvisionToken)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| returnProvisionToken |  ``` Required ```  | The token value of a return. |


#### Example Usage

```csharp
string returnProvisionToken = "return_provision_token";

Models.RetrieveReturnResponse result = await mreturn.RetrieveReturn(returnProvisionToken);

```


### <a name="delete_cancel_return"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesECommerceAPI.Standard.Controllers.ReturnController.DeleteCancelReturn") DeleteCancelReturn

> This endpoint allows to cancel a return.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.Response> DeleteCancelReturn(Models.CancelReturnRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.CancelReturnRequest();

Models.Response result = await mreturn.DeleteCancelReturn(body);

```


### <a name="update_complete_return"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesECommerceAPI.Standard.Controllers.ReturnController.UpdateCompleteReturn") UpdateCompleteReturn

> This endpoint allows to complete a return.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.Response> UpdateCompleteReturn(Models.CompleteReturnRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.CompleteReturnRequest();

Models.Response result = await mreturn.UpdateCompleteReturn(body);

```


### <a name="create_start_return"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesECommerceAPI.Standard.Controllers.ReturnController.CreateStartReturn") CreateStartReturn

> This endpoint allows to start a return for a specific order.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.StartReturnResponse> CreateStartReturn(Models.StartReturnRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.StartReturnRequest();

Models.StartReturnResponse result = await mreturn.CreateStartReturn(body);

```


### <a name="list_returns"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesECommerceAPI.Standard.Controllers.ReturnController.ListReturns") ListReturns

> This endpoint allows to get list of returns. In order to get detailed return history and reconciliation you can use this endpoint.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.ListReturnResponse> ListReturns(
        string filterStoreCode,
        string filterCreatedAt,
        string filterStatus = null,
        string sort = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| filterStoreCode |  ``` Required ```  | Filter for an online store. |
| filterCreatedAt |  ``` Required ```  | Filter for created_at field. It is accepted a valid date range value. The format is YYYY-MM-DD..YYYY-MM-DD. |
| filterStatus |  ``` Optional ```  | Filter for status field. It is accepted a valid status value of return. |
| sort |  ``` Optional ```  | Sort for some selected fields. In order to sort descending "-" value will be used before the field. Valid field values are "created_at",  "updated_at", "status". |


#### Example Usage

```csharp
string filterStoreCode = "filter[store_code]";
string filterCreatedAt = "filter[created_at]";
string filterStatus = "filter[status]";
string sort = "sort";

Models.ListReturnResponse result = await mreturn.ListReturns(filterStoreCode, filterCreatedAt, filterStatus, sort);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="pay_with_miles_controller"></a>![Class: ](https://apidocs.io/img/class.png "GlobalMilesECommerceAPI.Standard.Controllers.PayWithMilesController") PayWithMilesController

### Get singleton instance

The singleton instance of the ``` PayWithMilesController ``` class can be accessed from the API Client.

```csharp
PayWithMilesController payWithMiles = client.PayWithMiles;
```

### <a name="list_mile_payments"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesECommerceAPI.Standard.Controllers.PayWithMilesController.ListMilePayments") ListMilePayments

> This endpoint allows to get list of payments. In order to get detailed payment history and reconciliation you can use this endpoint.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.ListMilePaymentResponse> ListMilePayments(
        string filterStoreCode,
        string filterCreatedAt,
        string filterStatus = null,
        string sort = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| filterStoreCode |  ``` Required ```  | Filter for an online store. |
| filterCreatedAt |  ``` Required ```  | Filter for created_at field. It is accepted a valid date range value. The format is YYYY-MM-DD..YYYY-MM-DD. |
| filterStatus |  ``` Optional ```  | Filter for status field. It is accepted a valid status value of payment. |
| sort |  ``` Optional ```  | Sort for some selected fields. In order to sort descending "-" value will be used before the field. Valid field values are "created_at",  "updated_at", "status". |


#### Example Usage

```csharp
string filterStoreCode = "filter[store_code]";
string filterCreatedAt = "filter[created_at]";
string filterStatus = "filter[status]";
string sort = "sort";

Models.ListMilePaymentResponse result = await payWithMiles.ListMilePayments(filterStoreCode, filterCreatedAt, filterStatus, sort);

```


### <a name="create_start_mile_payment"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesECommerceAPI.Standard.Controllers.PayWithMilesController.CreateStartMilePayment") CreateStartMilePayment

> After successful authentication and retrieving needed token, this endpoint allows to start a payment transaction. To be able to complete whole payment process successfully also check "Complete Mile Payment endpoint" please.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.StartMilePaymentResponse> CreateStartMilePayment(Models.StartMilePaymentRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.StartMilePaymentRequest();

Models.StartMilePaymentResponse result = await payWithMiles.CreateStartMilePayment(body);

```


### <a name="update_complete_mile_payment"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesECommerceAPI.Standard.Controllers.PayWithMilesController.UpdateCompleteMilePayment") UpdateCompleteMilePayment

> This endpoint allows to complete a payment.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.Response> UpdateCompleteMilePayment(Models.CompleteMilePaymentRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.CompleteMilePaymentRequest();

Models.Response result = await payWithMiles.UpdateCompleteMilePayment(body);

```


### <a name="delete_cancel_mile_payment"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesECommerceAPI.Standard.Controllers.PayWithMilesController.DeleteCancelMilePayment") DeleteCancelMilePayment

> This endpoint allows to cancel a payment.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.Response> DeleteCancelMilePayment(Models.CancelMilePaymentRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.CancelMilePaymentRequest();

Models.Response result = await payWithMiles.DeleteCancelMilePayment(body);

```


### <a name="create_refund_mile_payment"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesECommerceAPI.Standard.Controllers.PayWithMilesController.CreateRefundMilePayment") CreateRefundMilePayment

> This endpoint allows to refund a payment.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.Response> CreateRefundMilePayment(Models.RefundMilePaymentRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.RefundMilePaymentRequest();

Models.Response result = await payWithMiles.CreateRefundMilePayment(body);

```


[Back to List of Controllers](#list_of_controllers)



