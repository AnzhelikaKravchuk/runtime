﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#pragma warning disable SA1028 // ignore whitespace warnings for generated code
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.Asn1;

namespace System.Security.Cryptography.Asn1
{
    [StructLayout(LayoutKind.Sequential)]
    internal partial struct PssParamsAsn
    {
        private static readonly byte[] s_defaultHashAlgorithm = { 0x30, 0x09, 0x06, 0x05, 0x2B, 0x0E, 0x03, 0x02, 0x1A, 0x05, 0x00 };

        private static readonly byte[] s_defaultMaskGenAlgorithm = { 0x30, 0x16, 0x06, 0x09, 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x08, 0x30, 0x09, 0x06, 0x05, 0x2B, 0x0E, 0x03, 0x02, 0x1A, 0x05, 0x00 };

        private static readonly byte[] s_defaultSaltLength = { 0x02, 0x01, 0x14 };

        private static readonly byte[] s_defaultTrailerField = { 0x02, 0x01, 0x01 };

        internal System.Security.Cryptography.Asn1.AlgorithmIdentifierAsn HashAlgorithm;
        internal System.Security.Cryptography.Asn1.AlgorithmIdentifierAsn MaskGenAlgorithm;
        internal int SaltLength;
        internal int TrailerField;

#if DEBUG
        static PssParamsAsn()
        {
            PssParamsAsn decoded = default;
            ReadOnlyMemory<byte> rebind = default;
            AsnValueReader reader;

            reader = new AsnValueReader(s_defaultHashAlgorithm, AsnEncodingRules.DER);
            System.Security.Cryptography.Asn1.AlgorithmIdentifierAsn.Decode(ref reader, rebind, out decoded.HashAlgorithm);
            reader.ThrowIfNotEmpty();

            reader = new AsnValueReader(s_defaultMaskGenAlgorithm, AsnEncodingRules.DER);
            System.Security.Cryptography.Asn1.AlgorithmIdentifierAsn.Decode(ref reader, rebind, out decoded.MaskGenAlgorithm);
            reader.ThrowIfNotEmpty();

            reader = new AsnValueReader(s_defaultSaltLength, AsnEncodingRules.DER);

            if (!reader.TryReadInt32(out decoded.SaltLength))
            {
                reader.ThrowIfNotEmpty();
            }

            reader.ThrowIfNotEmpty();

            reader = new AsnValueReader(s_defaultTrailerField, AsnEncodingRules.DER);

            if (!reader.TryReadInt32(out decoded.TrailerField))
            {
                reader.ThrowIfNotEmpty();
            }

            reader.ThrowIfNotEmpty();
        }
#endif

        internal void Encode(AsnWriter writer)
        {
            Encode(writer, Asn1Tag.Sequence);
        }

        internal void Encode(AsnWriter writer, Asn1Tag tag)
        {
            writer.PushSequence(tag);


            // DEFAULT value handler for HashAlgorithm.
            {
                using (AsnWriter tmp = new AsnWriter(AsnEncodingRules.DER))
                {
                    HashAlgorithm.Encode(tmp);
                    ReadOnlySpan<byte> encoded = tmp.EncodeAsSpan();

                    if (!encoded.SequenceEqual(s_defaultHashAlgorithm))
                    {
                        writer.PushSequence(new Asn1Tag(TagClass.ContextSpecific, 0));
                        writer.WriteEncodedValue(encoded);
                        writer.PopSequence(new Asn1Tag(TagClass.ContextSpecific, 0));
                    }
                }
            }


            // DEFAULT value handler for MaskGenAlgorithm.
            {
                using (AsnWriter tmp = new AsnWriter(AsnEncodingRules.DER))
                {
                    MaskGenAlgorithm.Encode(tmp);
                    ReadOnlySpan<byte> encoded = tmp.EncodeAsSpan();

                    if (!encoded.SequenceEqual(s_defaultMaskGenAlgorithm))
                    {
                        writer.PushSequence(new Asn1Tag(TagClass.ContextSpecific, 1));
                        writer.WriteEncodedValue(encoded);
                        writer.PopSequence(new Asn1Tag(TagClass.ContextSpecific, 1));
                    }
                }
            }


            // DEFAULT value handler for SaltLength.
            {
                using (AsnWriter tmp = new AsnWriter(AsnEncodingRules.DER))
                {
                    tmp.WriteInteger(SaltLength);
                    ReadOnlySpan<byte> encoded = tmp.EncodeAsSpan();

                    if (!encoded.SequenceEqual(s_defaultSaltLength))
                    {
                        writer.PushSequence(new Asn1Tag(TagClass.ContextSpecific, 2));
                        writer.WriteEncodedValue(encoded);
                        writer.PopSequence(new Asn1Tag(TagClass.ContextSpecific, 2));
                    }
                }
            }


            // DEFAULT value handler for TrailerField.
            {
                using (AsnWriter tmp = new AsnWriter(AsnEncodingRules.DER))
                {
                    tmp.WriteInteger(TrailerField);
                    ReadOnlySpan<byte> encoded = tmp.EncodeAsSpan();

                    if (!encoded.SequenceEqual(s_defaultTrailerField))
                    {
                        writer.PushSequence(new Asn1Tag(TagClass.ContextSpecific, 3));
                        writer.WriteEncodedValue(encoded);
                        writer.PopSequence(new Asn1Tag(TagClass.ContextSpecific, 3));
                    }
                }
            }

            writer.PopSequence(tag);
        }

