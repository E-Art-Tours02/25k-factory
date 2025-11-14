using UnrealBuildTool;

public class PFE_BacharoTarget : TargetRules
{
	public PFE_BacharoTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("PFE_Bacharo");
	}
}
