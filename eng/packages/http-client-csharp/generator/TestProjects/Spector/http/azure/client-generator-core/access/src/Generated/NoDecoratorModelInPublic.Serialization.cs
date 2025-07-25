// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;

namespace _Specs_.Azure.ClientGenerator.Core.Access._PublicOperation
{
    public partial class NoDecoratorModelInPublic : IJsonModel<NoDecoratorModelInPublic>
    {
        internal NoDecoratorModelInPublic() => throw null;

        void IJsonModel<NoDecoratorModelInPublic>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        NoDecoratorModelInPublic IJsonModel<NoDecoratorModelInPublic>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual NoDecoratorModelInPublic JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<NoDecoratorModelInPublic>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        NoDecoratorModelInPublic IPersistableModel<NoDecoratorModelInPublic>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual NoDecoratorModelInPublic PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<NoDecoratorModelInPublic>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        public static explicit operator NoDecoratorModelInPublic(Response result) => throw null;
    }
}
