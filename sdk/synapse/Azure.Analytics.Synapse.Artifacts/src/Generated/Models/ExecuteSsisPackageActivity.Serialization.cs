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
    [JsonConverter(typeof(ExecuteSsisPackageActivityConverter))]
    public partial class ExecuteSsisPackageActivity : IUtf8JsonSerializable
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
            writer.WritePropertyName("packageLocation"u8);
            writer.WriteObjectValue(PackageLocation);
            if (Runtime != null)
            {
                writer.WritePropertyName("runtime"u8);
                writer.WriteObjectValue(Runtime);
            }
            if (LoggingLevel != null)
            {
                writer.WritePropertyName("loggingLevel"u8);
                writer.WriteObjectValue(LoggingLevel);
            }
            if (EnvironmentPath != null)
            {
                writer.WritePropertyName("environmentPath"u8);
                writer.WriteObjectValue(EnvironmentPath);
            }
            if (ExecutionCredential != null)
            {
                writer.WritePropertyName("executionCredential"u8);
                writer.WriteObjectValue(ExecutionCredential);
            }
            writer.WritePropertyName("connectVia"u8);
            writer.WriteObjectValue(ConnectVia);
            if (!(ProjectParameters is ChangeTrackingDictionary<string, SsisExecutionParameter> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("projectParameters"u8);
                writer.WriteStartObject();
                foreach (var item in ProjectParameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(PackageParameters is ChangeTrackingDictionary<string, SsisExecutionParameter> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("packageParameters"u8);
                writer.WriteStartObject();
                foreach (var item in PackageParameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(ProjectConnectionManagers is ChangeTrackingDictionary<string, IDictionary<string, SsisExecutionParameter>> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("projectConnectionManagers"u8);
                writer.WriteStartObject();
                foreach (var item in ProjectConnectionManagers)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartObject();
                    foreach (var item0 in item.Value)
                    {
                        writer.WritePropertyName(item0.Key);
                        writer.WriteObjectValue(item0.Value);
                    }
                    writer.WriteEndObject();
                }
                writer.WriteEndObject();
            }
            if (!(PackageConnectionManagers is ChangeTrackingDictionary<string, IDictionary<string, SsisExecutionParameter>> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("packageConnectionManagers"u8);
                writer.WriteStartObject();
                foreach (var item in PackageConnectionManagers)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartObject();
                    foreach (var item0 in item.Value)
                    {
                        writer.WritePropertyName(item0.Key);
                        writer.WriteObjectValue(item0.Value);
                    }
                    writer.WriteEndObject();
                }
                writer.WriteEndObject();
            }
            if (!(PropertyOverrides is ChangeTrackingDictionary<string, SsisPropertyOverride> collection5 && collection5.IsUndefined))
            {
                writer.WritePropertyName("propertyOverrides"u8);
                writer.WriteStartObject();
                foreach (var item in PropertyOverrides)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (LogLocation != null)
            {
                writer.WritePropertyName("logLocation"u8);
                writer.WriteObjectValue(LogLocation);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static ExecuteSsisPackageActivity DeserializeExecuteSsisPackageActivity(JsonElement element)
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
            SsisPackageLocation packageLocation = default;
            Optional<object> runtime = default;
            Optional<object> loggingLevel = default;
            Optional<object> environmentPath = default;
            Optional<SsisExecutionCredential> executionCredential = default;
            IntegrationRuntimeReference connectVia = default;
            IDictionary<string, SsisExecutionParameter> projectParameters = default;
            IDictionary<string, SsisExecutionParameter> packageParameters = default;
            IDictionary<string, IDictionary<string, SsisExecutionParameter>> projectConnectionManagers = default;
            IDictionary<string, IDictionary<string, SsisExecutionParameter>> packageConnectionManagers = default;
            IDictionary<string, SsisPropertyOverride> propertyOverrides = default;
            Optional<SsisLogLocation> logLocation = default;
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
                        if (property0.NameEquals("packageLocation"u8))
                        {
                            packageLocation = SsisPackageLocation.DeserializeSsisPackageLocation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("runtime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            runtime = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("loggingLevel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            loggingLevel = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("environmentPath"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            environmentPath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("executionCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            executionCredential = SsisExecutionCredential.DeserializeSsisExecutionCredential(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("connectVia"u8))
                        {
                            connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("projectParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, SsisExecutionParameter> dictionary = new Dictionary<string, SsisExecutionParameter>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, SsisExecutionParameter.DeserializeSsisExecutionParameter(property1.Value));
                            }
                            projectParameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("packageParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, SsisExecutionParameter> dictionary = new Dictionary<string, SsisExecutionParameter>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, SsisExecutionParameter.DeserializeSsisExecutionParameter(property1.Value));
                            }
                            packageParameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("projectConnectionManagers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, IDictionary<string, SsisExecutionParameter>> dictionary = new Dictionary<string, IDictionary<string, SsisExecutionParameter>>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    Dictionary<string, SsisExecutionParameter> dictionary0 = new Dictionary<string, SsisExecutionParameter>();
                                    foreach (var property2 in property1.Value.EnumerateObject())
                                    {
                                        dictionary0.Add(property2.Name, SsisExecutionParameter.DeserializeSsisExecutionParameter(property2.Value));
                                    }
                                    dictionary.Add(property1.Name, dictionary0);
                                }
                            }
                            projectConnectionManagers = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("packageConnectionManagers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, IDictionary<string, SsisExecutionParameter>> dictionary = new Dictionary<string, IDictionary<string, SsisExecutionParameter>>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    Dictionary<string, SsisExecutionParameter> dictionary0 = new Dictionary<string, SsisExecutionParameter>();
                                    foreach (var property2 in property1.Value.EnumerateObject())
                                    {
                                        dictionary0.Add(property2.Name, SsisExecutionParameter.DeserializeSsisExecutionParameter(property2.Value));
                                    }
                                    dictionary.Add(property1.Name, dictionary0);
                                }
                            }
                            packageConnectionManagers = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("propertyOverrides"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, SsisPropertyOverride> dictionary = new Dictionary<string, SsisPropertyOverride>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, SsisPropertyOverride.DeserializeSsisPropertyOverride(property1.Value));
                            }
                            propertyOverrides = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("logLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logLocation = SsisLogLocation.DeserializeSsisLogLocation(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ExecuteSsisPackageActivity(
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
                packageLocation,
                runtime.Value,
                loggingLevel.Value,
                environmentPath.Value,
                executionCredential.Value,
                connectVia,
                projectParameters ?? new ChangeTrackingDictionary<string, SsisExecutionParameter>(),
                packageParameters ?? new ChangeTrackingDictionary<string, SsisExecutionParameter>(),
                projectConnectionManagers ?? new ChangeTrackingDictionary<string, IDictionary<string, SsisExecutionParameter>>(),
                packageConnectionManagers ?? new ChangeTrackingDictionary<string, IDictionary<string, SsisExecutionParameter>>(),
                propertyOverrides ?? new ChangeTrackingDictionary<string, SsisPropertyOverride>(),
                logLocation.Value);
        }

        internal partial class ExecuteSsisPackageActivityConverter : JsonConverter<ExecuteSsisPackageActivity>
        {
            public override void Write(Utf8JsonWriter writer, ExecuteSsisPackageActivity model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ExecuteSsisPackageActivity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeExecuteSsisPackageActivity(document.RootElement);
            }
        }
    }
}
