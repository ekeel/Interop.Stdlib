namespace Ekeel.Interop.Stdlib;

/// <summary>
/// Class <c>Env</c> contains methods for working with .env files.
/// </summary>
public class Env
{
    /// <summary>
    /// Parses an env file and creates/sets the environment variable for each key.
    /// </summary>
    /// <param name="path">The path to the .env file to parse.</param>
    public static void LoadEnvFile(string path)
    {
        foreach (var line in File.ReadAllLines(path))
        {
            var parts = line.Split('=', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 2)
                continue;

            Environment.SetEnvironmentVariable(parts[0], parts[1]);
        }
    }

    /// <summary>
    /// Parses an env file and creates/sets the environment variable for each key.
    /// </summary>
    /// <param name="path">The path to the .env file to parse.</param>
    /// <param name="prefix">A prefix to append to each environment variable.</param>
    public static void LoadEnvFile(string path, string prefix)
    {
        foreach (var line in File.ReadAllLines(path))
        {
            var parts = line.Split('=', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 2)
                continue;

            Environment.SetEnvironmentVariable($"{prefix}{parts[0]}", parts[1]);
        }
    }
}

