// <auto-generated />
#pragma warning disable

using System.CodeDom.Compiler;
using System.Diagnostics;
using global::NUnit.Framework;
using global::TechTalk.SpecFlow;
using global::System.Runtime.CompilerServices;

[GeneratedCode("SpecFlow", "3.7.13")]
[SetUpFixture]
public class EM_Repository_NUnitAssemblyHooks
{
    [OneTimeSetUp]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AssemblyInitialize()
    {
        var currentAssembly = typeof(EM_Repository_NUnitAssemblyHooks).Assembly;

        TestRunnerManager.OnTestRunStart(currentAssembly);
    }

    [OneTimeTearDown]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AssemblyCleanup()
    {
        var currentAssembly = typeof(EM_Repository_NUnitAssemblyHooks).Assembly;

        TestRunnerManager.OnTestRunEnd(currentAssembly);
    }
}
#pragma warning restore
