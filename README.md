# TS.Result NuGet Package

## Overview
The `TS.Result` package is designed to encapsulate the result of operations in .NET applications, offering a structured way to handle success and failure states with associated data or error messages. It is ideal for improving error handling and response consistency across various application layers.

## Features
- **Generic Result Type**: Facilitates strong typing of the operation outcome, accommodating any data type.
- **Error Handling**: Enables capturing multiple error messages, suitable for scenarios requiring detailed feedback.
- **HTTP Status Code Integration**: Aligns operation results with HTTP response standards, enhancing API development.
- **Implicit Conversions**: Streamlines result creation from data or errors through implicit conversion operators.

## Getting Started

### Installation
To integrate `TS.Result` into your project, install it via the NuGet package manager:

```plaintext
Install-Package TS.Result
```

Or through the .NET CLI:
```plaintext
dotnet add package TS.Result
```

## Usage
- **For a successful operation**, instantiate a Result object with the desired data:

```csharp
var successResult = new Result<string>("Operation successful.");
```

- **Alternatively**, leverage implicit conversion from data:
```csharp
Result<string> result = "Operation successful.";
```

- **For failures**, create a Result object with an HTTP status code and error messages:

```csharp
var errorResult = new Result<string>(400, new List<string> { "Error 1", "Error 2" });
```

- **Or** use implicit conversion from error details:

```csharp
Result<string> result = (400, new List<string> { "Error 1", "Error 2" });
```

- **For single error messages**:

```csharp
Result<string> result = (400, "Single error message");
```

- **For success using Succeed method**:
```csharp
Result<string> result = Result<string>.Succeed("Is successful");
``` 

- **For error using Failure method**:
- **One error message**
```csharp
Result<string> result = Result<string>.Failure(500,"Is fail!");
``` 

- **Multiple error messages**
```csharp
Result<string> result = Result<string>.Failure(500,new List<string>() {"Is fail!","Is not unique!"});
``` 

- **One error message return 500 status code**
```csharp
Result<string> result = Result<string>.Failure("Is fail!"); //return 500 status code
``` 

- **Multiple error messages return 500 status code**
```csharp
Result<string> result = Result<string>.Failure(new List<string>() {"Is fail!","Is not unique!"}); //return 500 status code
``` 

- **Success Result**
```json
{
  "data": {
    "token": "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9",
    "refreshToken": "dbfa1ced-6ae1-4120-beea-4d0dbde492e3",
    "refreshTokenExpires": "2024-05-20T03:51:44.4942877Z"
  },
  "errorMessages": null,  
}
```

- **Error Result**
```json
{
  "data": null,
  "errorMessages": [
    "Username must be at least 3 characters"
  ]  
}
```

## Contributing
We welcome contributions! Feel free to open an issue or submit a pull request on our GitHub repository for any suggestions or improvements.

## License
`TS.Result` is licensed under the MIT License. See the LICENSE file in the source repository for full details.

```rust
This Markdown formatted README provides a comprehensive guide on how to use the `TS.Result` package, suitable for your project's repository or documentation.
```
