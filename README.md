# MindBoxTestTask
## Test task for position "Intern-Developer C# (fullstack / back-end)" at Mindbox

### Actions (project  structure initialization):
* dotnet new gitignore
* dotnet new sln
* dotnet new classlib -o src/ShapesLib
* dotnet new nunit -o tests/ShapesLib.Tests
* dotnet add .\tests\ShapesLib.Tests\ reference .\src\ShapesLib
* dotnet sln add .\src\ShapesLib\
* dotnet sln add .\tests\ShapesLib.Tests\

### Check "add-sector-shape" branch to see tipical shape addition


P.S. Не мог уделить много времени на рефакторинг/структурирование тестов, так что сделал всё топорно.

## Скрипт второго задания с SQL находится в файле "many-to-many.sql" в корневой папке.

### Структура Product:
| ProductId | ProductName                   |
|-----------|-------------------------------|
| 1         | PC AMD Rizen5600 for Students |
| 2         | Video Card NVidia RTX3070Ti   |
| 3         | Picture Frame 20cm x 30cm     |

### Структура Category:
| CategoryId | CategoryName |
|------------|--------------|
| 1          | Electronics  |
| 2          | Study        |

### Структура ProductCategory:
| ProductId | CategoryId |
|-----------|------------|
| 1         | 1          |
| 1         | 2          |
| 2         | 1          |

### Результат SELECT:
| Product                       | Category    |
|-------------------------------|-------------|
| PC AMD Rizen5600 for Students | Electronics |
| PC AMD Rizen5600 for Students | Study       |
| Video Card NVidia RTX3070Ti   | Electronics |
| Picture Frame 20cm x 30cm     | NULL        |

P.S.P.S. Прошу прощение за нижний регистр в SQL-запросах :)