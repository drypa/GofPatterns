using System;
using Singleton.Canonical;
using Singleton.Lazy;
using Singleton.Nested;
using Singleton.StaticReadonly;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            CanonicalSingletonLogger.Instance.Log("Hello from CanonicalSingletonLogger");

            LazySingletonLogger.Instance.Log("Hello from LazySingletonLogger");

            StaticReadonlySingletonLogger.Instance.Log("Hello from StaticReadonlySingletonLogger");

            NestedSingletonLogger.Instance.Log("Hello from NestedSingletonLogger");

            Console.ReadLine();
        }

    }
}
