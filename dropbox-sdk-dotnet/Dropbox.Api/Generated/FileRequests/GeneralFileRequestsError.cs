// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.FileRequests
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>There is an error accessing the file requests functionality.</para>
    /// </summary>
    public class GeneralFileRequestsError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GeneralFileRequestsError> Encoder = new GeneralFileRequestsErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GeneralFileRequestsError> Decoder = new GeneralFileRequestsErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GeneralFileRequestsError" />
        /// class.</para>
        /// </summary>
        public GeneralFileRequestsError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is DisabledForTeam</para>
        /// </summary>
        public bool IsDisabledForTeam
        {
            get
            {
                return this is DisabledForTeam;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a DisabledForTeam, or <c>null</c>.</para>
        /// </summary>
        public DisabledForTeam AsDisabledForTeam
        {
            get
            {
                return this as DisabledForTeam;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GeneralFileRequestsError" />.</para>
        /// </summary>
        private class GeneralFileRequestsErrorEncoder : enc.StructEncoder<GeneralFileRequestsError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GeneralFileRequestsError value, enc.IJsonWriter writer)
            {
                if (value is DisabledForTeam)
                {
                    WriteProperty(".tag", "disabled_for_team", writer, enc.StringEncoder.Instance);
                    DisabledForTeam.Encoder.EncodeFields((DisabledForTeam)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GeneralFileRequestsError" />.</para>
        /// </summary>
        private class GeneralFileRequestsErrorDecoder : enc.UnionDecoder<GeneralFileRequestsError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GeneralFileRequestsError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GeneralFileRequestsError Create()
            {
                return new GeneralFileRequestsError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override GeneralFileRequestsError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "disabled_for_team":
                        return DisabledForTeam.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>This user's Dropbox Business team doesn't allow file requests.</para>
        /// </summary>
        public sealed class DisabledForTeam : GeneralFileRequestsError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<DisabledForTeam> Encoder = new DisabledForTeamEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<DisabledForTeam> Decoder = new DisabledForTeamDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="DisabledForTeam" />
            /// class.</para>
            /// </summary>
            private DisabledForTeam()
            {
            }

            /// <summary>
            /// <para>A singleton instance of DisabledForTeam</para>
            /// </summary>
            public static readonly DisabledForTeam Instance = new DisabledForTeam();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="DisabledForTeam" />.</para>
            /// </summary>
            private class DisabledForTeamEncoder : enc.StructEncoder<DisabledForTeam>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(DisabledForTeam value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="DisabledForTeam" />.</para>
            /// </summary>
            private class DisabledForTeamDecoder : enc.StructDecoder<DisabledForTeam>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="DisabledForTeam" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override DisabledForTeam Create()
                {
                    return DisabledForTeam.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : GeneralFileRequestsError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
