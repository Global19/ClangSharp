// Copyright (c) Microsoft and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

// Ported from https://github.com/llvm/llvm-project/tree/llvmorg-11.0.0/clang/include/clang-c
// Original source is Copyright (c) the LLVM Project and Contributors. Licensed under the Apache License v2.0 with LLVM Exceptions. See NOTICE.txt in the project root for license information.

using System;

namespace ClangSharp.Interop
{
    public unsafe partial struct CXUnsavedFile
    {
        [NativeTypeName("const char *")]
        public sbyte* Filename;

        [NativeTypeName("const char *")]
        public sbyte* Contents;

        [NativeTypeName("unsigned long")]
        public UIntPtr Length;
    }
}
