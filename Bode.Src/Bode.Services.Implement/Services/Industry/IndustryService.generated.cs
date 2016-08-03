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
using Bode.Services.Core.Dtos.Industry;
using Bode.Services.Core.Models.Industry;

namespace Bode.Services.Implement.Services
{
	public partial class IndustryService : IIndustryContract
	{
		                #region Trade信息业务

                public IRepository<Trade, int> TradeRepo { protected get; set; }

                public IQueryable<Trade> Trades
                {
                    get { return TradeRepo.Entities.Where(p => !p.IsDeleted); }
                }

                /// <summary>
                /// 保存Trade信息(新增/更新)
                /// </summary>
                /// <param name="updateForeignKey">更新时是否更新外键信息</param>
                /// <param name="dtos">要保存的TradeDto信息</param>
                /// <returns>业务操作集合</returns>
                public async Task<OperationResult> SaveTrades(bool updateForeignKey=false,params TradeDto[] dtos)
                {
                    try
                    {
                        dtos.CheckNotNull("dtos");
                        var addDtos = dtos.Where(p => p.Id == 0).ToArray();
                        var updateDtos = dtos.Where(p => p.Id != 0).ToArray();

                        TradeRepo.UnitOfWork.TransactionEnabled = true;

                        Action<TradeDto> checkAction=null;
                        Func<TradeDto, Trade, Trade> updateFunc=null;
                        if (addDtos.Length > 0)
                        {
                            TradeRepo.Insert(addDtos,checkAction,updateFunc);
                        }
                        if (updateDtos.Length > 0)
                        {
                            TradeRepo.Update(updateDtos,checkAction,updateFunc);
                        }
                        await TradeRepo.UnitOfWork.SaveChangesAsync();
                        return new OperationResult(OperationResultType.Success, "保存成功");
                    }
                    catch(Exception e)
                    {
                        return new OperationResult(OperationResultType.Error, e.Message);
                    }
                }

                /// <summary>
                /// 删除Trade信息
                /// </summary>
                /// <param name="ids">要删除的Id编号</param>
                /// <returns>业务操作结果</returns>
                public async Task<OperationResult> DeleteTrades(params int[] ids)
                {
                    ids.CheckNotNull("ids");
                    await TradeRepo.RecycleAsync(p=>ids.Contains(p.Id));
                    return new OperationResult(OperationResultType.Success, "删除成功");
                }

                #endregion

                                #region Position信息业务

                public IRepository<Position, int> PositionRepo { protected get; set; }

                public IQueryable<Position> Positions
                {
                    get { return PositionRepo.Entities.Where(p => !p.IsDeleted); }
                }

                /// <summary>
                /// 保存Position信息(新增/更新)
                /// </summary>
                /// <param name="updateForeignKey">更新时是否更新外键信息</param>
                /// <param name="dtos">要保存的PositionDto信息</param>
                /// <returns>业务操作集合</returns>
                public async Task<OperationResult> SavePositions(bool updateForeignKey=false,params PositionDto[] dtos)
                {
                    try
                    {
                        dtos.CheckNotNull("dtos");
                        var addDtos = dtos.Where(p => p.Id == 0).ToArray();
                        var updateDtos = dtos.Where(p => p.Id != 0).ToArray();

                        PositionRepo.UnitOfWork.TransactionEnabled = true;

                        Action<PositionDto> checkAction=null;
                        Func<PositionDto, Position, Position> updateFunc=(dto, entity) => 
                        {
                            if(dto.Id==0||updateForeignKey)
                            {
                                                                        entity.Profession = ProfessionRepo.GetByKey(dto.ProfessionId);
                                                                    }
                            return entity; 
                        };
                        if (addDtos.Length > 0)
                        {
                            PositionRepo.Insert(addDtos,checkAction,updateFunc);
                        }
                        if (updateDtos.Length > 0)
                        {
                            PositionRepo.Update(updateDtos,checkAction,updateFunc);
                        }
                        await PositionRepo.UnitOfWork.SaveChangesAsync();
                        return new OperationResult(OperationResultType.Success, "保存成功");
                    }
                    catch(Exception e)
                    {
                        return new OperationResult(OperationResultType.Error, e.Message);
                    }
                }

                /// <summary>
                /// 删除Position信息
                /// </summary>
                /// <param name="ids">要删除的Id编号</param>
                /// <returns>业务操作结果</returns>
                public async Task<OperationResult> DeletePositions(params int[] ids)
                {
                    ids.CheckNotNull("ids");
                    await PositionRepo.RecycleAsync(p=>ids.Contains(p.Id));
                    return new OperationResult(OperationResultType.Success, "删除成功");
                }

