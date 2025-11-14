using UnrealBuildTool;

public class PFE_BacharoClientTarget : TargetRules
{
	public PFE_BacharoClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("PFE_Bacharo");
	}
}
