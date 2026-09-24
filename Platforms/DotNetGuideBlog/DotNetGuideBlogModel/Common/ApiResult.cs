namespace DotNetGuideBlogModel.Common;

public class ApiResult<T>
{
    public bool Success { get; set; }

    public string Message { get; set; } = string.Empty;

    public T? Data { get; set; }

    public static ApiResult<T> Ok(T? data, string message = "操作成功")
    {
        return new ApiResult<T>
        {
            Success = true,
            Message = message,
            Data = data
        };
    }

    public static ApiResult<T> Fail(string message)
    {
        return new ApiResult<T>
        {
            Success = false,
            Message = message,
            Data = default
        };
    }
}
