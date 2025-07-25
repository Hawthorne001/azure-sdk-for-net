// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkPlatformConfiguration : IUtf8JsonSerializable, IJsonModel<MobileNetworkPlatformConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MobileNetworkPlatformConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MobileNetworkPlatformConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPlatformConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkPlatformConfiguration)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(PlatformType.ToString());
            if (Optional.IsDefined(AzureStackEdgeDevice))
            {
                writer.WritePropertyName("azureStackEdgeDevice"u8);
                ((IJsonModel<WritableSubResource>)AzureStackEdgeDevice).Write(writer, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AzureStackEdgeDevices))
            {
                writer.WritePropertyName("azureStackEdgeDevices"u8);
                writer.WriteStartArray();
                foreach (var item in AzureStackEdgeDevices)
                {
                    ((IJsonModel<WritableSubResource>)item).Write(writer, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AzureStackHciCluster))
            {
                writer.WritePropertyName("azureStackHciCluster"u8);
                ((IJsonModel<WritableSubResource>)AzureStackHciCluster).Write(writer, options);
            }
            if (Optional.IsDefined(ConnectedCluster))
            {
                writer.WritePropertyName("connectedCluster"u8);
                ((IJsonModel<WritableSubResource>)ConnectedCluster).Write(writer, options);
            }
            if (Optional.IsDefined(CustomLocation))
            {
                writer.WritePropertyName("customLocation"u8);
                ((IJsonModel<WritableSubResource>)CustomLocation).Write(writer, options);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        MobileNetworkPlatformConfiguration IJsonModel<MobileNetworkPlatformConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPlatformConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkPlatformConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkPlatformConfiguration(document.RootElement, options);
        }

        internal static MobileNetworkPlatformConfiguration DeserializeMobileNetworkPlatformConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MobileNetworkPlatformType type = default;
            WritableSubResource azureStackEdgeDevice = default;
            IReadOnlyList<WritableSubResource> azureStackEdgeDevices = default;
            WritableSubResource azureStackHciCluster = default;
            WritableSubResource connectedCluster = default;
            WritableSubResource customLocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new MobileNetworkPlatformType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azureStackEdgeDevice"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureStackEdgeDevice = ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), options, AzureResourceManagerMobileNetworkContext.Default);
                    continue;
                }
                if (property.NameEquals("azureStackEdgeDevices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(item.GetRawText())), options, AzureResourceManagerMobileNetworkContext.Default));
                    }
                    azureStackEdgeDevices = array;
                    continue;
                }
                if (property.NameEquals("azureStackHciCluster"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureStackHciCluster = ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), options, AzureResourceManagerMobileNetworkContext.Default);
                    continue;
                }
                if (property.NameEquals("connectedCluster"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectedCluster = ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), options, AzureResourceManagerMobileNetworkContext.Default);
                    continue;
                }
                if (property.NameEquals("customLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customLocation = ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), options, AzureResourceManagerMobileNetworkContext.Default);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MobileNetworkPlatformConfiguration(
                type,
                azureStackEdgeDevice,
                azureStackEdgeDevices ?? new ChangeTrackingList<WritableSubResource>(),
                azureStackHciCluster,
                connectedCluster,
                customLocation,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PlatformType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  type: ");
                builder.AppendLine($"'{PlatformType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("AzureStackEdgeDeviceId", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  azureStackEdgeDevice: ");
                builder.AppendLine("{");
                builder.Append("    id: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(AzureStackEdgeDevice))
                {
                    builder.Append("  azureStackEdgeDevice: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AzureStackEdgeDevice, options, 2, false, "  azureStackEdgeDevice: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AzureStackEdgeDevices), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  azureStackEdgeDevices: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AzureStackEdgeDevices))
                {
                    if (AzureStackEdgeDevices.Any())
                    {
                        builder.Append("  azureStackEdgeDevices: ");
                        builder.AppendLine("[");
                        foreach (var item in AzureStackEdgeDevices)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  azureStackEdgeDevices: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("AzureStackHciClusterId", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  azureStackHciCluster: ");
                builder.AppendLine("{");
                builder.Append("    id: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(AzureStackHciCluster))
                {
                    builder.Append("  azureStackHciCluster: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AzureStackHciCluster, options, 2, false, "  azureStackHciCluster: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("ConnectedClusterId", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  connectedCluster: ");
                builder.AppendLine("{");
                builder.Append("    id: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(ConnectedCluster))
                {
                    builder.Append("  connectedCluster: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ConnectedCluster, options, 2, false, "  connectedCluster: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("CustomLocationId", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  customLocation: ");
                builder.AppendLine("{");
                builder.Append("    id: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(CustomLocation))
                {
                    builder.Append("  customLocation: ");
                    BicepSerializationHelpers.AppendChildObject(builder, CustomLocation, options, 2, false, "  customLocation: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MobileNetworkPlatformConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPlatformConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMobileNetworkContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkPlatformConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        MobileNetworkPlatformConfiguration IPersistableModel<MobileNetworkPlatformConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPlatformConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMobileNetworkPlatformConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkPlatformConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MobileNetworkPlatformConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
