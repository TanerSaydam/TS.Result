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

```chsarp
var successResult = new Result<string>("Operation successful.");
```

- **Alternatively**, leverage implicit conversion from data:
```chsarp
Result<string> result = "Operation successful.";
```

- **For failures**, create a Result object with an HTTP status code and error messages:

```chsarp
var errorResult = new Result<string>(HttpStatusCode.BadRequest, new List<string> { "Error 1", "Error 2" });
```

- **Or** use implicit conversion from error details:

```chsarp
Result<string> result = (HttpStatusCode.BadRequest, new List<string> { "Error 1", "Error 2" });
```

- **For single error messages**:

```csharp
Result<string> result = (HttpStatusCode.BadRequest, "Single error message");
```

## Contributing
We welcome contributions! Feel free to open an issue or submit a pull request on our GitHub repository for any suggestions or improvements.

## License
`TS.Result` is licensed under the MIT License. See the LICENSE file in the source repository for full details.

```rust
This Markdown formatted README provides a comprehensive guide on how to use the `TS.Result` package, suitable for your project's repository or documentation.

```
