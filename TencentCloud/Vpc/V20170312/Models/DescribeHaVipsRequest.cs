/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeHaVipsRequest : AbstractModel
    {
        
        /// <summary>
        /// `HAVIP`唯一`ID`，形如：`havip-9o233uri`。
        /// </summary>
        [JsonProperty("HaVipIds")]
        public string[] HaVipIds{ get; set; }

        /// <summary>
        /// 过滤条件，参数不支持同时指定`HaVipIds`和`Filters`。
        /// <li>havip-id - String - `HAVIP`唯一`ID`，形如：`havip-9o233uri`。</li>
        /// <li>havip-name - String - `HAVIP`名称。</li>
        /// <li>vpc-id - String - `HAVIP`所在私有网络`ID`。</li>
        /// <li>subnet-id - String - `HAVIP`所在子网`ID`。</li>
        /// <li>address-ip - String - `HAVIP`绑定的弹性公网`IP`。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "HaVipIds.", this.HaVipIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

