// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The reseller role object</para>
    /// </summary>
    public class ResellerRole
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ResellerRole> Encoder = new ResellerRoleEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ResellerRole> Decoder = new ResellerRoleDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ResellerRole" /> class.</para>
        /// </summary>
        public ResellerRole()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NotReseller</para>
        /// </summary>
        public bool IsNotReseller
        {
            get
            {
                return this is NotReseller;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NotReseller, or <c>null</c>.</para>
        /// </summary>
        public NotReseller AsNotReseller
        {
            get
            {
                return this as NotReseller;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is ResellerAdmin</para>
        /// </summary>
        public bool IsResellerAdmin
        {
            get
            {
                return this is ResellerAdmin;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a ResellerAdmin, or <c>null</c>.</para>
        /// </summary>
        public ResellerAdmin AsResellerAdmin
        {
            get
            {
                return this as ResellerAdmin;
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
        /// <para>Encoder for  <see cref="ResellerRole" />.</para>
        /// </summary>
        private class ResellerRoleEncoder : enc.StructEncoder<ResellerRole>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ResellerRole value, enc.IJsonWriter writer)
            {
                if (value is NotReseller)
                {
                    WriteProperty(".tag", "not_reseller", writer, enc.StringEncoder.Instance);
                    NotReseller.Encoder.EncodeFields((NotReseller)value, writer);
                    return;
                }
                if (value is ResellerAdmin)
                {
                    WriteProperty(".tag", "reseller_admin", writer, enc.StringEncoder.Instance);
                    ResellerAdmin.Encoder.EncodeFields((ResellerAdmin)value, writer);
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
        /// <para>Decoder for  <see cref="ResellerRole" />.</para>
        /// </summary>
        private class ResellerRoleDecoder : enc.UnionDecoder<ResellerRole>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ResellerRole" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ResellerRole Create()
            {
                return new ResellerRole();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override ResellerRole Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "not_reseller":
                        return NotReseller.Decoder.DecodeFields(reader);
                    case "reseller_admin":
                        return ResellerAdmin.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The not reseller object</para>
        /// </summary>
        public sealed class NotReseller : ResellerRole
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NotReseller> Encoder = new NotResellerEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NotReseller> Decoder = new NotResellerDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NotReseller" />
            /// class.</para>
            /// </summary>
            private NotReseller()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NotReseller</para>
            /// </summary>
            public static readonly NotReseller Instance = new NotReseller();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NotReseller" />.</para>
            /// </summary>
            private class NotResellerEncoder : enc.StructEncoder<NotReseller>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NotReseller value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NotReseller" />.</para>
            /// </summary>
            private class NotResellerDecoder : enc.StructDecoder<NotReseller>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NotReseller" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NotReseller Create()
                {
                    return NotReseller.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The reseller admin object</para>
        /// </summary>
        public sealed class ResellerAdmin : ResellerRole
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<ResellerAdmin> Encoder = new ResellerAdminEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<ResellerAdmin> Decoder = new ResellerAdminDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="ResellerAdmin" />
            /// class.</para>
            /// </summary>
            private ResellerAdmin()
            {
            }

            /// <summary>
            /// <para>A singleton instance of ResellerAdmin</para>
            /// </summary>
            public static readonly ResellerAdmin Instance = new ResellerAdmin();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="ResellerAdmin" />.</para>
            /// </summary>
            private class ResellerAdminEncoder : enc.StructEncoder<ResellerAdmin>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(ResellerAdmin value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="ResellerAdmin" />.</para>
            /// </summary>
            private class ResellerAdminDecoder : enc.StructDecoder<ResellerAdmin>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="ResellerAdmin" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override ResellerAdmin Create()
                {
                    return ResellerAdmin.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : ResellerRole
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
