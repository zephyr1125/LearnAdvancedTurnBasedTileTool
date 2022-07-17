// Temp

using UnrealBuildTool;
using System.Collections.Generic;

public class AdvancedTurnBasedTileToolEditorTarget : TargetRules
{
	public AdvancedTurnBasedTileToolEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "AdvancedTurnBasedTileTool" } );
	}
}
