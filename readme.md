# Selenium

## CLI

### Create a Test project

- XUnit

```bash
dotnet "new" "xunit" "-lang" "C#" "-n" "Selenium.XUnit" "-o" "Selenium.XUnit"
```

- MSTest

```bash
dotnet "new" "mstest" "-lang" "C#" "-n" "Selenium.MSTest" "-o" "Selenium.MSTest"
```

- NUnit

```bash
dotnet "new" "nunit" "-lang" "C#" "-n" "Selenium.NUnit" "-o" "Selenium.NUnit"
```

- Add to project

```bash
dotnet sln "SOLUTION.sln" add "\PROJECT\PROJECT.csproj"
```

- Add reference

```bash
dotnet add "PROJECT/PROJECT.csproj" reference "PROJECT_LIB/PROJECT_LIB.csproj"
```

- Create a new library project

```bash
dotnet new classlib -lang C# -n PROJECT_NAME -o PROJECT_FOLDER
```

### SpecFlow

```bash
dotnet add ./PROJECT.csproj package SpecFlow
dotnet add ./PROJECT.csproj package SpecFlow.Tools.MsBuild.Generation
dotnet add ./PROJECT.csproj package SpecRun.SpecFlow
```