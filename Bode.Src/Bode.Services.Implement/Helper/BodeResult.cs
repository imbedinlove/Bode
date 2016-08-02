using OSharp.Utility.Data;
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
        /// <param name="message">返回消息</param>
        /// <param name="data">数据</param>
        /// <returns></returns>
        public static OperationResult Success(string message, object data)
        {
            return new OperationResult(OperationResultType.Success, message, data);
        }

        /// <summary>
        /// 指定参数的数据不存在
        /// </summary>
        /// <param name="message">描述</param>
        /// <returns></returns>
        public static OperationResult QueryNull(string message)
        {
            return new OperationResult(OperationResultType.QueryNull, message);
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

        /// <summary>
        /// 输入信息验证失败
        /// </summary>
        /// <param name="message">消息</param>
        /// <returns></returns>
        public static OperationResult ValidError(string  message)
        {
            return new OperationResult(OperationResultType.ValidError, message);
        }

        /// <summary>
        /// 操作取消或操作没引发任何变化
        /// </summary>
        /// <returns></returns>
        public static OperationResult NoChanged()
        {
            return CreateOpeartionResult(OperationResultType.NoChanged);
        }

        /// <summary>
        /// 操作取消或操作没引发任何变化
        /// </summary>
        /// <param name="message">消息</param>
        /// <returns></returns>
        public static OperationResult NoChanged(string message)
        {
            return new OperationResult(OperationResultType.NoChanged, message);
        }
    }
}
