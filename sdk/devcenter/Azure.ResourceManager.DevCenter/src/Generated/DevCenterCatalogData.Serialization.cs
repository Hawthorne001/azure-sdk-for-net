// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevCenter.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevCenter
{
    public partial class DevCenterCatalogData : IUtf8JsonSerializable, IJsonModel<DevCenterCatalogData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevCenterCatalogData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevCenterCatalogData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterCatalogData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevCenterCatalogData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(GitHub))
            {
                writer.WritePropertyName("gitHub"u8);
                writer.WriteObjectValue(GitHub, options);
            }
            if (Optional.IsDefined(AdoGit))
            {
                writer.WritePropertyName("adoGit"u8);
                writer.WriteObjectValue(AdoGit, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(SyncState))
            {
                writer.WritePropertyName("syncState"u8);
                writer.WriteStringValue(SyncState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(LastSyncOn))
            {
                writer.WritePropertyName("lastSyncTime"u8);
                writer.WriteStringValue(LastSyncOn.Value, "O");
            }
            writer.WriteEndObject();
        }

        DevCenterCatalogData IJsonModel<DevCenterCatalogData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterCatalogData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevCenterCatalogData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevCenterCatalogData(document.RootElement, options);
        }

        internal static DevCenterCatalogData DeserializeDevCenterCatalogData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            DevCenterGitCatalog gitHub = default;
            DevCenterGitCatalog adoGit = default;
            DevCenterProvisioningState? provisioningState = default;
            DevCenterCatalogSyncState? syncState = default;
            DateTimeOffset? lastSyncTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerDevCenterContext.Default);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("gitHub"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            gitHub = DevCenterGitCatalog.DeserializeDevCenterGitCatalog(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("adoGit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            adoGit = DevCenterGitCatalog.DeserializeDevCenterGitCatalog(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new DevCenterProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("syncState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            syncState = new DevCenterCatalogSyncState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastSyncTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastSyncTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DevCenterCatalogData(
                id,
                name,
                type,
                systemData,
                gitHub,
                adoGit,
                provisioningState,
                syncState,
                lastSyncTime,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevCenterCatalogData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterCatalogData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDevCenterContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DevCenterCatalogData)} does not support writing '{options.Format}' format.");
            }
        }

        DevCenterCatalogData IPersistableModel<DevCenterCatalogData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterCatalogData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDevCenterCatalogData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevCenterCatalogData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevCenterCatalogData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
