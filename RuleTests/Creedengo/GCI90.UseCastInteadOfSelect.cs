namespace RuleTests.Creedengo;

internal static class UseCastInteadOfSelect
{
    public class BaseType { }
    public class DerivedType : BaseType { }

    public static IEnumerable<object> WarnOnSimpleSelectAsync(IEnumerable<string> values) =>
        values.Select(i => (object)i); // EC90 -> values.Cast<object>()

    public static IEnumerable<object?> WarnOnSimpleSelectWithNullabeAsync(IEnumerable<string?> values) =>
        values.Select(i => (object?)i); // EC90 -> values.Cast<object?>()

    public static void WarnOnMultipleSelectAsync(IEnumerable<DerivedType> derived)
    {
        _ = derived.Select(dt => (BaseType)dt); // EC90 -> derived.Cast<BaseType>()
        _ = derived.Select(dt => (BaseType?)dt); // EC90 -> derived.Cast<BaseType?>()

        _ = derived.Select(i => (object)i); // EC90 -> derived.Cast<object>()
        _ = derived.Select(i => (object?)i); // EC90 -> derived.Cast<object?>()

        _ = derived.Select<DerivedType, object>(i => i); // EC90 -> derived.Cast<object>()
        _ = derived.Select<DerivedType, object?>(i => i); // EC90 -> derived.Cast<object?>()

        _ = Enumerable.Range(0, 1).Select<int, object>(i => i); // EC90 -> Enumerable.Range(0, 1).Cast<object>()
        _ = Enumerable.Range(0, 1).Select<int, object?>(i => i); // EC90 -> Enumerable.Range(0, 1).Cast<object?>()
    }

    public static void DontWarnOnMultipleCastAsync(IEnumerable<DerivedType> derived)
    {
        _ = derived.Cast<BaseType>();
        _ = derived.Cast<BaseType?>();

        _ = derived.Cast<object>();
        _ = derived.Cast<object?>();

        _ = Enumerable.Range(0, 1).Cast<object>();
        _ = Enumerable.Range(0, 1).Cast<object?>();
    }
}
