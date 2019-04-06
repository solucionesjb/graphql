
using System;

namespace Dtos
{
    public class OperationResultDto<TResult>
    {
        public bool Success { get; set; } = false;

        public TResult Result { get; set; }

        public string Error { get; set; } = string.Empty;

        public static implicit operator OperationResultDto<TResult>(OperationResultDto<int> v)
        {
            throw new NotImplementedException();
        }
    }
}
