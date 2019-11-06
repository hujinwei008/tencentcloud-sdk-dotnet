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

namespace TencentCloud.Organization.V20181225
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Organization.V20181225.Models;

   public class OrganizationClient : AbstractClient{

       private const string endpoint = "organization.tencentcloudapi.com";
       private const string version = "2018-12-25";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public OrganizationClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public OrganizationClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 接受加入企业组织邀请
        /// </summary>
        /// <param name="req">参考<see cref="AcceptOrganizationInvitationRequest"/></param>
        /// <returns>参考<see cref="AcceptOrganizationInvitationResponse"/>实例</returns>
        public async Task<AcceptOrganizationInvitationResponse> AcceptOrganizationInvitation(AcceptOrganizationInvitationRequest req)
        {
             JsonResponseModel<AcceptOrganizationInvitationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AcceptOrganizationInvitation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AcceptOrganizationInvitationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加企业组织单元
        /// </summary>
        /// <param name="req">参考<see cref="AddOrganizationNodeRequest"/></param>
        /// <returns>参考<see cref="AddOrganizationNodeResponse"/>实例</returns>
        public async Task<AddOrganizationNodeResponse> AddOrganizationNode(AddOrganizationNodeRequest req)
        {
             JsonResponseModel<AddOrganizationNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddOrganizationNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddOrganizationNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消企业组织邀请
        /// </summary>
        /// <param name="req">参考<see cref="CancelOrganizationInvitationRequest"/></param>
        /// <returns>参考<see cref="CancelOrganizationInvitationResponse"/>实例</returns>
        public async Task<CancelOrganizationInvitationResponse> CancelOrganizationInvitation(CancelOrganizationInvitationRequest req)
        {
             JsonResponseModel<CancelOrganizationInvitationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelOrganizationInvitation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelOrganizationInvitationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建企业组织
        /// </summary>
        /// <param name="req">参考<see cref="CreateOrganizationRequest"/></param>
        /// <returns>参考<see cref="CreateOrganizationResponse"/>实例</returns>
        public async Task<CreateOrganizationResponse> CreateOrganization(CreateOrganizationRequest req)
        {
             JsonResponseModel<CreateOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除企业组织
        /// </summary>
        /// <param name="req">参考<see cref="DeleteOrganizationRequest"/></param>
        /// <returns>参考<see cref="DeleteOrganizationResponse"/>实例</returns>
        public async Task<DeleteOrganizationResponse> DeleteOrganization(DeleteOrganizationRequest req)
        {
             JsonResponseModel<DeleteOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除企业组织成员
        /// </summary>
        /// <param name="req">参考<see cref="DeleteOrganizationMemberFromNodeRequest"/></param>
        /// <returns>参考<see cref="DeleteOrganizationMemberFromNodeResponse"/>实例</returns>
        public async Task<DeleteOrganizationMemberFromNodeResponse> DeleteOrganizationMemberFromNode(DeleteOrganizationMemberFromNodeRequest req)
        {
             JsonResponseModel<DeleteOrganizationMemberFromNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteOrganizationMemberFromNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOrganizationMemberFromNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除企业组织成员
        /// </summary>
        /// <param name="req">参考<see cref="DeleteOrganizationMembersRequest"/></param>
        /// <returns>参考<see cref="DeleteOrganizationMembersResponse"/>实例</returns>
        public async Task<DeleteOrganizationMembersResponse> DeleteOrganizationMembers(DeleteOrganizationMembersRequest req)
        {
             JsonResponseModel<DeleteOrganizationMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteOrganizationMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOrganizationMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除企业组织单元
        /// </summary>
        /// <param name="req">参考<see cref="DeleteOrganizationNodesRequest"/></param>
        /// <returns>参考<see cref="DeleteOrganizationNodesResponse"/>实例</returns>
        public async Task<DeleteOrganizationNodesResponse> DeleteOrganizationNodes(DeleteOrganizationNodesRequest req)
        {
             JsonResponseModel<DeleteOrganizationNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteOrganizationNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOrganizationNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拒绝企业组织邀请
        /// </summary>
        /// <param name="req">参考<see cref="DenyOrganizationInvitationRequest"/></param>
        /// <returns>参考<see cref="DenyOrganizationInvitationResponse"/>实例</returns>
        public async Task<DenyOrganizationInvitationResponse> DenyOrganizationInvitation(DenyOrganizationInvitationRequest req)
        {
             JsonResponseModel<DenyOrganizationInvitationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DenyOrganizationInvitation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DenyOrganizationInvitationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取企业组织信息
        /// </summary>
        /// <param name="req">参考<see cref="GetOrganizationRequest"/></param>
        /// <returns>参考<see cref="GetOrganizationResponse"/>实例</returns>
        public async Task<GetOrganizationResponse> GetOrganization(GetOrganizationRequest req)
        {
             JsonResponseModel<GetOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取企业组织成员
        /// </summary>
        /// <param name="req">参考<see cref="GetOrganizationMemberRequest"/></param>
        /// <returns>参考<see cref="GetOrganizationMemberResponse"/>实例</returns>
        public async Task<GetOrganizationMemberResponse> GetOrganizationMember(GetOrganizationMemberRequest req)
        {
             JsonResponseModel<GetOrganizationMemberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetOrganizationMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetOrganizationMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取邀请信息列表
        /// </summary>
        /// <param name="req">参考<see cref="ListOrganizationInvitationsRequest"/></param>
        /// <returns>参考<see cref="ListOrganizationInvitationsResponse"/>实例</returns>
        public async Task<ListOrganizationInvitationsResponse> ListOrganizationInvitations(ListOrganizationInvitationsRequest req)
        {
             JsonResponseModel<ListOrganizationInvitationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListOrganizationInvitations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListOrganizationInvitationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取企业组织成员列表
        /// </summary>
        /// <param name="req">参考<see cref="ListOrganizationMembersRequest"/></param>
        /// <returns>参考<see cref="ListOrganizationMembersResponse"/>实例</returns>
        public async Task<ListOrganizationMembersResponse> ListOrganizationMembers(ListOrganizationMembersRequest req)
        {
             JsonResponseModel<ListOrganizationMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListOrganizationMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListOrganizationMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取企业组织单元成员列表
        /// </summary>
        /// <param name="req">参考<see cref="ListOrganizationNodeMembersRequest"/></param>
        /// <returns>参考<see cref="ListOrganizationNodeMembersResponse"/>实例</returns>
        public async Task<ListOrganizationNodeMembersResponse> ListOrganizationNodeMembers(ListOrganizationNodeMembersRequest req)
        {
             JsonResponseModel<ListOrganizationNodeMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListOrganizationNodeMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListOrganizationNodeMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取企业组织单元列表
        /// </summary>
        /// <param name="req">参考<see cref="ListOrganizationNodesRequest"/></param>
        /// <returns>参考<see cref="ListOrganizationNodesResponse"/>实例</returns>
        public async Task<ListOrganizationNodesResponse> ListOrganizationNodes(ListOrganizationNodesRequest req)
        {
             JsonResponseModel<ListOrganizationNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListOrganizationNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListOrganizationNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移动成员到指定企业组织单元
        /// </summary>
        /// <param name="req">参考<see cref="MoveOrganizationMembersToNodeRequest"/></param>
        /// <returns>参考<see cref="MoveOrganizationMembersToNodeResponse"/>实例</returns>
        public async Task<MoveOrganizationMembersToNodeResponse> MoveOrganizationMembersToNode(MoveOrganizationMembersToNodeRequest req)
        {
             JsonResponseModel<MoveOrganizationMembersToNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MoveOrganizationMembersToNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MoveOrganizationMembersToNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 退出企业组织
        /// </summary>
        /// <param name="req">参考<see cref="QuitOrganizationRequest"/></param>
        /// <returns>参考<see cref="QuitOrganizationResponse"/>实例</returns>
        public async Task<QuitOrganizationResponse> QuitOrganization(QuitOrganizationRequest req)
        {
             JsonResponseModel<QuitOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QuitOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QuitOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送企业组织邀请
        /// </summary>
        /// <param name="req">参考<see cref="SendOrganizationInvitationRequest"/></param>
        /// <returns>参考<see cref="SendOrganizationInvitationResponse"/>实例</returns>
        public async Task<SendOrganizationInvitationResponse> SendOrganizationInvitation(SendOrganizationInvitationRequest req)
        {
             JsonResponseModel<SendOrganizationInvitationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendOrganizationInvitation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendOrganizationInvitationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新企业成员信息
        /// </summary>
        /// <param name="req">参考<see cref="UpdateOrganizationMemberRequest"/></param>
        /// <returns>参考<see cref="UpdateOrganizationMemberResponse"/>实例</returns>
        public async Task<UpdateOrganizationMemberResponse> UpdateOrganizationMember(UpdateOrganizationMemberRequest req)
        {
             JsonResponseModel<UpdateOrganizationMemberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateOrganizationMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateOrganizationMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新企业组织单元
        /// </summary>
        /// <param name="req">参考<see cref="UpdateOrganizationNodeRequest"/></param>
        /// <returns>参考<see cref="UpdateOrganizationNodeResponse"/>实例</returns>
        public async Task<UpdateOrganizationNodeResponse> UpdateOrganizationNode(UpdateOrganizationNodeRequest req)
        {
             JsonResponseModel<UpdateOrganizationNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateOrganizationNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateOrganizationNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
