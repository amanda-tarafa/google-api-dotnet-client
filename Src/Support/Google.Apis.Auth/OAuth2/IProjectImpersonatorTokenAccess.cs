/*
Copyright 2019 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System.Collections.Generic;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Represents a token access that should impersonate
    /// the given project for quota and billing purposes.
    /// </summary>
    /// <remarks>
    /// The rules of precedence for project impersonation for quota and billing
    /// purposes are as follows:
    /// 1. Resource project: the parent project of the resource being manipulated.
    /// 2. User project: explicitly provided by client code:
    /// 2.1. userProject query param.
    /// 2.2. x-goog-user-project header. This is the mechanism that will be used to send the project
    /// provided through this interface.
    /// 2.3. Client project: the project that produced the credentials(oauth client, service account's project, etc).
    /// </remarks>
    public interface IProjectImpersonatorTokenAccess : ITokenAccess
    {
        /// <summary>
        /// The ID of the Google Cloud project that should be impersonated
        /// for quota and billing purposes.
        /// </summary>
        string QuotaProjectId { get; }
    }
}
