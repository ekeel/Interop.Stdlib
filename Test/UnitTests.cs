using System.Reflection;

namespace Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestLoadEnvFile()
    {
        Env.LoadEnvFile(@"../../../Resources/.env");
        Env.LoadEnvFile(@"../../../Resources/.env", "TEST_PREFIX_");

        var noPrefix = Environment.GetEnvironmentVariable("INTEROP_STDLIB_TEST");
        var prefix = Environment.GetEnvironmentVariable("TEST_PREFIX_INTEROP_STDLIB_TEST");

        Assert.IsNotNull(noPrefix);
        Assert.AreEqual(noPrefix, "12345678900987654321");

        Assert.IsNotNull(prefix);
        Assert.AreEqual(prefix, "12345678900987654321");
    }

    [Test]
    public void TestGet()
    {
        var assembly = Assembly.GetExecutingAssembly();

        var resource = EmbeddedResource.Get<string>(assembly, "Test.Resources.test.txt");

        Assert.IsNotNull(resource);
        Assert.IsNotEmpty(resource);
    }
}
