﻿// <autogenerated>
//   This file was generated by T4 code generator DtosCodeScript.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using OSharp.Core.Data;
using System.ComponentModel;
using Bode.Services.Core.Models.Delivery;

namespace Bode.Services.Core.Dtos.Delivery
{
	public partial class CityDto: IAddDto, IEditDto<int>
	{
        public System.Int32 Id { get; set; }
                            public System.String Name { get; set; }
                                        public System.Int32 ProvinceId { get; set; }
                    	}
}
