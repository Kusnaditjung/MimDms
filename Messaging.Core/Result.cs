using System;

namespace Messaging
{
	public sealed class Result
	{
		public readonly bool Status;
		public readonly string Description;
		public readonly Exception ErrorException;

		public Result(bool status, string description, Exception exception = null)
		{

			Status = status;
			Description = description;
			ErrorException = exception;
		}

		public static Result Success() => new Result(true, "Success");
		public static Result Error(string error) => new Result(false, error);
		public static Result Exception(Exception ex) => new Result(false, ex.Message, ex);
		public static Result ErrorAndException(string errorMessage, Exception ex) => new Result(false, errorMessage, ex);
	}
}
