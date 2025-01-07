namespace RuleTests.Creedengo;

// Because GCI85 is a compiler warning, it can't appear live in the editor.
// It can appear in the Error List after a compilation or after using 'Run Code Analysis',
// but only if the option '<AnalysisMode>all</AnalysisMode>' is set in the .csproj file.

internal static class MakeTypeSealed
{
    public class TestA; // GCI85: make type sealed
    internal class TestB; // GCI85: make type sealed
    public static class Test0
    {
        public class Test01; // GCI85: make type sealed
        internal class Test02; // GCI85: make type sealed
        private class Test03; // GCI85: make type sealed
    }
    internal static class Test1
    {
        public class Test11; // GCI85: make type sealed
        internal class Test12; // GCI85: make type sealed
        private class Test13; // GCI85: make type sealed
    }

    public static class SealableClasses
    {
        public class TestA; // GCI85: make type sealed
        internal class TestB; // GCI85: make type sealed
        public static class Test0
        {
            public class Test01; // GCI85: make type sealed
            internal class Test02; // GCI85: make type sealed
            private class Test03; // GCI85: make type sealed
        }
        internal static class Test1
        {
            public class Test11; // GCI85: make type sealed
            internal class Test12; // GCI85: make type sealed
            private class Test13; // GCI85: make type sealed
        }
    }

    public static class SealableRecords
    {
        public record TestA; // GCI85: make type sealed
        internal record TestB; // GCI85: make type sealed
        public static class Test0
        {
            public record Test01; // GCI85: make type sealed
            internal record Test02; // GCI85: make type sealed
            private record Test03; // GCI85: make type sealed
        }
        internal static class Test1
        {
            public record Test11; // GCI85: make type sealed
            internal record Test12; // GCI85: make type sealed
            private record Test13; // GCI85: make type sealed
        }
    }

    public static class NonSealableStructs
    {
        public struct TestA;
        internal struct TestB;
        public static class Test0
        {
            public struct Test01;
            internal struct Test02;
            private struct Test03;
        }
        internal static class Test1
        {
            public struct Test11;
            internal struct Test12;
            private struct Test13;
        }
    }

    public static class StaticClasses
    {
        public static class Test0
        {
            public static class Test01;
            internal static class Test02;
            private static class Test03;
        }
        internal static class Test1
        {
            public static class Test11;
            internal static class Test12;
            private static class Test13;
        }
    }

    public static class AbstractClasses
    {
        public abstract class TestA;
        internal abstract class TestB;
        public static class Test0
        {
            public abstract class Test01;
            internal abstract class Test02;
            private abstract class Test03;
        }
        internal static class Test1
        {
            public abstract class Test11;
            internal abstract class Test12;
            private abstract class Test13;
        }
    }

    public static class SealedClasses
    {
        public sealed class TestA;
        internal sealed class TestB;
        public static class Test0
        {
            public sealed class Test01;
            internal sealed class Test02;
            private sealed class Test03;
        }
        internal static class Test1
        {
            public sealed class Test11;
            internal sealed class Test12;
            private sealed class Test13;
        }
    }

    public static class SealableClassesWithInterface
    {
        public interface ITest { void Method(); }
        public class TestA : ITest { public void Method() { } } // GCI85: make type sealed
        internal class TestB : ITest { public void Method() { } } // GCI85: make type sealed
        public static class Test0
        {
            public class Test01 : ITest { public void Method() { } } // GCI85: make type sealed
            internal class Test02 : ITest { public void Method() { } } // GCI85: make type sealed
            private class Test03 : ITest { public void Method() { } } // GCI85: make type sealed
        }
        internal static class Test1
        {
            public class Test11 : ITest { public void Method() { } } // GCI85: make type sealed
            internal class Test12 : ITest { public void Method() { } } // GCI85: make type sealed
            private class Test13 : ITest { public void Method() { } } // GCI85: make type sealed
        }
    }

    public static class SealableClassesWithOverridable
    {
        public class TestA1 { public virtual void Method() { } }
        public class TestA2 { internal virtual void Method() { } } // GCI85: make type sealed
        public class TestA3 { protected virtual void Method() { } }
        public class TestA4 { protected internal virtual void Method() { } } // GCI85: make type sealed
        public class TestA5 { private protected virtual void Method() { } } // GCI85: make type sealed

