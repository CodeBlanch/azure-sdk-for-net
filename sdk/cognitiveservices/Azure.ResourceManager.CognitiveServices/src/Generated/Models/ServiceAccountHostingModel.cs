// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Account hosting model. </summary>
    public readonly partial struct ServiceAccountHostingModel : IEquatable<ServiceAccountHostingModel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceAccountHostingModel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceAccountHostingModel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WebValue = "Web";
        private const string ConnectedContainerValue = "ConnectedContainer";
        private const string DisconnectedContainerValue = "DisconnectedContainer";

        /// <summary> Web. </summary>
        public static ServiceAccountHostingModel Web { get; } = new ServiceAccountHostingModel(WebValue);
        /// <summary> ConnectedContainer. </summary>
        public static ServiceAccountHostingModel ConnectedContainer { get; } = new ServiceAccountHostingModel(ConnectedContainerValue);
        /// <summary> DisconnectedContainer. </summary>
        public static ServiceAccountHostingModel DisconnectedContainer { get; } = new ServiceAccountHostingModel(DisconnectedContainerValue);
        /// <summary> Determines if two <see cref="ServiceAccountHostingModel"/> values are the same. </summary>
        public static bool operator ==(ServiceAccountHostingModel left, ServiceAccountHostingModel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceAccountHostingModel"/> values are not the same. </summary>
        public static bool operator !=(ServiceAccountHostingModel left, ServiceAccountHostingModel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServiceAccountHostingModel"/>. </summary>
        public static implicit operator ServiceAccountHostingModel(string value) => new ServiceAccountHostingModel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceAccountHostingModel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceAccountHostingModel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
