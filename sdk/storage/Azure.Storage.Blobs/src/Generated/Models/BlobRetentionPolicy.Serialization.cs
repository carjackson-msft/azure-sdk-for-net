// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    public partial class BlobRetentionPolicy : IXmlSerializable
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "RetentionPolicy");
            writer.WriteStartElement("Enabled");
            writer.WriteValue(Enabled);
            writer.WriteEndElement();
            if (Days.HasValue)
            {
                writer.WriteStartElement("Days");
                writer.WriteValue(Days.Value);
                writer.WriteEndElement();
            }
            if (AllowPermanentDelete.HasValue)
            {
                writer.WriteStartElement("AllowPermanentDelete");
                writer.WriteValue(AllowPermanentDelete.Value);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        internal static BlobRetentionPolicy DeserializeBlobRetentionPolicy(XElement element)
        {
            bool enabled = default;
            int? days = default;
            bool? allowPermanentDelete = default;
            if (element.Element("Enabled") is XElement enabledElement)
            {
                enabled = (bool)enabledElement;
            }
            if (element.Element("Days") is XElement daysElement)
            {
                days = (int?)daysElement;
            }
            if (element.Element("AllowPermanentDelete") is XElement allowPermanentDeleteElement)
            {
                allowPermanentDelete = (bool?)allowPermanentDeleteElement;
            }
            return new BlobRetentionPolicy(enabled, days, allowPermanentDelete);
        }
    }
}
