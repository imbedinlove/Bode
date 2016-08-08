﻿// <autogenerated>
//   This file was generated by T4 code generator ServicesCodeScript.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Linq;
using OSharp.Core;
using OSharp.Core.Data;
using OSharp.Utility;
using OSharp.Utility.Data;
using OSharp.Utility.Extensions;
using System.Linq.Expressions;
using System.Threading.Tasks;

using Bode.Services.Core.Contracts;
using Bode.Services.Core.Dtos.Character;
using Bode.Services.Core.Models.Character;

namespace Bode.Services.Implement.Services
{
	public partial class CharacterService : ICharacterContract
	{
		                #region Label信息业务

                public IRepository<Label, int> LabelRepo { protected get; set; }

                public IQueryable<Label> Labels
                {
                    get { return LabelRepo.Entities.Where(p => !p.IsDeleted); }
                }

                /// <summary>
                /// 保存Label信息(新增/更新)
                /// </summary>
                /// <param name="updateForeignKey">更新时是否更新外键信息</param>
                /// <param name="dtos">要保存的LabelDto信息</param>
                /// <returns>业务操作集合</returns>
                public async Task<OperationResult> SaveLabels(bool updateForeignKey=false,params LabelDto[] dtos)
                {
                    try
                    {
                        dtos.CheckNotNull("dtos");
                        var addDtos = dtos.Where(p => p.Id == 0).ToArray();
                        var updateDtos = dtos.Where(p => p.Id != 0).ToArray();

                        LabelRepo.UnitOfWork.TransactionEnabled = true;

                        Action<LabelDto> checkAction=null;
                        Func<LabelDto, Label, Label> updateFunc=null;
                        if (addDtos.Length > 0)
                        {
                            LabelRepo.Insert(addDtos,checkAction,updateFunc);
                        }
                        if (updateDtos.Length > 0)
                        {
                            LabelRepo.Update(updateDtos,checkAction,updateFunc);
                        }
                        await LabelRepo.UnitOfWork.SaveChangesAsync();
                        return new OperationResult(OperationResultType.Success, "保存成功");
                    }
                    catch(Exception e)
                    {
                        return new OperationResult(OperationResultType.Error, e.Message);
                    }
                }

                /// <summary>
                /// 删除Label信息
                /// </summary>
                /// <param name="ids">要删除的Id编号</param>
                /// <returns>业务操作结果</returns>
                public async Task<OperationResult> DeleteLabels(params int[] ids)
                {
                    ids.CheckNotNull("ids");
                    await LabelRepo.RecycleAsync(p=>ids.Contains(p.Id));
                    return new OperationResult(OperationResultType.Success, "删除成功");
                }

                #endregion

                	}
}