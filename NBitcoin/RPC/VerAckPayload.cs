﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBitcoin.RPC
{
	[Payload("verack")]
	public class VerAckPayload : Payload, IBitcoinSerializable
	{
		#region IBitcoinSerializable Members

		public override void ReadWrite(BitcoinStream stream)
		{
		}

		#endregion
	}
}
