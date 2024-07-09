using System;
namespace Core.Utilities.Results
{
    // for void functions
	public class Result : IResult
	{
        public bool Success { get; }

        public string Message { get; }

        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

    }
}

