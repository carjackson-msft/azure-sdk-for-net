// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Files.Shares.Models
{
    internal partial class HandleItem
    {
        internal static HandleItem DeserializeHandleItem(XElement element)
        {
            string handleId = default;
            StringEncoded path = default;
            string fileId = default;
            string parentId = default;
            string sessionId = default;
            string clientIp = default;
            string clientName = default;
            DateTimeOffset openTime = default;
            DateTimeOffset? lastReconnectTime = default;
            IReadOnlyList<AccessRight> accessRightList = default;
            if (element.Element("HandleId") is XElement handleIdElement)
            {
                handleId = (string)handleIdElement;
            }
            if (element.Element("Path") is XElement pathElement)
            {
                path = StringEncoded.DeserializeStringEncoded(pathElement);
            }
            if (element.Element("FileId") is XElement fileIdElement)
            {
                fileId = (string)fileIdElement;
            }
            if (element.Element("ParentId") is XElement parentIdElement)
            {
                parentId = (string)parentIdElement;
            }
            if (element.Element("SessionId") is XElement sessionIdElement)
            {
                sessionId = (string)sessionIdElement;
            }
            if (element.Element("ClientIp") is XElement clientIpElement)
            {
                clientIp = (string)clientIpElement;
            }
            if (element.Element("ClientName") is XElement clientNameElement)
            {
                clientName = (string)clientNameElement;
            }
            if (element.Element("OpenTime") is XElement openTimeElement)
            {
                openTime = openTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("LastReconnectTime") is XElement lastReconnectTimeElement)
            {
                lastReconnectTime = lastReconnectTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("AccessRightList") is XElement accessRightListElement)
            {
                var array = new List<AccessRight>();
                foreach (var e in accessRightListElement.Elements("AccessRight"))
                {
                    array.Add(e.Value.ToAccessRight());
                }
                accessRightList = array;
            }
            return new HandleItem(
                handleId,
                path,
                fileId,
                parentId,
                sessionId,
                clientIp,
                clientName,
                openTime,
                lastReconnectTime,
                accessRightList);
        }
    }
}
