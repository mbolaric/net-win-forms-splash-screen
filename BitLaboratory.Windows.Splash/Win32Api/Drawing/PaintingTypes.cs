/*
*
* Copyright (C) 2004 - BitLaboratory
* All rights reserved. 
*
* Redistribution and use in source and binary forms, with or without modification, 
* are permitted provided that the following conditions are met:
*
* 1. Redistributions of source code must retain the above copyright notice,
*    this list of conditions and the following disclaimer.
* 2. Redistributions in binary form must reproduce the above copyright notice,
*    this list of conditions and the following disclaimer in the documentation
*    and/or other materials provided with the distribution.
* 3. The name of the author may not be used to endorse or promote products
*    derived from this software without specific prior written permission. 
*
* THIS SOFTWARE IS PROVIDED BY THE AUTHOR ``AS IS'' AND ANY EXPRESS OR IMPLIED 
* WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF 
* MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT 
* SHALL THE AUTHOR BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, 
* EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT 
* OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN 
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING 
* IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY 
* OF SUCH DAMAGE.
*
* You can find the latest version of this library at https://github.com/mbolaric/net-win-forms-splash
*
*/


using System;
using System.Runtime.InteropServices;

namespace BitLaboratory.Win32Api.Drawing
{
	[StructLayout(LayoutKind.Sequential)]
	internal struct PAINTSTRUCT
	{
		public bool fErase;
		public bool fIncUpdate;
		public bool fRestore;
		public IntPtr hdc;
		public int rcPaint_bottom;
		public int rcPaint_left;
		public int rcPaint_right;
		public int rcPaint_top;
		public int reserved1;
		public int reserved2;
		public int reserved3;
		public int reserved4;
		public int reserved5;
		public int reserved6;
		public int reserved7;
		public int reserved8;
	}
}