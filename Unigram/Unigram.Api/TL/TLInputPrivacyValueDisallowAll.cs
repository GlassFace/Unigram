// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputPrivacyValueDisallowAll : TLInputPrivacyRuleBase 
	{
		public TLInputPrivacyValueDisallowAll() { }
		public TLInputPrivacyValueDisallowAll(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputPrivacyValueDisallowAll; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xD66B66C9);
		}
	}
}