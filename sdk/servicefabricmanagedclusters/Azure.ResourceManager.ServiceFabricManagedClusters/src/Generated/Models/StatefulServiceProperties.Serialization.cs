// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class StatefulServiceProperties : IUtf8JsonSerializable, IJsonModel<StatefulServiceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StatefulServiceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StatefulServiceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StatefulServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StatefulServiceProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (HasPersistedState.HasValue)
            {
                writer.WritePropertyName("hasPersistedState"u8);
                writer.WriteBooleanValue(HasPersistedState.Value);
            }
            if (TargetReplicaSetSize.HasValue)
            {
                writer.WritePropertyName("targetReplicaSetSize"u8);
                writer.WriteNumberValue(TargetReplicaSetSize.Value);
            }
            if (MinReplicaSetSize.HasValue)
            {
                writer.WritePropertyName("minReplicaSetSize"u8);
                writer.WriteNumberValue(MinReplicaSetSize.Value);
            }
            if (ReplicaRestartWaitDuration.HasValue)
            {
                writer.WritePropertyName("replicaRestartWaitDuration"u8);
                writer.WriteStringValue(ReplicaRestartWaitDuration.Value, "c");
            }
            if (QuorumLossWaitDuration.HasValue)
            {
                writer.WritePropertyName("quorumLossWaitDuration"u8);
                writer.WriteStringValue(QuorumLossWaitDuration.Value, "c");
            }
            if (StandByReplicaKeepDuration.HasValue)
            {
                writer.WritePropertyName("standByReplicaKeepDuration"u8);
                writer.WriteStringValue(StandByReplicaKeepDuration.Value, "c");
            }
            if (ServicePlacementTimeLimit.HasValue)
            {
                writer.WritePropertyName("servicePlacementTimeLimit"u8);
                writer.WriteStringValue(ServicePlacementTimeLimit.Value, "c");
            }
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            writer.WritePropertyName("serviceKind"u8);
            writer.WriteStringValue(ServiceKind.ToString());
            writer.WritePropertyName("serviceTypeName"u8);
            writer.WriteStringValue(ServiceTypeName);
            writer.WritePropertyName("partitionDescription"u8);
            writer.WriteObjectValue(PartitionDescription);
            if (ServicePackageActivationMode.HasValue)
            {
                writer.WritePropertyName("servicePackageActivationMode"u8);
                writer.WriteStringValue(ServicePackageActivationMode.Value.ToString());
            }
            if (ServiceDnsName != null)
            {
                writer.WritePropertyName("serviceDnsName"u8);
                writer.WriteStringValue(ServiceDnsName);
            }
            if (PlacementConstraints != null)
            {
                writer.WritePropertyName("placementConstraints"u8);
                writer.WriteStringValue(PlacementConstraints);
            }
            if (!(CorrelationScheme is ChangeTrackingList<ManagedServiceCorrelation> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("correlationScheme"u8);
                writer.WriteStartArray();
                foreach (var item in CorrelationScheme)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ServiceLoadMetrics is ChangeTrackingList<ManagedServiceLoadMetric> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("serviceLoadMetrics"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceLoadMetrics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ServicePlacementPolicies is ChangeTrackingList<ManagedServicePlacementPolicy> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("servicePlacementPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in ServicePlacementPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (DefaultMoveCost.HasValue)
            {
                writer.WritePropertyName("defaultMoveCost"u8);
                writer.WriteStringValue(DefaultMoveCost.Value.ToString());
            }
            if (!(ScalingPolicies is ChangeTrackingList<ManagedServiceScalingPolicy> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("scalingPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in ScalingPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        StatefulServiceProperties IJsonModel<StatefulServiceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StatefulServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StatefulServiceProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStatefulServiceProperties(document.RootElement, options);
        }

        internal static StatefulServiceProperties DeserializeStatefulServiceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> hasPersistedState = default;
            Optional<int> targetReplicaSetSize = default;
            Optional<int> minReplicaSetSize = default;
            Optional<TimeSpan> replicaRestartWaitDuration = default;
            Optional<TimeSpan> quorumLossWaitDuration = default;
            Optional<TimeSpan> standByReplicaKeepDuration = default;
            Optional<TimeSpan> servicePlacementTimeLimit = default;
            Optional<string> provisioningState = default;
            ServiceKind serviceKind = default;
            string serviceTypeName = default;
            ManagedServicePartitionScheme partitionDescription = default;
            Optional<ManagedServicePackageActivationMode> servicePackageActivationMode = default;
            Optional<string> serviceDnsName = default;
            Optional<string> placementConstraints = default;
            IList<ManagedServiceCorrelation> correlationScheme = default;
            IList<ManagedServiceLoadMetric> serviceLoadMetrics = default;
            IList<ManagedServicePlacementPolicy> servicePlacementPolicies = default;
            Optional<ServiceFabricManagedServiceMoveCost> defaultMoveCost = default;
            IList<ManagedServiceScalingPolicy> scalingPolicies = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hasPersistedState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasPersistedState = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("targetReplicaSetSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetReplicaSetSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minReplicaSetSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minReplicaSetSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("replicaRestartWaitDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicaRestartWaitDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("quorumLossWaitDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quorumLossWaitDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("standByReplicaKeepDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    standByReplicaKeepDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("servicePlacementTimeLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    servicePlacementTimeLimit = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceKind"u8))
                {
                    serviceKind = new ServiceKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceTypeName"u8))
                {
                    serviceTypeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("partitionDescription"u8))
                {
                    partitionDescription = ManagedServicePartitionScheme.DeserializeManagedServicePartitionScheme(property.Value, options);
                    continue;
                }
                if (property.NameEquals("servicePackageActivationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    servicePackageActivationMode = new ManagedServicePackageActivationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceDnsName"u8))
                {
                    serviceDnsName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("placementConstraints"u8))
                {
                    placementConstraints = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationScheme"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedServiceCorrelation> array = new List<ManagedServiceCorrelation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServiceCorrelation.DeserializeManagedServiceCorrelation(item, options));
                    }
                    correlationScheme = array;
                    continue;
                }
                if (property.NameEquals("serviceLoadMetrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedServiceLoadMetric> array = new List<ManagedServiceLoadMetric>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServiceLoadMetric.DeserializeManagedServiceLoadMetric(item, options));
                    }
                    serviceLoadMetrics = array;
                    continue;
                }
                if (property.NameEquals("servicePlacementPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedServicePlacementPolicy> array = new List<ManagedServicePlacementPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServicePlacementPolicy.DeserializeManagedServicePlacementPolicy(item, options));
                    }
                    servicePlacementPolicies = array;
                    continue;
                }
                if (property.NameEquals("defaultMoveCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultMoveCost = new ServiceFabricManagedServiceMoveCost(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scalingPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedServiceScalingPolicy> array = new List<ManagedServiceScalingPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServiceScalingPolicy.DeserializeManagedServiceScalingPolicy(item, options));
                    }
                    scalingPolicies = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StatefulServiceProperties(
                placementConstraints.Value,
                correlationScheme ?? new ChangeTrackingList<ManagedServiceCorrelation>(),
                serviceLoadMetrics ?? new ChangeTrackingList<ManagedServiceLoadMetric>(),
                servicePlacementPolicies ?? new ChangeTrackingList<ManagedServicePlacementPolicy>(),
                Optional.ToNullable(defaultMoveCost),
                scalingPolicies ?? new ChangeTrackingList<ManagedServiceScalingPolicy>(),
                serializedAdditionalRawData,
                provisioningState.Value,
                serviceKind,
                serviceTypeName,
                partitionDescription,
                Optional.ToNullable(servicePackageActivationMode),
                serviceDnsName.Value,
                Optional.ToNullable(hasPersistedState),
                Optional.ToNullable(targetReplicaSetSize),
                Optional.ToNullable(minReplicaSetSize),
                Optional.ToNullable(replicaRestartWaitDuration),
                Optional.ToNullable(quorumLossWaitDuration),
                Optional.ToNullable(standByReplicaKeepDuration),
                Optional.ToNullable(servicePlacementTimeLimit));
        }

        BinaryData IPersistableModel<StatefulServiceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StatefulServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StatefulServiceProperties)} does not support '{options.Format}' format.");
            }
        }

        StatefulServiceProperties IPersistableModel<StatefulServiceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StatefulServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStatefulServiceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StatefulServiceProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StatefulServiceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
