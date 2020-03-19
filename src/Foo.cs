using System.Collections.Generic;

namespace CSharpWrapperMaker.TestClass
{
    public abstract class Foo : FooParent
    {
        public string Qux { get; set; }

        public List<string> Jix { get; set; }

        public string Quux { get; private set; }

        public Foo() { }

        public override int GetNumber() => 3;

        public abstract int Baz();

        public override int Jazz()
        {
            return 10;
        }

        public List<T> Corge<T, U>(T aun, U aux) => null;
    }
}
