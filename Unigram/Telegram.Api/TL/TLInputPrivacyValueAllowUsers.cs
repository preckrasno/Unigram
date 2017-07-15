// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputPrivacyValueAllowUsers : TLInputPrivacyRuleBase 
	{
		public TLVector<TLInputUserBase> Users { get; set; }

		public TLInputPrivacyValueAllowUsers() { }
		public TLInputPrivacyValueAllowUsers(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputPrivacyValueAllowUsers; } }

		public override void Read(TLBinaryReader from)
		{
			Users = TLFactory.Read<TLVector<TLInputUserBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x131CC67F);
			to.WriteObject(Users);
		}
	}
}