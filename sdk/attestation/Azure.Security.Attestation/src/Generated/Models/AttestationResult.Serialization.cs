// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Security.Attestation
{
    [JsonConverter(typeof(AttestationResultConverter))]
    public partial class AttestationResult
    {
        internal static AttestationResult DeserializeAttestationResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> jti = default;
            Optional<string> iss = default;
            Optional<double> iat = default;
            Optional<double> exp = default;
            Optional<double> nbf = default;
            Optional<object> cnf = default;
            Optional<string> nonce = default;
            Optional<string> xMsVer = default;
            Optional<object> xMsRuntime = default;
            Optional<object> xMsInittime = default;
            Optional<object> xMsPolicy = default;
            Optional<string> xMsAttestationType = default;
            Optional<JsonWebKey> xMsPolicySigner = default;
            Optional<string> xMsPolicyHash = default;
            Optional<bool> xMsSgxIsDebuggable = default;
            Optional<float> xMsSgxProductId = default;
            Optional<string> xMsSgxMrenclave = default;
            Optional<string> xMsSgxMrsigner = default;
            Optional<float> xMsSgxSvn = default;
            Optional<string> xMsSgxEhd = default;
            Optional<object> xMsSgxCollateral = default;
            Optional<string> ver = default;
            Optional<bool> isDebuggable = default;
            Optional<object> maaAttestationcollateral = default;
            Optional<string> aasEhd = default;
            Optional<string> maaEhd = default;
            Optional<float> productId = default;
            Optional<string> sgxMrenclave = default;
            Optional<string> sgxMrsigner = default;
            Optional<float> svn = default;
            Optional<string> tee = default;
            Optional<JsonWebKey> policySigner = default;
            Optional<string> policyHash = default;
            Optional<string> rpData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jti"u8))
                {
                    jti = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iss"u8))
                {
                    iss = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    iat = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("exp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exp = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("nbf"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nbf = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("cnf"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cnf = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("nonce"u8))
                {
                    nonce = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x-ms-ver"u8))
                {
                    xMsVer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x-ms-runtime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    xMsRuntime = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("x-ms-inittime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    xMsInittime = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("x-ms-policy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    xMsPolicy = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("x-ms-attestation-type"u8))
                {
                    xMsAttestationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x-ms-policy-signer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    xMsPolicySigner = JsonWebKey.DeserializeJsonWebKey(property.Value);
                    continue;
                }
                if (property.NameEquals("x-ms-policy-hash"u8))
                {
                    xMsPolicyHash = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x-ms-sgx-is-debuggable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    xMsSgxIsDebuggable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("x-ms-sgx-product-id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    xMsSgxProductId = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("x-ms-sgx-mrenclave"u8))
                {
                    xMsSgxMrenclave = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x-ms-sgx-mrsigner"u8))
                {
                    xMsSgxMrsigner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x-ms-sgx-svn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    xMsSgxSvn = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("x-ms-sgx-ehd"u8))
                {
                    xMsSgxEhd = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x-ms-sgx-collateral"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    xMsSgxCollateral = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("ver"u8))
                {
                    ver = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("is-debuggable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDebuggable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maa-attestationcollateral"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maaAttestationcollateral = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("aas-ehd"u8))
                {
                    aasEhd = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maa-ehd"u8))
                {
                    maaEhd = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("product-id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    productId = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("sgx-mrenclave"u8))
                {
                    sgxMrenclave = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sgx-mrsigner"u8))
                {
                    sgxMrsigner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("svn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    svn = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("tee"u8))
                {
                    tee = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policy_signer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policySigner = JsonWebKey.DeserializeJsonWebKey(property.Value);
                    continue;
                }
                if (property.NameEquals("policy_hash"u8))
                {
                    policyHash = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rp_data"u8))
                {
                    rpData = property.Value.GetString();
                    continue;
                }
            }
            return new AttestationResult(
                jti.Value,
                iss.Value,
                Optional.ToNullable(iat),
                Optional.ToNullable(exp),
                Optional.ToNullable(nbf),
                cnf.Value,
                nonce.Value,
                xMsVer.Value,
                xMsRuntime.Value,
                xMsInittime.Value,
                xMsPolicy.Value,
                xMsAttestationType.Value,
                xMsPolicySigner.Value,
                xMsPolicyHash.Value,
                Optional.ToNullable(xMsSgxIsDebuggable),
                Optional.ToNullable(xMsSgxProductId),
                xMsSgxMrenclave.Value,
                xMsSgxMrsigner.Value,
                Optional.ToNullable(xMsSgxSvn),
                xMsSgxEhd.Value,
                xMsSgxCollateral.Value,
                ver.Value,
                Optional.ToNullable(isDebuggable),
                maaAttestationcollateral.Value,
                aasEhd.Value,
                maaEhd.Value,
                Optional.ToNullable(productId),
                sgxMrenclave.Value,
                sgxMrsigner.Value,
                Optional.ToNullable(svn),
                tee.Value,
                policySigner.Value,
                policyHash.Value,
                rpData.Value);
        }

        internal partial class AttestationResultConverter : JsonConverter<AttestationResult>
        {
            public override void Write(Utf8JsonWriter writer, AttestationResult model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override AttestationResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAttestationResult(document.RootElement);
            }
        }
    }
}
