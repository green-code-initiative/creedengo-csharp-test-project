﻿using System.Runtime.InteropServices;

namespace RuleTests.EcoCode;

internal static class SpecifyStructLayout
{
    public readonly record struct TestStruct1;

    public readonly record struct TestStruct2(int A);

    public readonly record struct TestStruct3(int A, double B); // GCI81, code fix: Add StructLayout attribute (Auto or Sequential)

    [StructLayout(LayoutKind.Auto)]
    public readonly record struct TestStruct4(int A, double B);

    public readonly record struct TestStruct5(int A, string B);

    public readonly record struct TestStruct6(int A, double B, int C); // GCI81, code fix: Add StructLayout attribute (Auto or Sequential)

    public readonly record struct TestStruct7(bool A, int B, char C, ulong E, DateTime F); // GCI81, code fix: Add StructLayout attribute (Auto or Sequential)
}
