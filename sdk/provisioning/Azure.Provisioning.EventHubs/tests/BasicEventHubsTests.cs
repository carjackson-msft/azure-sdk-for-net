// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Tests;
using NUnit.Framework;

namespace Azure.Provisioning.EventHubs.Tests;

public class BasicEventHubsTests(bool async)
    : ProvisioningTestBase(async /*, skipTools: true, skipLiveCalls: true /**/)
{
    [Test]
    [Description("https://github.com/Azure/azure-quickstart-templates/blob/master/quickstarts/microsoft.eventhub/event-hubs-create-event-hub-and-consumer-group/main.bicep")]
    public async Task CreateEventHubAndConsumerGroup()
    {
        await using Trycep test = CreateBicepTest();
        await test.Define(
            ctx =>
            {
                BicepParameter location =
                    new(nameof(location), typeof(string))
                    {
                        Value = BicepFunction.GetResourceGroup().Location,
                        Description = "Hub location."
                    };
                BicepParameter hubName = new(nameof(hubName), typeof(string)) { Value = "orders" };
                BicepParameter groupName = new(nameof(groupName), typeof(string)) { Value = "managers" };

                EventHubsNamespace ns =
                    new(nameof(ns))
                    {
                        Location = location,
                        Sku = new EventHubsSku
                        {
                            Name = EventHubsSkuName.Standard,
                            Tier = EventHubsSkuTier.Standard,
                            Capacity = 1
                        }
                    };

                EventHub hub =
                    new(nameof(hub))
                    {
                        Parent = ns,
                        Name = hubName
                    };

                EventHubsConsumerGroup group =
                    new(nameof(group))
                    {
                        Parent = hub,
                        Name = groupName,
                        UserMetadata = BinaryData.FromObjectAsJson(new { foo = 1, bar = "hello" }).ToString()
                    };
            })
        .Compare(
            """
            @description('Hub location.')
            param location string = resourceGroup().location

            param hubName string = 'orders'

            param groupName string = 'managers'

            resource ns 'Microsoft.EventHub/namespaces@2017-04-01' = {
                name: take('ns-${uniqueString(resourceGroup().id)}', 256)
                location: location
                sku: {
                    name: 'Standard'
                    tier: 'Standard'
                    capacity: 1
                }
            }

            resource hub 'Microsoft.EventHub/namespaces/eventhubs@2024-01-01' = {
                name: hubName
                parent: ns
            }

            resource group 'Microsoft.EventHub/namespaces/eventhubs/consumergroups@2024-01-01' = {
                name: groupName
                properties: {
                    userMetadata: '{"foo":1,"bar":"hello"}'
                }
                parent: hub
            }
            """)
        .Lint()
        .ValidateAndDeployAsync();
    }
}
