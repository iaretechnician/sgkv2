// Dont steal our shit

using UnrealBuildTool;
using System.Collections.Generic;

public class sgk2Target : TargetRules
{
	public sgk2Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "sgk2" } );
	}
}
