// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Account
{
	/// <summary>
	/// RCP method account.getPrivacy
	/// </summary>
	public partial class TLAccountGetPrivacy : TLObject
	{
		public TLInputPrivacyKeyBase Key { get; set; }

		public TLAccountGetPrivacy() { }
		public TLAccountGetPrivacy(TLBinaryReader from, TLType type = TLType.AccountGetPrivacy)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.AccountGetPrivacy; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.AccountGetPrivacy)
		{
			Key = TLFactory.Read<TLInputPrivacyKeyBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xDADBC950);
			to.WriteObject(Key);
		}
	}
}