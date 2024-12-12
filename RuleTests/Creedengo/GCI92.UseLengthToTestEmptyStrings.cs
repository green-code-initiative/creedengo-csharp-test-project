namespace RuleTests.Creedengo;

internal static class UseLengthToTestEmpyString
{
    public static void Test(string s)
    {
        if (s == "") // GCI92
        {
            Console.WriteLine("Empty");
        }
    }
}
