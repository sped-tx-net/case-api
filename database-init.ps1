


Update-Package Microsoft.EntityFrameworkCore.SqlServer
Update-Package Microsoft.EntityFrameworkCore.Tools

$SqlProvider = "Microsoft.EntityFrameworkCore.SqlServer"

$SqlConnection = "Server=.;Database=Case-DB;Trusted_Connection=True;MultipleActiveResultSets=True"

$Context = "CaseApiContext"
$ContextDir = "$PSScriptRoot\src\Ims.Case.Core"
$ContextNamespace = "Ims.Case.Entities"

$EntityDir = "$PSScriptRoot\src\Ims.Case.Core\Entities"
$EntityNamespace = "Ims.Case.Entities"

$Project = "Ims.Case.Core"
$StartupProject = "Ims.Case.Api"

$MigrationDir = "$PSScriptRoot\src\Ims.Case.Core\Migrations"
$MigrationNamespace = "Ims.Case.Data"






Scaffold-DbContext -Connection $SqlConnection `
                   -Provider $SqlProvider `
                   -OutputDir $EntityDir `
                   -ContextDir $ContextDir `
                   -Context $Context `
                   -ContextNamespace $ContextNamespace `
                   -Namespace $EntityNamespace `
                   -StartupProject $StartupProject `
                   -Project $Project `
                   -NoOnConfiguring `
                   -NoPluralize `
                   -UseDatabaseNames `
                   -Force 



<#
Remove-Migration -Context $Context `
                 -Project $Project `
                 -StartupProject $StartupProject `
                 -Force
#>

<#
Add-Migration -Name "InitialMigres" `
              -OutputDir $MigrationDir `
              -Namespace $MigrationNamespace `
              -Context $Context `
              -StartupProject $StartupProject `
              -Project $Project
#>


#Update-Database -Context "Ims.Case.CaseContext" -Project "Ims.Case.Core" -StartupProject "Ims.Case.Web" -Connection "Server=.;Database=Case_DB;Trusted_Connection=True;MultipleActiveResultSets=True"