                #endregion

                                #region Education信息业务

                public IRepository<Education, int> EducationRepo { protected get; set; }

                public IQueryable<Education> Educations
                {
                    get { return EducationRepo.Entities.Where(p => !p.IsDeleted); }
                }

                /// <summary>
                /// 保存Education信息(新增/更新)
                /// </summary>
                /// <param name="updateForeignKey">更新时是否更新外键信息</param>
                /// <param name="dtos">要保存的EducationDto信息</param>
                /// <returns>业务操作集合</returns>
                public async Task<OperationResult> SaveEducations(bool updateForeignKey=false,params EducationDto[] dtos)
                {
                    try
                    {
                        dtos.CheckNotNull("dtos");
                        var addDtos = dtos.Where(p => p.Id == 0).ToArray();
                        var updateDtos = dtos.Where(p => p.Id != 0).ToArray();

                        EducationRepo.UnitOfWork.TransactionEnabled = true;

                        Action<EducationDto> checkAction=null;
                        Func<EducationDto, Education, Education> updateFunc=null;
                        if (addDtos.Length > 0)
                        {
                            EducationRepo.Insert(addDtos,checkAction,updateFunc);
                        }
                        if (updateDtos.Length > 0)
                        {
                            EducationRepo.Update(updateDtos,checkAction,updateFunc);
                        }
                        await EducationRepo.UnitOfWork.SaveChangesAsync();
                        return new OperationResult(OperationResultType.Success, "保存成功");
                    }
                    catch(Exception e)
                    {
                        return new OperationResult(OperationResultType.Error, e.Message);
                    }
                }

                /// <summary>
                /// 删除Education信息
                /// </summary>
                /// <param name="ids">要删除的Id编号</param>
                /// <returns>业务操作结果</returns>
                public async Task<OperationResult> DeleteEducations(params int[] ids)
                {
                    ids.CheckNotNull("ids");
                    await EducationRepo.RecycleAsync(p=>ids.Contains(p.Id));
                    return new OperationResult(OperationResultType.Success, "删除成功");
                }

                #endregion

                                #region Profession信息业务

                public IRepository<Profession, int> ProfessionRepo { protected get; set; }

                public IQueryable<Profession> Professions
                {
                    get { return ProfessionRepo.Entities.Where(p => !p.IsDeleted); }
                }

                /// <summary>
                /// 保存Profession信息(新增/更新)
                /// </summary>
                /// <param name="updateForeignKey">更新时是否更新外键信息</param>
                /// <param name="dtos">要保存的ProfessionDto信息</param>
                /// <returns>业务操作集合</returns>
                public async Task<OperationResult> SaveProfessions(bool updateForeignKey=false,params ProfessionDto[] dtos)
                {
                    try
                    {
                        dtos.CheckNotNull("dtos");
                        var addDtos = dtos.Where(p => p.Id == 0).ToArray();
                        var updateDtos = dtos.Where(p => p.Id != 0).ToArray();

                        ProfessionRepo.UnitOfWork.TransactionEnabled = true;

                        Action<ProfessionDto> checkAction=null;
                        Func<ProfessionDto, Profession, Profession> updateFunc=(dto, entity) => 
                        {
                            if(dto.Id==0||updateForeignKey)
                            {
                                                                        entity.Trade = TradeRepo.GetByKey(dto.TradeId);
                                                                    }
                            return entity; 
                        };
                        if (addDtos.Length > 0)
                        {
                            ProfessionRepo.Insert(addDtos,checkAction,updateFunc);
                        }
                        if (updateDtos.Length > 0)
                        {
                            ProfessionRepo.Update(updateDtos,checkAction,updateFunc);
                        }
                        await ProfessionRepo.UnitOfWork.SaveChangesAsync();
                        return new OperationResult(OperationResultType.Success, "保存成功");
                    }
                    catch(Exception e)
                    {
                        return new OperationResult(OperationResultType.Error, e.Message);
                    }
                }

                /// <summary>
                /// 删除Profession信息
                /// </summary>
                /// <param name="ids">要删除的Id编号</param>
                /// <returns>业务操作结果</returns>
                public async Task<OperationResult> DeleteProfessions(params int[] ids)
                {
                    ids.CheckNotNull("ids");
                    await ProfessionRepo.RecycleAsync(p=>ids.Contains(p.Id));
                    return new OperationResult(OperationResultType.Success, "删除成功");
                }

                #endregion

                	}
}
