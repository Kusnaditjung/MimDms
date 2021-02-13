using System;

namespace Messaging
{
	/// <summary>
	/// Result is return type for validator and stylesheet transformer in this assembly
	/// </summary>
	public sealed class Result
	{
		/// <summary>
		/// Status, can be true of false
		/// </summary>
		public readonly bool Status;
		/// <summary>
		/// Description text
		/// </summary>
		public readonly string Description;
		/// <summary>
		/// Exception
		/// </summary>
		public readonly Exception ErrorException;

		/// <summary>
		/// <see cref="Result"/> instance constructor
		/// </summary>
		/// <param name="status">Status of the result: true or false</param>
		/// <param name="description">Description of the result</param>
		/// <param name="exception">Exception, by default the value is null</param>
		public Result(bool status, string description, Exception exception = null)
		{

			Status = status;
			Description = description;
			ErrorException = exception;
		}

		/// <summary>
		/// Success result
		/// </summary>
		/// <returns>Return a success result</returns>
		public static Result Success() => new Result(true, "Success");

		/// <summary>
		/// Error result
		/// </summary>
		/// <param name="error">Error description</param>
		/// <returns>Return an error result</returns>
		public static Result Error(string error) => new Result(false, error);

		/// <summary>
		/// Error result with an exception
		/// </summary>
		/// <param name="ex">Exception</param>
		/// <returns>Return an error result with an exception</returns>
		public static Result Exception(Exception ex) => new Result(false, ex.Message, ex);

		/// <summary>
		/// Error result with exception and error description
		/// </summary>
		/// <param name="errorMessage">Error description</param>
		/// <param name="ex">Exception</param>
		/// <returns>Return an error with exception and error description</returns>
		public static Result ErrorAndException(string errorMessage, Exception ex) => new Result(false, errorMessage, ex);
	}
}
