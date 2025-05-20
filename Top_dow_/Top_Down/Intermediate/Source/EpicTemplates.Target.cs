using UnrealBuildTool;

public class EpicTemplatesTarget : TargetRules
{
	public EpicTemplatesTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("EpicTemplates");
	}
}
