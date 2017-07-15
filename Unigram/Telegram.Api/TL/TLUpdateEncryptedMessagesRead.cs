// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateEncryptedMessagesRead : TLUpdateBase 
	{
		public Int32 ChatId { get; set; }
		public Int32 MaxDate { get; set; }
		public Int32 Date { get; set; }

		public TLUpdateEncryptedMessagesRead() { }
		public TLUpdateEncryptedMessagesRead(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateEncryptedMessagesRead; } }

		public override void Read(TLBinaryReader from)
		{
			ChatId = from.ReadInt32();
			MaxDate = from.ReadInt32();
			Date = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x38FE25B7);
			to.Write(ChatId);
			to.Write(MaxDate);
			to.Write(Date);
		}
	}
}