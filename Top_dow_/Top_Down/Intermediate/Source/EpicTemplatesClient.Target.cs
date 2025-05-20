using UnrealBuildTool;

public class EpicTemplatesClientTarget : TargetRules
{
	public EpicTemplatesClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("EpicTemplates");
	}
}
