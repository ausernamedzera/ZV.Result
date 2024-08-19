using System.Net;
using System.Text.Json.Serialization;

namespace ZV.Result;

public sealed class Result<T>
{
    //Properties
    public T? Data { get; set; }
    public List<string>? ErrorMessages { get; set; }
    public bool IsSuccesful { get; set; } = true;
    [JsonIgnore] //Status Code cannot seen in Json 
    public int StatusCode { get; set; } = (int)HttpStatusCode.OK; //Default Value

    //Constructors
    //Succesfull Process
    private Result(T data)
    {
        Data = data;
    }
    //overload
    //Failed Process ErrorList
    private Result(List<string> errorMessages, int statusCode = 400)
    {
        IsSuccesful = false;
        StatusCode = statusCode;
        ErrorMessages = errorMessages;
    }
    //overload
    //Failed Process One Error
    private Result(string errorMessage, int statusCode = 400) //Default 400 
    {
        IsSuccesful = false;
        StatusCode = statusCode;
        ErrorMessages = new() { errorMessage };
    }

    //Methods
    public static Result<T> Succeed(T data)
    {
        return new Result<T>(data);
    }
    public static Result<T> Failure(string message)
    {
        return new Result<T>(message, 500);
    }
    public static Result<T> Failures(List<string> errorMessages)
    {
        return new Result<T>(errorMessages, 500);
    }
}
