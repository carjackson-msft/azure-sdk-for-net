// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(HDInsightSparkActivityConverter))]
    public partial class HDInsightSparkActivity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (LinkedServiceName != null)
            {
                writer.WritePropertyName("linkedServiceName"u8);
                writer.WriteObjectValue(LinkedServiceName);
            }
            if (Policy != null)
            {
                writer.WritePropertyName("policy"u8);
                writer.WriteObjectValue(Policy);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (State.HasValue)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (OnInactiveMarkAs.HasValue)
            {
                writer.WritePropertyName("onInactiveMarkAs"u8);
                writer.WriteStringValue(OnInactiveMarkAs.Value.ToString());
            }
            if (!(DependsOn is ChangeTrackingList<ActivityDependency> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("dependsOn"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(UserProperties is ChangeTrackingList<UserProperty> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("userProperties"u8);
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("rootPath"u8);
            writer.WriteObjectValue(RootPath);
            writer.WritePropertyName("entryFilePath"u8);
            writer.WriteObjectValue(EntryFilePath);
            if (!(Arguments is ChangeTrackingList<object> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("arguments"u8);
                writer.WriteStartArray();
                foreach (var item in Arguments)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (GetDebugInfo.HasValue)
            {
                writer.WritePropertyName("getDebugInfo"u8);
                writer.WriteStringValue(GetDebugInfo.Value.ToString());
            }
            if (SparkJobLinkedService != null)
            {
                writer.WritePropertyName("sparkJobLinkedService"u8);
                writer.WriteObjectValue(SparkJobLinkedService);
            }
            if (ClassName != null)
            {
                writer.WritePropertyName("className"u8);
                writer.WriteStringValue(ClassName);
            }
            if (ProxyUser != null)
            {
                writer.WritePropertyName("proxyUser"u8);
                writer.WriteObjectValue(ProxyUser);
            }
            if (!(SparkConfig is ChangeTrackingDictionary<string, object> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("sparkConfig"u8);
                writer.WriteStartObject();
                foreach (var item in SparkConfig)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static HDInsightSparkActivity DeserializeHDInsightSparkActivity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LinkedServiceReference> linkedServiceName = default;
            Optional<ActivityPolicy> policy = default;
            string name = default;
            string type = default;
            Optional<string> description = default;
            Optional<ActivityState> state = default;
            Optional<ActivityOnInactiveMarkAs> onInactiveMarkAs = default;
            IList<ActivityDependency> dependsOn = default;
            IList<UserProperty> userProperties = default;
            object rootPath = default;
            object entryFilePath = default;
            IList<object> arguments = default;
            Optional<HDInsightActivityDebugInfoOption> getDebugInfo = default;
            Optional<LinkedServiceReference> sparkJobLinkedService = default;
            Optional<string> className = default;
            Optional<object> proxyUser = default;
            IDictionary<string, object> sparkConfig = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("policy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policy = ActivityPolicy.DeserializeActivityPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new ActivityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("onInactiveMarkAs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onInactiveMarkAs = new ActivityOnInactiveMarkAs(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ActivityDependency> array = new List<ActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ActivityDependency.DeserializeActivityDependency(item));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UserProperty> array = new List<UserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UserProperty.DeserializeUserProperty(item));
                    }
                    userProperties = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("rootPath"u8))
                        {
                            rootPath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("entryFilePath"u8))
                        {
                            entryFilePath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("arguments"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(item.GetObject());
                                }
                            }
                            arguments = array;
                            continue;
                        }
                        if (property0.NameEquals("getDebugInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            getDebugInfo = new HDInsightActivityDebugInfoOption(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sparkJobLinkedService"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sparkJobLinkedService = LinkedServiceReference.DeserializeLinkedServiceReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("className"u8))
                        {
                            className = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("proxyUser"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            proxyUser = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sparkConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, object> dictionary = new Dictionary<string, object>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, property1.Value.GetObject());
                                }
                            }
                            sparkConfig = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new HDInsightSparkActivity(
                name,
                type,
                description.Value,
                Optional.ToNullable(state),
                Optional.ToNullable(onInactiveMarkAs),
                dependsOn ?? new ChangeTrackingList<ActivityDependency>(),
                userProperties ?? new ChangeTrackingList<UserProperty>(),
                additionalProperties,
                linkedServiceName.Value,
                policy.Value,
                rootPath,
                entryFilePath,
                arguments ?? new ChangeTrackingList<object>(),
                Optional.ToNullable(getDebugInfo),
                sparkJobLinkedService.Value,
                className.Value,
                proxyUser.Value,
                sparkConfig ?? new ChangeTrackingDictionary<string, object>());
        }

        internal partial class HDInsightSparkActivityConverter : JsonConverter<HDInsightSparkActivity>
        {
            public override void Write(Utf8JsonWriter writer, HDInsightSparkActivity model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override HDInsightSparkActivity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeHDInsightSparkActivity(document.RootElement);
            }
        }
    }
}
