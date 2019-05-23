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
dotnet "sln" "SOLUTION.sln" "add" "\PROJECT\PROJECT.csproj"
```