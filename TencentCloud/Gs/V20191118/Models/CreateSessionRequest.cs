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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSessionRequest : AbstractModel
    {
        
        /// <summary>
        /// 客户端session信息，从JSSDK请求中获得
        /// </summary>
        [JsonProperty("ClientSession")]
        public string ClientSession{ get; set; }

        /// <summary>
        /// 游戏用户ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 游戏ID
        /// </summary>
        [JsonProperty("GameId")]
        public string GameId{ get; set; }

        /// <summary>
        /// 游戏区域，ap-guangzhou、ap-shanghai、ap-beijing等
        /// </summary>
        [JsonProperty("GameRegion")]
        public string GameRegion{ get; set; }

        /// <summary>
        /// 游戏参数
        /// </summary>
        [JsonProperty("GameParas")]
        public string GameParas{ get; set; }

        /// <summary>
        /// 分辨率,，可设置为1080p或720p
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// 背景图url，格式为png或jpeg，宽高1920*1080
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 资源池编号，1表示正式，2表示测试
        /// </summary>
        [JsonProperty("SetNo")]
        public ulong? SetNo{ get; set; }

        /// <summary>
        /// 单位Mbps，固定码率，后端不动态调整(MaxBitrate和MinBitrate将无效)
        /// </summary>
        [JsonProperty("Bitrate")]
        public ulong? Bitrate{ get; set; }

        /// <summary>
        /// 单位Mbps，动态调整最大码率
        /// </summary>
        [JsonProperty("MaxBitrate")]
        public ulong? MaxBitrate{ get; set; }

        /// <summary>
        /// 单位Mbps，动态调整最小码率
        /// </summary>
        [JsonProperty("MinBitrate")]
        public ulong? MinBitrate{ get; set; }

        /// <summary>
        /// 帧率，可设置为30、45或60
        /// </summary>
        [JsonProperty("Fps")]
        public ulong? Fps{ get; set; }

        /// <summary>
        /// 游戏用户IP，用于就近调度，例如125.127.178.228
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientSession", this.ClientSession);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "GameId", this.GameId);
            this.SetParamSimple(map, prefix + "GameRegion", this.GameRegion);
            this.SetParamSimple(map, prefix + "GameParas", this.GameParas);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "SetNo", this.SetNo);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "MaxBitrate", this.MaxBitrate);
            this.SetParamSimple(map, prefix + "MinBitrate", this.MinBitrate);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
        }
    }
}

