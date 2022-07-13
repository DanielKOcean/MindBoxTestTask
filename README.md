# MindBoxTestTask
Test task for position "Intern-Developer C# (fullstack / back-end)" at Mindbox

### Actions (project  structure initialization):
* dotnet new gitignore
* dotnet new sln
* dotnet new classlib -o src/ShapesLib
* dotnet new nunit -o tests/ShapesLib.Tests
* dotnet add .\tests\ShapesLib.Tests\ reference .\src\ShapesLib
* dotnet sln add .\src\ShapesLib\
* dotnet sln add .\tests\ShapesLib.Tests\
