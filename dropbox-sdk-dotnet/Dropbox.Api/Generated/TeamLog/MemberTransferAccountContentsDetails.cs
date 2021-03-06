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
    /// <para>Transferred contents of deleted member account to another member.</para>
    /// </summary>
    public class MemberTransferAccountContentsDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberTransferAccountContentsDetails> Encoder = new MemberTransferAccountContentsDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberTransferAccountContentsDetails> Decoder = new MemberTransferAccountContentsDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="MemberTransferAccountContentsDetails" /> class.</para>
        /// </summary>
        public MemberTransferAccountContentsDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MemberTransferAccountContentsDetails" />.</para>
        /// </summary>
        private class MemberTransferAccountContentsDetailsEncoder : enc.StructEncoder<MemberTransferAccountContentsDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberTransferAccountContentsDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MemberTransferAccountContentsDetails" />.</para>
        /// </summary>
        private class MemberTransferAccountContentsDetailsDecoder : enc.StructDecoder<MemberTransferAccountContentsDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="MemberTransferAccountContentsDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberTransferAccountContentsDetails Create()
            {
                return new MemberTransferAccountContentsDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MemberTransferAccountContentsDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
