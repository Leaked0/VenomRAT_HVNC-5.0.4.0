using System;
using System.Collections.Generic;

namespace Server.MessagePack
{
	// Token: 0x0200003C RID: 60
	public class MsgPackArray
	{
		// Token: 0x06000257 RID: 599 RVA: 0x0001BB9B File Offset: 0x0001BB9B
		public MsgPackArray(MsgPack msgpackObj, List<MsgPack> listObj)
		{
			this.owner = msgpackObj;
			this.children = listObj;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0001BBB1 File Offset: 0x0001BBB1
		public MsgPack Add()
		{
			return this.owner.AddArrayChild();
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0001BBC0 File Offset: 0x0001BBC0
		public MsgPack Add(string value)
		{
			MsgPack msgPack = this.owner.AddArrayChild();
			msgPack.AsString = value;
			return msgPack;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0001BBE4 File Offset: 0x0001BBE4
		public MsgPack Add(long value)
		{
			MsgPack msgPack = this.owner.AddArrayChild();
			msgPack.SetAsInteger(value);
			return msgPack;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0001BC08 File Offset: 0x0001BC08
		public MsgPack Add(double value)
		{
			MsgPack msgPack = this.owner.AddArrayChild();
			msgPack.SetAsFloat(value);
			return msgPack;
		}

		// Token: 0x17000075 RID: 117
		public MsgPack this[int index]
		{
			get
			{
				return this.children[index];
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0001BC37 File Offset: 0x0001BC37
		public int Length
		{
			get
			{
				return this.children.Count;
			}
		}

		// Token: 0x040001FB RID: 507
		private List<MsgPack> children;

		// Token: 0x040001FC RID: 508
		private MsgPack owner;
	}
}
