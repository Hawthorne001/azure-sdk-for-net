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
using Azure.ResourceManager.Marketplace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Marketplace
{
    public partial class PrivateStoreData : IUtf8JsonSerializable, IJsonModel<PrivateStoreData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateStoreData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PrivateStoreData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateStoreData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateStoreData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Availability))
            {
                writer.WritePropertyName("availability"u8);
                writer.WriteStringValue(Availability.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(PrivateStoreId))
            {
                writer.WritePropertyName("privateStoreId"u8);
                writer.WriteStringValue(PrivateStoreId.Value);
            }
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(PrivateStoreName))
            {
                writer.WritePropertyName("privateStoreName"u8);
                writer.WriteStringValue(PrivateStoreName);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(IsGov))
            {
                writer.WritePropertyName("isGov"u8);
                writer.WriteBooleanValue(IsGov.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(CollectionIds))
            {
                writer.WritePropertyName("collectionIds"u8);
                writer.WriteStartArray();
                foreach (var item in CollectionIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Branding))
            {
                writer.WritePropertyName("branding"u8);
                writer.WriteStartObject();
                foreach (var item in Branding)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("notificationsSettings"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Recipients))
            {
                writer.WritePropertyName("recipients"u8);
                writer.WriteStartArray();
                foreach (var item in Recipients)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SendToAllMarketplaceAdmins))
            {
                writer.WritePropertyName("sendToAllMarketplaceAdmins"u8);
                writer.WriteBooleanValue(SendToAllMarketplaceAdmins.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        PrivateStoreData IJsonModel<PrivateStoreData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateStoreData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateStoreData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateStoreData(document.RootElement, options);
        }

        internal static PrivateStoreData DeserializePrivateStoreData(JsonElement element, ModelReaderWriterOptions options = null)
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
            PrivateStoreAvailability? availability = default;
            Guid? privateStoreId = default;
            ETag? eTag = default;
            string privateStoreName = default;
            Guid? tenantId = default;
            bool? isGov = default;
            IReadOnlyList<Guid> collectionIds = default;
            IDictionary<string, string> branding = default;
            IList<NotificationRecipient> recipients = default;
            bool? sendToAllMarketplaceAdmins = default;
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerMarketplaceContext.Default);
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
                        if (property0.NameEquals("availability"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            availability = new PrivateStoreAvailability(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateStoreId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateStoreId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("eTag"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eTag = new ETag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateStoreName"u8))
                        {
                            privateStoreName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("isGov"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isGov = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("collectionIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<Guid> array = new List<Guid>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetGuid());
                            }
                            collectionIds = array;
                            continue;
                        }
                        if (property0.NameEquals("branding"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            branding = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("notificationsSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("recipients"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    List<NotificationRecipient> array = new List<NotificationRecipient>();
                                    foreach (var item in property1.Value.EnumerateArray())
                                    {
                                        array.Add(NotificationRecipient.DeserializeNotificationRecipient(item, options));
                                    }
                                    recipients = array;
                                    continue;
                                }
                                if (property1.NameEquals("sendToAllMarketplaceAdmins"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    sendToAllMarketplaceAdmins = property1.Value.GetBoolean();
                                    continue;
                                }
                            }
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
            return new PrivateStoreData(
                id,
                name,
                type,
                systemData,
                availability,
                privateStoreId,
                eTag,
                privateStoreName,
                tenantId,
                isGov,
                collectionIds ?? new ChangeTrackingList<Guid>(),
                branding ?? new ChangeTrackingDictionary<string, string>(),
                recipients ?? new ChangeTrackingList<NotificationRecipient>(),
                sendToAllMarketplaceAdmins,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PrivateStoreData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateStoreData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMarketplaceContext.Default);
                default:
                    throw new FormatException($"The model {nameof(PrivateStoreData)} does not support writing '{options.Format}' format.");
            }
        }

        PrivateStoreData IPersistableModel<PrivateStoreData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateStoreData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePrivateStoreData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrivateStoreData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateStoreData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
