# Ekeel.Interop.Stdlib

A set of core modules for use in other Ekeel.Interop packages.

## `EnvLoader`

### Instance Methods

### Static Methods

#### `void LoadEnvFile(string path)`

> Parses an env file and creates/sets the environment variable for each key.
>
> Parameters:
> - `path`
>   - The path to the .env file to parse.
>
> Examples:
> ```csharp
> EnvLoader.LoadEnvFile(@"C:\tmp\test.env");
> ```

## `EmbeddedResource`

### Instance Methods

### Static Methods

#### `TResult? Get<TResult>(Assembly assembly, string name)`

> Returns an embedded resource of the given type.
>
> Type Parameters:
> - `TResult`
>   - The type of the resource to return.
>
> Parameters:
> - `assembly`
>   - The assembly to get the embedded resource from.
> - `name`
>   - The name of the resource to retrieve.
>
> Examples:
> ```csharp
> EmbeddedResource.Get<string>(Assembly.GetExecutingAssembly(), "Ekeel.Interop.GoLang.Resources.Templates.CSProj.tmpl");
> ```