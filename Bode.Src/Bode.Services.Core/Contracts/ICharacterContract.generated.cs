﻿// <autogenerated>
//   This file was generated by T4 code generator ContractsCodeScript.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Linq;
using OSharp.Core;
using OSharp.Utility.Data;
using System.Linq.Expressions;
using System.Threading.Tasks;
using OSharp.Core.Dependency;
using Bode.Services.Core.Dtos.Character;
using Bode.Services.Core.Models.Character;

namespace Bode.Services.Core.Contracts
{
	public partial interface ICharacterContract : IScopeDependency
	{
		                #region Label信息业务

                IQueryable<Label> Labels { get; }

                /// <summary>
                /// 保存Label信息(新增/更新)
                /// </summary>
                /// <param name="updateForeignKey">更新时是否更新外键信息</param>
                /// <param name="dtos">要保存的LabelDto信息</param>
                /// <returns>业务操作集合</returns>
                Task<OperationResult> SaveLabels(bool updateForeignKey=false,params LabelDto[] dtos);

                /// <summary>
                /// 删除Label信息
                /// </summary>
                /// <param name="ids">要删除的Id编号</param>
                /// <returns>业务操作结果</returns>
                Task<OperationResult> DeleteLabels(params int[] ids);

                #endregion

                	}
}
