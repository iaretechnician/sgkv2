// Dont steal our shit

using UnrealBuildTool;
using System.Collections.Generic;

public class sgk2EditorTarget : TargetRules
{
	public sgk2EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "sgk2" } );
	}
}
