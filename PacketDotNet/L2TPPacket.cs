/*
This file is part of PacketDotNet

PacketDotNet is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

PacketDotNet is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with PacketDotNet.  If not, see <http://www.gnu.org/licenses/>.
*/
/*
 *  Copyright 2018 Steven Haufe<haufes@hotmail.com>
  */
using System;
using System.Collections.Generic;
using System.Text;
using MiscUtil.Conversion;
using PacketDotNet.Utils;

namespace PacketDotNet
{
    /// <summary>
    /// An L2TP packet.
    /// </summary>
    [Serializable]
    public class L2TPPacket : Packet
    {

        public virtual Boolean DataMessage => 8 == (header.Bytes[header.Offset] & 0x8);

        public virtual Boolean HasLength => 4 == (header.Bytes[header.Offset] & 0x4);

        public virtual Boolean HasSequence => 2 == (header.Bytes[header.Offset] & 0x2);

        public virtual Boolean HasOffset => 2 == (header.Bytes[header.Offset] & 0x2);

        public virtual Boolean IsPriority => 2 == (header.Bytes[header.Offset] & 0x2);

        public virtual Int32 Version => (header.Bytes[header.Offset + 1] & 0x7);

        public virtual Int32 TunnelID
        {
            get
            {
                if (HasLength)
                    return EndianBitConverter.Big.ToUInt16(header.Bytes, header.Offset + 3);
                else
                    return EndianBitConverter.Big.ToUInt16(header.Bytes, header.Offset + 2);

            }
        }

        public virtual Int32 SessionID
        {
            get
            {
                if (HasLength)
                    return EndianBitConverter.Big.ToUInt16(header.Bytes, header.Offset + 5);
                else
                    return EndianBitConverter.Big.ToUInt16(header.Bytes, header.Offset + 4);

            }
        }

        /// <summary> Fetch ascii escape sequence of the color associated with this packet type.</summary>
        public override System.String Color => AnsiEscapeSequences.DarkGray;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="bas">
        /// A <see cref="ByteArraySegment"/>
        /// </param>
        public L2TPPacket(ByteArraySegment bas, Packet ParentPacket)
        {
            // slice off the header portion
            header = new ByteArraySegment(bas);

            header.Length = L2TPFields.HeaderLength;
            if (HasLength)
                header.Length += L2TPFields.LengthsLength;
            if (HasSequence)
                header.Length += L2TPFields.NsLength + L2TPFields.NrLength;
            if (HasOffset)
                header.Length += L2TPFields.OffsetSizeLength + L2TPFields.OffsetPadLength;

            var payload = header.EncapsulatedBytes();
            try
            {
                PayloadPacket = new PPPPacket(payload);
                PayloadPacket.ParentPacket = this;
            } catch (Exception)
            {
                //it's not a PPP packet, just attach the data
                payloadPacketOrData.Value.TheByteArraySegment = payload;
            }
            this.ParentPacket = ParentPacket;
        }


        /// <summary cref="Packet.ToString(StringOutputType)" />
        public override String ToString(StringOutputType outputFormat)
        {
            var buffer = new StringBuilder();
            String color = "";
            String colorEscape = "";
            

            if(outputFormat == StringOutputType.Colored || outputFormat == StringOutputType.VerboseColored)
            {
                color = Color;
                colorEscape = AnsiEscapeSequences.Reset;
            }

            if(outputFormat == StringOutputType.Normal || outputFormat == StringOutputType.Colored)
            {
                // build the output string
                buffer.AppendFormat("{0}[L2TPPacket",
                    color,
                    colorEscape);
            }


            // append the base string output
            buffer.Append(base.ToString(outputFormat));
            
            return buffer.ToString();
        }
    }
}
