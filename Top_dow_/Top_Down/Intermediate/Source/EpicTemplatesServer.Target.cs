using UnrealBuildTool;

public class EpicTemplatesServerTarget : TargetRules
{
	public EpicTemplatesServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("EpicTemplates");
	}
}
