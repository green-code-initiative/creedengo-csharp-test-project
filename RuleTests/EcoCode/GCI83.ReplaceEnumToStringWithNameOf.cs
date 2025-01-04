namespace RuleTests.EcoCode;

internal static class ReplaceEnumToStringWithNameOf
{
    private enum MyEnum { A, B, C, D }

    public static void Run()
    {
        Console.WriteLine(nameof(MyEnum.A));
        Console.WriteLine(nameof(MyEnum.B));
        Console.WriteLine(nameof(MyEnum.C));
        Console.WriteLine(nameof(MyEnum.D));

        Console.WriteLine(MyEnum.A.ToString()); // GCI83, code fix: nameof(MyEnum.A)
        Console.WriteLine(MyEnum.B.ToString("")); // GCI83, code fix: nameof(MyEnum.B)
        Console.WriteLine(MyEnum.C.ToString(string.Empty)); // GCI83, code fix: nameof(MyEnum.C)
        Console.WriteLine(MyEnum.D.ToString(format: null)); // GCI83, code fix: nameof(MyEnum.D)

        Console.WriteLine(MyEnum.A.ToString("G")); // GCI83, code fix: nameof(MyEnum.A)
        Console.WriteLine(MyEnum.B.ToString("F")); // GCI83, code fix: nameof(MyEnum.B)
        Console.WriteLine(MyEnum.C.ToString("N"));

        Console.WriteLine($"{MyEnum.A}"); // GCI83, code fix: nameof(MyEnum.A)
        Console.WriteLine($"{MyEnum.B:G}"); // GCI83, code fix: nameof(MyEnum.B)
        Console.WriteLine($"{MyEnum.C:F}"); // GCI83, code fix: nameof(MyEnum.C)
        Console.WriteLine($"{MyEnum.D:N}");
    }
}
