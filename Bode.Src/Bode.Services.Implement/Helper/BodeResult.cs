﻿using OSharp.Utility.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSharp.Utility.Extensions;


namespace Bode.Services.Implement.Helper
{
    public class BodeResult
    {
        public static OperationResult CreateOpeartionResult(OperationResultType type)
        {
            return new OperationResult(type, type.ToDescription());
        }

        public static OperationResult CreateOpeartionResult(object data)
        {
            OperationResultType type = OperationResultType.Success;
            return new OperationResult(type, type.ToDescription(), data);
        }

        /// <summary>
        /// 操作成功
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns></returns>
        public static OperationResult Success(object data)
        {
            return CreateOpeartionResult(data);
        }

        /// <summary>
        /// 操作成功
        /// </summary>
        /// <returns></returns>
        public static OperationResult Success()
        {
            return CreateOpeartionResult(OperationResultType.Success);
        }

        /// <summary>
        /// 输入信息验证失败
        /// </summary>
        /// <returns></returns>
        public static OperationResult ValidError()
        {
            return CreateOpeartionResult(OperationResultType.ValidError);
        }

        public static OperationResult ValidError(string  message)
        {
            return new OperationResult(OperationResultType.ValidError, message);
        }

        public static OperationResult NoChanged()
        {
            return CreateOpeartionResult(OperationResultType.NoChanged);
        }

        public static OperationResult NoChanged(string message)
        {
            return new OperationResult(OperationResultType.NoChanged, message);
        }
    }
}
