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
using Bode.Services.Core.Dtos.Delivery;
using Bode.Services.Core.Models.Delivery;

namespace Bode.Services.Core.Contracts
{
	public partial interface IDeliveryContract : IScopeDependency
	{
		                #region Region信息业务

                IQueryable<Region> Regions { get; }

                /// <summary>
                /// 保存Region信息(新增/更新)
                /// </summary>
                /// <param name="updateForeignKey">更新时是否更新外键信息</param>
                /// <param name="dtos">要保存的RegionDto信息</param>
                /// <returns>业务操作集合</returns>
                Task<OperationResult> SaveRegions(bool updateForeignKey=false,params RegionDto[] dtos);

                /// <summary>
                /// 删除Region信息
                /// </summary>
                /// <param name="ids">要删除的Id编号</param>
                /// <returns>业务操作结果</returns>
                Task<OperationResult> DeleteRegions(params int[] ids);

                #endregion

                                #region Area信息业务

                IQueryable<Area> Areas { get; }

                /// <summary>
                /// 保存Area信息(新增/更新)
                /// </summary>
                /// <param name="updateForeignKey">更新时是否更新外键信息</param>
                /// <param name="dtos">要保存的AreaDto信息</param>
                /// <returns>业务操作集合</returns>
                Task<OperationResult> SaveAreas(bool updateForeignKey=false,params AreaDto[] dtos);

                /// <summary>
                /// 删除Area信息
                /// </summary>
                /// <param name="ids">要删除的Id编号</param>
                /// <returns>业务操作结果</returns>
                Task<OperationResult> DeleteAreas(params int[] ids);

                #endregion

                                #region City信息业务

                IQueryable<City> Citys { get; }

                /// <summary>
                /// 保存City信息(新增/更新)
                /// </summary>
                /// <param name="updateForeignKey">更新时是否更新外键信息</param>
                /// <param name="dtos">要保存的CityDto信息</param>
                /// <returns>业务操作集合</returns>
                Task<OperationResult> SaveCitys(bool updateForeignKey=false,params CityDto[] dtos);

                /// <summary>
                /// 删除City信息
                /// </summary>
                /// <param name="ids">要删除的Id编号</param>
                /// <returns>业务操作结果</returns>
                Task<OperationResult> DeleteCitys(params int[] ids);

                #endregion

                                #region DeliveryAddress信息业务

                IQueryable<DeliveryAddress> DeliveryAddresss { get; }

                /// <summary>
                /// 保存DeliveryAddress信息(新增/更新)
                /// </summary>
                /// <param name="updateForeignKey">更新时是否更新外键信息</param>
                /// <param name="dtos">要保存的DeliveryAddressDto信息</param>
                /// <returns>业务操作集合</returns>
                Task<OperationResult> SaveDeliveryAddresss(bool updateForeignKey=false,params DeliveryAddressDto[] dtos);

                /// <summary>
                /// 删除DeliveryAddress信息
                /// </summary>
                /// <param name="ids">要删除的Id编号</param>
                /// <returns>业务操作结果</returns>
                Task<OperationResult> DeleteDeliveryAddresss(params int[] ids);

                #endregion

                                #region FreightTemplate信息业务

                IQueryable<FreightTemplate> FreightTemplates { get; }

                /// <summary>
                /// 保存FreightTemplate信息(新增/更新)
                /// </summary>
                /// <param name="updateForeignKey">更新时是否更新外键信息</param>
                /// <param name="dtos">要保存的FreightTemplateDto信息</param>
                /// <returns>业务操作集合</returns>
                Task<OperationResult> SaveFreightTemplates(bool updateForeignKey=false,params FreightTemplateDto[] dtos);

                /// <summary>
                /// 删除FreightTemplate信息
                /// </summary>
                /// <param name="ids">要删除的Id编号</param>
                /// <returns>业务操作结果</returns>
                Task<OperationResult> DeleteFreightTemplates(params int[] ids);

                #endregion

                                #region Logistics信息业务

                IQueryable<Logistics> Logisticss { get; }

                /// <summary>
                /// 保存Logistics信息(新增/更新)
                /// </summary>
                /// <param name="updateForeignKey">更新时是否更新外键信息</param>
                /// <param name="dtos">要保存的LogisticsDto信息</param>
                /// <returns>业务操作集合</returns>
                Task<OperationResult> SaveLogisticss(bool updateForeignKey=false,params LogisticsDto[] dtos);

                /// <summary>
                /// 删除Logistics信息
                /// </summary>
                /// <param name="ids">要删除的Id编号</param>
                /// <returns>业务操作结果</returns>
                Task<OperationResult> DeleteLogisticss(params int[] ids);

                #endregion

                                #region Province信息业务

                IQueryable<Province> Provinces { get; }

                /// <summary>
                /// 保存Province信息(新增/更新)
                /// </summary>
                /// <param name="updateForeignKey">更新时是否更新外键信息</param>
                /// <param name="dtos">要保存的ProvinceDto信息</param>
                /// <returns>业务操作集合</returns>
                Task<OperationResult> SaveProvinces(bool updateForeignKey=false,params ProvinceDto[] dtos);

                /// <summary>
                /// 删除Province信息
                /// </summary>
                /// <param name="ids">要删除的Id编号</param>
                /// <returns>业务操作结果</returns>
                Task<OperationResult> DeleteProvinces(params int[] ids);

                #endregion

                	}
}
