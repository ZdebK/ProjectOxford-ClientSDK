﻿// 
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license.
// 
// Project Oxford: http://ProjectOxford.ai
// 
// Project Oxford SDK Github:
// https://github.com/Microsoft/ProjectOxfordSDK-Windows
// 
// Copyright (c) Microsoft Corporation
// All rights reserved.
// 
// MIT License:
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// 

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Microsoft.ProjectOxford.Speech.SpeakerIdentification
{
    /// <summary>
    /// Encapsulates the response for the indentification operation
    /// </summary>
    internal class IdentificationOperationResponse
    {
        /// <summary>
        /// The identification operation status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public OperationStatus Status { get; set; }

        /// <summary>
        /// The created date time for the identification request
        /// </summary>
        public DateTime CreatedDateTime { get; set; }

        /// <summary>
        /// The last action date time for the identification request
        /// </summary>
        public DateTime LastActionDateTime { get; set; }

        /// <summary>
        /// The message in case of failure
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The identification result
        /// </summary>
        public IdentificationResponse ProcessingResult { get; set; }
    }
}
