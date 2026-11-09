using Volo.Abp.Modularity;

namespace Resourcery.Projects;

[DependsOn(typeof(ProjectsApplicationModule))]
[DependsOn(typeof(ProjectsDomainTestModule))]
public class ProjectsApplicationTestModule : AbpModule { }
