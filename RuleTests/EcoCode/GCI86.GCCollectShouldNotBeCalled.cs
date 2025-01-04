namespace RuleTests.EcoCode;

internal static class GCCollectShouldNotBeCalled
{
    public static void Run()
    {
        // GC.Collect();

        GC.Collect(); // GCI86

        GC.Collect(); // GCI86

        GC.Collect(0);

        GC.Collect(2); // GCI86

        GC.Collect(0, GCCollectionMode.Optimized);

        GC.Collect(2, GCCollectionMode.Forced); // GCI86

        GC.Collect(generation: 0, GCCollectionMode.Optimized);

        GC.Collect(generation: 2, GCCollectionMode.Optimized); // GCI86

        GC.Collect(mode: GCCollectionMode.Optimized, generation: 0);

        GC.Collect(mode: GCCollectionMode.Optimized, generation: 2); // GCI86
    }
}
