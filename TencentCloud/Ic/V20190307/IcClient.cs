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

namespace TencentCloud.Ic.V20190307
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ic.V20190307.Models;

   public class IcClient : AbstractClient{

       private const string endpoint = "ic.tencentcloudapi.com";
       private const string version = "2019-03-07";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 根据应用id查询物联卡应用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAppRequest"/></param>
        /// <returns><see cref="DescribeAppResponse"/></returns>
        public async Task<DescribeAppResponse> DescribeApp(DescribeAppRequest req)
        {
             JsonResponseModel<DescribeAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询卡片详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCardRequest"/></param>
        /// <returns><see cref="DescribeCardResponse"/></returns>
        public async Task<DescribeCardResponse> DescribeCard(DescribeCardRequest req)
        {
             JsonResponseModel<DescribeCardResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCard");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询卡片列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCardsRequest"/></param>
        /// <returns><see cref="DescribeCardsResponse"/></returns>
        public async Task<DescribeCardsResponse> DescribeCards(DescribeCardsRequest req)
        {
             JsonResponseModel<DescribeCardsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCards");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCardsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 群发短信
        /// </summary>
        /// <param name="req"><see cref="SendMultiSmsRequest"/></param>
        /// <returns><see cref="SendMultiSmsResponse"/></returns>
        public async Task<SendMultiSmsResponse> SendMultiSms(SendMultiSmsRequest req)
        {
             JsonResponseModel<SendMultiSmsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendMultiSms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendMultiSmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送短信息接口
        /// </summary>
        /// <param name="req"><see cref="SendSmsRequest"/></param>
        /// <returns><see cref="SendSmsResponse"/></returns>
        public async Task<SendSmsResponse> SendSms(SendSmsRequest req)
        {
             JsonResponseModel<SendSmsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendSms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendSmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
