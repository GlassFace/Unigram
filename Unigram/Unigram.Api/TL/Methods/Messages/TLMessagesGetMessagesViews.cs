// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.getMessagesViews
	/// </summary>
	public partial class TLMessagesGetMessagesViews : TLObject
	{
		public TLInputPeerBase Peer { get; set; }
		public TLVector<Int32> Id { get; set; }
		public Boolean Increment { get; set; }

		public TLMessagesGetMessagesViews() { }
		public TLMessagesGetMessagesViews(TLBinaryReader from, TLType type = TLType.MessagesGetMessagesViews)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.MessagesGetMessagesViews; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.MessagesGetMessagesViews)
		{
			Peer = TLFactory.Read<TLInputPeerBase>(from);
			Id = TLFactory.Read<TLVector<Int32>>(from);
			Increment = from.ReadBoolean();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xC4C8A55D);
			to.WriteObject(Peer);
			to.WriteObject(Id);
			to.Write(Increment);
		}
	}
}