using UnrealBuildTool;

public class PFE_BacharoEditorTarget : TargetRules
{
	public PFE_BacharoEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("PFE_Bacharo");
	}
}
