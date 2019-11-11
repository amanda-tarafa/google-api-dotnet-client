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
    /// Represents a token access that provides extra information 
    /// that either describes the access token or is associated with it.
    /// </summary>
    public interface ITokenAccessWithExtraInformation : ITokenAccess
    {
        /// <summary>
        /// Collection containing the extra information associated
        /// with the access token.
        /// </summary>
        IReadOnlyDictionary<string, string> ExtraInformation { get; }
    }
}
