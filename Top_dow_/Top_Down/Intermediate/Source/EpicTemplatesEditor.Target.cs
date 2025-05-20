using UnrealBuildTool;

public class EpicTemplatesEditorTarget : TargetRules
{
	public EpicTemplatesEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("EpicTemplates");
	}
}
