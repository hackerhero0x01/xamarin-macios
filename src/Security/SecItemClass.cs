//
// SecItemClass.cs
//
// Author: Jeffrey Stedfast <jeff@xamarin.com>
//
// Copyright (c) 2013 Jeffrey Stedfast
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

#nullable enable

#if MONOMAC

using System;

namespace Security {

	// this is only available on OSX (not iOS)
	// typedef FourCharCode 	SecItemClass;
	// 	where FourCharCode is an UInt32
	// Security.framework/Versions/A/Headers/SecKeychainItem.h
	public enum SecItemClass : uint {
		InternetPassword     = 1768842612, // 'inet'
		GenericPassword      = 1734700656, // 'genp'
		AppleSharePassword   = 1634953328, // 'ashp'
		Certificate          = 0x80000000 + 0x1000,
		PublicKey            = 0x0000000A + 5,
		PrivateKey           = 0x0000000A + 6,
		SymmetricKey         = 0x0000000A + 7
	}
}

#endif
