// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The legal holds list policies arg object</para>
    /// </summary>
    public class LegalHoldsListPoliciesArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<LegalHoldsListPoliciesArg> Encoder = new LegalHoldsListPoliciesArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<LegalHoldsListPoliciesArg> Decoder = new LegalHoldsListPoliciesArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LegalHoldsListPoliciesArg" />
        /// class.</para>
        /// </summary>
        /// <param name="includeReleased">Whether to return holds that were released.</param>
        public LegalHoldsListPoliciesArg(bool includeReleased = false)
        {
            this.IncludeReleased = includeReleased;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LegalHoldsListPoliciesArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public LegalHoldsListPoliciesArg()
        {
            this.IncludeReleased = false;
        }

        /// <summary>
        /// <para>Whether to return holds that were released.</para>
        /// </summary>
        public bool IncludeReleased { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="LegalHoldsListPoliciesArg" />.</para>
        /// </summary>
        private class LegalHoldsListPoliciesArgEncoder : enc.StructEncoder<LegalHoldsListPoliciesArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(LegalHoldsListPoliciesArg value, enc.IJsonWriter writer)
            {
                WriteProperty("include_released", value.IncludeReleased, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="LegalHoldsListPoliciesArg" />.</para>
        /// </summary>
        private class LegalHoldsListPoliciesArgDecoder : enc.StructDecoder<LegalHoldsListPoliciesArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="LegalHoldsListPoliciesArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override LegalHoldsListPoliciesArg Create()
            {
                return new LegalHoldsListPoliciesArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(LegalHoldsListPoliciesArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "include_released":
                        value.IncludeReleased = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