        internal class TestB1 { public virtual void Method() { } } // GCI85: make type sealed
        internal class TestB2 { internal virtual void Method() { } } // GCI85: make type sealed
        internal class TestB3 { protected virtual void Method() { } } // GCI85: make type sealed
        internal class TestB4 { protected internal virtual void Method() { } } // GCI85: make type sealed
        internal class TestB5 { private protected virtual void Method() { } } // GCI85: make type sealed

        public static class Test0
        {
            public class TestA1 { public virtual void Method() { } }
            public class TestA2 { internal virtual void Method() { } } // GCI85: make type sealed
            public class TestA3 { protected virtual void Method() { } }
            public class TestA4 { protected internal virtual void Method() { } } // GCI85: make type sealed
            public class TestA5 { private protected virtual void Method() { } } // GCI85: make type sealed

            internal class TestB1 { public virtual void Method() { } } // GCI85: make type sealed
            internal class TestB2 { internal virtual void Method() { } } // GCI85: make type sealed
            internal class TestB3 { protected virtual void Method() { } } // GCI85: make type sealed
            internal class TestB4 { protected internal virtual void Method() { } } // GCI85: make type sealed
            internal class TestB5 { private protected virtual void Method() { } } // GCI85: make type sealed

            private class TestC1 { public virtual void Method() { } } // GCI85: make type sealed
            private class TestC2 { internal virtual void Method() { } } // GCI85: make type sealed
            private class TestC3 { protected virtual void Method() { } } // GCI85: make type sealed
            private class TestC4 { protected internal virtual void Method() { } } // GCI85: make type sealed
            private class TestC5 { private protected virtual void Method() { } } // GCI85: make type sealed
        }

        internal static class Test1
        {
            public class TestA1 { public virtual void Method() { } } // GCI85: make type sealed
            public class TestA2 { internal virtual void Method() { } } // GCI85: make type sealed
            public class TestA3 { protected virtual void Method() { } } // GCI85: make type sealed
            public class TestA4 { protected internal virtual void Method() { } } // GCI85: make type sealed
            public class TestA5 { private protected virtual void Method() { } } // GCI85: make type sealed

            internal class TestB1 { public virtual void Method() { } } // GCI85: make type sealed
            internal class TestB2 { internal virtual void Method() { } } // GCI85: make type sealed
            internal class TestB3 { protected virtual void Method() { } } // GCI85: make type sealed
            internal class TestB4 { protected internal virtual void Method() { } } // GCI85: make type sealed
            internal class TestB5 { private protected virtual void Method() { } } // GCI85: make type sealed

            private class TestC1 { public virtual void Method() { } } // GCI85: make type sealed
            private class TestC2 { internal virtual void Method() { } } // GCI85: make type sealed
            private class TestC3 { protected virtual void Method() { } } // GCI85: make type sealed
            private class TestC4 { protected internal virtual void Method() { } } // GCI85: make type sealed
            private class TestC5 { private protected virtual void Method() { } } // GCI85: make type sealed
        }
    }

    public static class Inheritance
    {
        public abstract class Test2 { public virtual void Overridable() { } }
        public class Test3 : Test2;
        public sealed class Test4 : Test3;
        public class Test5 : Test3;
        public class Test6 : Test3 { public override void Overridable() { } }
        public class Test7 : Test3 { public sealed override void Overridable() { } } // GCI85: make type sealed
        public class Test8 : Test3 { public sealed override void Overridable() { } }
        public class Test9 : Test8; // GCI85: make type sealed
    }

    public static class Partial
    {
        public partial class Test1; // GCI85: make type sealed
        partial class Test1(int Value) { public int Method() => Value; }

        partial record Test2(int Value)
        {
            public int Method() => Value;
        }
        public partial record Test2; // GCI85: make type sealed

        public partial class Test3;
        partial class Test3 { public virtual void Method() { } }

        public partial class Test4;
        sealed partial class Test4(int Value) { public int Method() => Value; }
    }
}
