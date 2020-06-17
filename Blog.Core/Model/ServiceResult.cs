using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Model
{
    public class ServiceResult<TEntity>
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public TEntity Data { get; set; }
        public void Success(TEntity data)
        {
            IsSuccess = true;
            StatusCode = 200;
            Data = data;
        }
        public void Error(string message, int statusCode = 400)
        {
            IsSuccess = false;
            StatusCode = statusCode;
            Message = message;
        }
    }

}
