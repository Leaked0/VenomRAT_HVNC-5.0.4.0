using System;

namespace Server.MessagePack
{
	// Token: 0x02000040 RID: 64
	public enum MsgPackType
	{
		// Token: 0x04000213 RID: 531
		Unknown,
		// Token: 0x04000214 RID: 532
		Null,
		// Token: 0x04000215 RID: 533
		Map,
		// Token: 0x04000216 RID: 534
		Array,
		// Token: 0x04000217 RID: 535
		String,
		// Token: 0x04000218 RID: 536
		Integer,
		// Token: 0x04000219 RID: 537
		UInt64,
		// Token: 0x0400021A RID: 538
		Boolean,
		// Token: 0x0400021B RID: 539
		Float,
		// Token: 0x0400021C RID: 540
		Single,
		// Token: 0x0400021D RID: 541
		DateTime,
		// Token: 0x0400021E RID: 542
		Binary
	}
}
