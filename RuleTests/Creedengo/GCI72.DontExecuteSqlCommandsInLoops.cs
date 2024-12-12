using System.Data;

namespace RuleTests.Creedengo;

internal static class DontExecuteSqlCommandsInLoops
{
    public static void Run()
    {
        var command = default(IDbCommand)!; // GCI82, code fix: const IDbCommand command = default!;
        _ = command.ExecuteNonQuery();
        _ = command.ExecuteScalar();
        _ = command.ExecuteReader();
        _ = command.ExecuteReader(CommandBehavior.Default);

        for (int i = 0; i < 10; i++)
        {
            _ = command.ExecuteNonQuery(); // GCI72
            _ = command.ExecuteScalar(); // GCI72
            _ = command.ExecuteReader(); // GCI72
            _ = command.ExecuteReader(CommandBehavior.Default); // GCI72
        }
    }
}
