clear
#dotnet add package Microsoft.EntityFrameworkCore.Design               1> /dev/null
#dotnet add package Microsoft.EntityFrameworkCore.SQLite               1> /dev/null
#dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design   1> /dev/null
#dotnet add package Microsoft.EntityFrameworkCore.SqlServer            1> /dev/null
#dotnet add package Microsoft.EntityFrameworkCore.Tools                1> /dev/null



dotnet aspnet-codegenerator controller  \
-name AlunosController                  \
-m Aluno                                \
-dc Context.AppDbContext                \
--relativeFolderPath Controllers        \
--useDefaultLayout                      \
--referenceScriptLibraries              \
--databaseProvider sqlite               \
