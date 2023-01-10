using System.Reflection;

namespace Ekeel.Interop.Stdlib;

/// <summary>
/// Class <c>EmbeddedResource</c> contains method for working with embedded resources.
/// </summary>
public class EmbeddedResource
{
    /// <summary>
    /// Returns an embedded resource of the given type.
    /// </summary>
    /// <typeparam name="TResult">The type of the resource to return.</typeparam>
    /// <param name="assembly">The assembly to get the embedded resource from.</param>
    /// <param name="name">The name of the resource to retrieve.</param>
    /// <returns>The TResult containing the resource or null if not found.</returns>
    public static TResult? Get<TResult>(Assembly assembly, string name)
    {
        object retObject;

        using (Stream stream = assembly.GetManifestResourceStream(name))
        {
            using (StreamReader reader = new StreamReader(stream))
            {
                retObject = reader.ReadToEnd();
            }
        }

        return (TResult?)retObject;
    }
}
