// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdatesState : TLObject 
	{
		public Int32 Pts { get; set; }
		public Int32 Qts { get; set; }
		public Int32 Date { get; set; }
		public Int32 Seq { get; set; }
		public Int32 UnreadCount { get; set; }

		public TLUpdatesState() { }
		public TLUpdatesState(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdatesState; } }

		public override void Read(TLBinaryReader from)
		{
			Pts = from.ReadInt32();
			Qts = from.ReadInt32();
			Date = from.ReadInt32();
			Seq = from.ReadInt32();
			UnreadCount = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xA56C2A3E);
			to.Write(Pts);
			to.Write(Qts);
			to.Write(Date);
			to.Write(Seq);
			to.Write(UnreadCount);
		}
	}
}