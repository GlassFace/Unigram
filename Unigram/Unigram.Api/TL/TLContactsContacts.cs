// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLContactsContacts : TLContactsContactsBase 
	{
		public TLVector<TLContact> Contacts { get; set; }
		public TLVector<TLUserBase> Users { get; set; }

		public TLContactsContacts() { }
		public TLContactsContacts(TLBinaryReader from, TLType type = TLType.ContactsContacts)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.ContactsContacts; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.ContactsContacts)
		{
			Contacts = TLFactory.Read<TLVector<TLContact>>(from);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x6F8B8CB2);
			to.WriteObject(Contacts);
			to.WriteObject(Users);
		}
	}
}