        internal static PssParamsAsn Decode(ReadOnlyMemory<byte> encoded, AsnEncodingRules ruleSet)
        {
            return Decode(Asn1Tag.Sequence, encoded, ruleSet);
        }

        internal static PssParamsAsn Decode(Asn1Tag expectedTag, ReadOnlyMemory<byte> encoded, AsnEncodingRules ruleSet)
        {
            AsnValueReader reader = new AsnValueReader(encoded.Span, ruleSet);

            Decode(ref reader, expectedTag, encoded, out PssParamsAsn decoded);
            reader.ThrowIfNotEmpty();
            return decoded;
        }

        internal static void Decode(ref AsnValueReader reader, ReadOnlyMemory<byte> rebind, out PssParamsAsn decoded)
        {
            Decode(ref reader, Asn1Tag.Sequence, rebind, out decoded);
        }

        internal static void Decode(ref AsnValueReader reader, Asn1Tag expectedTag, ReadOnlyMemory<byte> rebind, out PssParamsAsn decoded)
        {
            decoded = default;
            AsnValueReader sequenceReader = reader.ReadSequence(expectedTag);
            AsnValueReader explicitReader;
            AsnValueReader defaultReader;


            if (sequenceReader.HasData && sequenceReader.PeekTag().HasSameClassAndValue(new Asn1Tag(TagClass.ContextSpecific, 0)))
            {
                explicitReader = sequenceReader.ReadSequence(new Asn1Tag(TagClass.ContextSpecific, 0));
                System.Security.Cryptography.Asn1.AlgorithmIdentifierAsn.Decode(ref explicitReader, rebind, out decoded.HashAlgorithm);
                explicitReader.ThrowIfNotEmpty();
            }
            else
            {
                defaultReader = new AsnValueReader(s_defaultHashAlgorithm, AsnEncodingRules.DER);
                System.Security.Cryptography.Asn1.AlgorithmIdentifierAsn.Decode(ref defaultReader, rebind, out decoded.HashAlgorithm);
            }


            if (sequenceReader.HasData && sequenceReader.PeekTag().HasSameClassAndValue(new Asn1Tag(TagClass.ContextSpecific, 1)))
            {
                explicitReader = sequenceReader.ReadSequence(new Asn1Tag(TagClass.ContextSpecific, 1));
                System.Security.Cryptography.Asn1.AlgorithmIdentifierAsn.Decode(ref explicitReader, rebind, out decoded.MaskGenAlgorithm);
                explicitReader.ThrowIfNotEmpty();
            }
            else
            {
                defaultReader = new AsnValueReader(s_defaultMaskGenAlgorithm, AsnEncodingRules.DER);
                System.Security.Cryptography.Asn1.AlgorithmIdentifierAsn.Decode(ref defaultReader, rebind, out decoded.MaskGenAlgorithm);
            }


            if (sequenceReader.HasData && sequenceReader.PeekTag().HasSameClassAndValue(new Asn1Tag(TagClass.ContextSpecific, 2)))
            {
                explicitReader = sequenceReader.ReadSequence(new Asn1Tag(TagClass.ContextSpecific, 2));

                if (!explicitReader.TryReadInt32(out decoded.SaltLength))
                {
                    explicitReader.ThrowIfNotEmpty();
                }

                explicitReader.ThrowIfNotEmpty();
            }
            else
            {
                defaultReader = new AsnValueReader(s_defaultSaltLength, AsnEncodingRules.DER);

                if (!defaultReader.TryReadInt32(out decoded.SaltLength))
                {
                    defaultReader.ThrowIfNotEmpty();
                }

            }


            if (sequenceReader.HasData && sequenceReader.PeekTag().HasSameClassAndValue(new Asn1Tag(TagClass.ContextSpecific, 3)))
            {
                explicitReader = sequenceReader.ReadSequence(new Asn1Tag(TagClass.ContextSpecific, 3));

                if (!explicitReader.TryReadInt32(out decoded.TrailerField))
                {
                    explicitReader.ThrowIfNotEmpty();
                }

                explicitReader.ThrowIfNotEmpty();
            }
            else
            {
                defaultReader = new AsnValueReader(s_defaultTrailerField, AsnEncodingRules.DER);

                if (!defaultReader.TryReadInt32(out decoded.TrailerField))
                {
                    defaultReader.ThrowIfNotEmpty();
                }

            }


            sequenceReader.ThrowIfNotEmpty();
        }
    }
}
