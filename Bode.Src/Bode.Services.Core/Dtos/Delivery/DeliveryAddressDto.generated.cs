﻿// <autogenerated>
//   This file was generated by T4 code generator DtosCodeScript.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using OSharp.Core.Data;
using System.ComponentModel;
using Bode.Services.Core.Models.Delivery;

namespace Bode.Services.Core.Dtos.Delivery
{
	public partial class DeliveryAddressDto: IAddDto, IEditDto<int>
	{
        public System.Int32 Id { get; set; }
                            public System.String Consignee { get; set; }
                                        public System.String PhoneNo { get; set; }
                                        public System.String Province { get; set; }
                                        public System.String City { get; set; }
                                        public System.String District { get; set; }
                                        public System.String PostCode { get; set; }
                                        public System.String ShipAddress { get; set; }
                                        public System.Boolean IsDefault { get; set; }
                                        public System.Int32 UserInfoId { get; set; }
                    	}
}
