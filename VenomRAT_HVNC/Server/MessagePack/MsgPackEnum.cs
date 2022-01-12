using System;
using System.Collections;
using System.Collections.Generic;

namespace Server.MessagePack
{
	// Token: 0x0200003B RID: 59
	public class MsgPackEnum : IEnumerator
	{
		// Token: 0x06000253 RID: 595 RVA: 0x0001BB46 File Offset: 0x0001BB46
		public MsgPackEnum(List<MsgPack> obj)
		{
			this.children = obj;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0001BB5C File Offset: 0x0001BB5C
		object IEnumerator.Current
		{
			get
			{
				return this.children[this.position];
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0001BB6F File Offset: 0x0001BB6F
		bool IEnumerator.MoveNext()
		{
			this.position++;
			return this.position < this.children.Count;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0001BB92 File Offset: 0x0001BB92
		void IEnumerator.Reset()
		{
			this.position = -1;
		}

		// Token: 0x040001F9 RID: 505
		private List<MsgPack> children;

		// Token: 0x040001FA RID: 506
		private int position = -1;
	}
}
