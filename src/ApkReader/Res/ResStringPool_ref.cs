// Copyright (c) 2012 Markus Jarderot
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.

using System;

namespace ApkReader.Res
{
#if !NETSTANDARD1_3
    [Serializable]
#endif
    public class ResStringPool_ref
    {
        public uint? Index { get; set; }
    }
}