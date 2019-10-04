using Autofac.Domain.Http;
using Autofac.Domain.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autofac.Domain.Controller
{
    public abstract class BaseApiController : ControllerBase
    {
        #region OK Result => ReturnCode = 00
        protected internal virtual IActionResult Success(string message = "")
        {
            var baseResponse = new ApiReturnResult
            {
                Result = null,
                ReturnCode = ReturnCodes.CODE_SUCCESS,
                Message = message,
                ExceptionData = string.Empty
            };

            return Ok(baseResponse);
        }

        protected internal virtual IActionResult Success<T>(T content, string message = "")
        {
            var baseResponse = new ApiReturnResult
            {
                Result = content,
                ReturnCode = ReturnCodes.CODE_SUCCESS,
                Message = message,
                ExceptionData = string.Empty
            };

            return Ok(baseResponse);
        }
        #endregion

        #region Failure Result => ReturnCode = 99 or other
        protected internal virtual IActionResult Failure(string message = "")
        {
            var baseResponse = new ApiReturnResult
            {
                Result = null,
                ReturnCode = ReturnCodes.CODE_FAILURE,
                Message = message,
                ExceptionData = string.Empty
            };

            return Ok(baseResponse);
        }

        protected internal virtual IActionResult FailureCode(string returnCode, string message = "")
        {
            var baseResponse = new ApiReturnResult
            {
                Result = null,
                ReturnCode = returnCode,
                Message = message,
                ExceptionData = string.Empty
            };

            return Ok(baseResponse);
        }

        protected internal virtual IActionResult Failure<T>(T content, string message = "")
        {
            var baseResponse = new ApiReturnResult
            {
                Result = content,
                ReturnCode = ReturnCodes.CODE_FAILURE,
                Message = message,
                ExceptionData = string.Empty
            };

            return Ok(baseResponse);
        }
        #endregion
    }
}
