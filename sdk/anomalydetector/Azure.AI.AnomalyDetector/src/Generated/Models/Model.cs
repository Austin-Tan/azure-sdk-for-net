// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.AnomalyDetector.Models
{
    /// <summary> Response of get model. </summary>
    public partial class Model
    {
        /// <summary> Initializes a new instance of Model. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="createdTime"> Date and time (UTC) when the model was created. </param>
        /// <param name="lastUpdatedTime"> Date and time (UTC) when the model was last updated. </param>
        internal Model(Guid modelId, DateTimeOffset createdTime, DateTimeOffset lastUpdatedTime)
        {
            ModelId = modelId;
            CreatedTime = createdTime;
            LastUpdatedTime = lastUpdatedTime;
        }

        /// <summary> Initializes a new instance of Model. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="createdTime"> Date and time (UTC) when the model was created. </param>
        /// <param name="lastUpdatedTime"> Date and time (UTC) when the model was last updated. </param>
        /// <param name="modelInfo"> Training Status of the model. </param>
        internal Model(Guid modelId, DateTimeOffset createdTime, DateTimeOffset lastUpdatedTime, ModelInfo modelInfo)
        {
            ModelId = modelId;
            CreatedTime = createdTime;
            LastUpdatedTime = lastUpdatedTime;
            ModelInfo = modelInfo;
        }

        /// <summary> Model identifier. </summary>
        public Guid ModelId { get; }
        /// <summary> Date and time (UTC) when the model was created. </summary>
        public DateTimeOffset CreatedTime { get; }
        /// <summary> Date and time (UTC) when the model was last updated. </summary>
        public DateTimeOffset LastUpdatedTime { get; }
        /// <summary> Training Status of the model. </summary>
        public ModelInfo ModelInfo { get; }
    }
}
