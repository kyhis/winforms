﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

internal static partial class Interop
{
    internal static partial class ComCtl32
    {
        public unsafe struct LVBKIMAGEW
        {
            public LVBKIF ulFlags;
            public IntPtr hbm;
            public char* pszImage;
            public uint cchImageMax;
            public int xOffsetPercent;
            public int yOffsetPercent;
        }
    }
}
