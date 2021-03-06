/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using System;

namespace QuantConnect.Brokerages.InteractiveBrokers.Client
{
    /// <summary>
    /// Event arguments class for the <see cref="InteractiveBrokersClient.HistoricalNewsEnd"/> event
    /// </summary>
    public class HistoricalNewsEndEventArgs : EventArgs
    {
        /// <summary>
        /// The request id.
        /// </summary>
        public int RequestId { get; set; }

        /// <summary>
        /// Indicates whether there are more results available, false otherwise.
        /// </summary>
        public bool HasMore { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricalNewsEndEventArgs"/> class
        /// </summary>
        public HistoricalNewsEndEventArgs(int requestId, bool hasMore)
        {
            RequestId = requestId;
            HasMore = hasMore;
        }
    }
}
