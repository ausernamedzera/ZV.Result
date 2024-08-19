#ZV.Result NuGet Package

##Overview
The `Result<T>` class provides a standardized way to represent the outcome of an operation. It encapsulates both the result data and any potential error information, making it easier to handle and communicate success and failure scenarios in your application.

##Features
`Succeed Representation:` Encapsulates successful operation results with the data provided.
`Failure Representation:` Handles error scenarios with detailed error messages.
`Flexible Error Handling:` Supports both single and multiple error messages.
`Default HTTP Status Code Handling:` Uses default HTTP status codes for common scenarios, with flexibility to specify custom codes.

##Getting Started
`Installation`
To integrate ZV.Result into your project, install it via the NuGet package manager:
```
Install-Package ZV.Result
```

##Usage
`Succeed Example`
```csharp
var result = Result<string>.Succeed("Operation completed successfully.");
```
`Failure Example`
```csharp
var singleErrorResult = Result<string>.Failure("An error occurred.");
var multipleErrorsResult = Result<string>.Failure(new List<string> { "Error 1", "Error 2" });
```

##Results
`Success Result`
```csharp
{
  "data": 5,
  "errorMessages": null,
  "isSuccesful": true
}
```


`Error Result`
```csharp
{
  "data": 0,
  "errorMessages": [
    "denominator cannot be zero"
  ],
  "isSuccesful": false
}
```
##License
ZV.Result is licensed under the MIT License. See the LICENSE file in the source repository for full details.