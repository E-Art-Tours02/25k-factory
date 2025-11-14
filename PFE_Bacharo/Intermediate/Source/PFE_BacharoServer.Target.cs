using UnrealBuildTool;

public class PFE_BacharoServerTarget : TargetRules
{
	public PFE_BacharoServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("PFE_Bacharo");
	}
}
