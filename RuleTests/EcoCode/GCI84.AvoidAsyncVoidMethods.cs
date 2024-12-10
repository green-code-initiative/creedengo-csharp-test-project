﻿using System.Net.Http;

namespace RuleTests.EcoCode;

internal static class AvoidAsyncVoidMethods
{
    public static async void Method1() => // GCI84, code fix: public static async Task Method1()
        await Task.Delay(1000).ConfigureAwait(false);

    public static async Task Method2() =>
        await Task.Delay(1000).ConfigureAwait(false);

    public static async Task<int> Method3()
    {
        await Task.Delay(1000).ConfigureAwait(false);
        return 1;
    }

    public static async void Method4() // GCI84, code fix: public static async Task Method4()
    {
        using var httpClient = new HttpClient();
        _ = await httpClient.GetAsync(new Uri("URL")).ConfigureAwait(false);
    }
}
