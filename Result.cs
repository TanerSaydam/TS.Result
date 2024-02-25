using System.Net;

namespace TS.Result;
public sealed class Result<T>
{
    public T? Data { get; set; }
    public List<string>? ErrorMessages { get; set; }
    public bool IsSuccessful { get; set; } = true;
    public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;

    public Result(T data)
    {
        Data = data;
    }

    public Result(HttpStatusCode statusCode, List<string> errorMessages)
    {
        IsSuccessful = false;
        StatusCode = statusCode;
        ErrorMessages = errorMessages;
    }

    public Result(HttpStatusCode statusCode, string errorMessage)
    {
        IsSuccessful = false;
        StatusCode = statusCode;
        ErrorMessages = new() { errorMessage };
    }

    public static implicit operator Result<T>(T data)
    {
        return new(data);
    }

    public static implicit operator Result<T>((HttpStatusCode statusCode, List<string> errorMessages) parameters)
    {
        return new(parameters.statusCode, parameters.errorMessages);
    }

    public static implicit operator Result<T>((HttpStatusCode statusCode, string errorMessage) parameters)
    {
        return new(parameters.statusCode, parameters.errorMessage);
    }
}
