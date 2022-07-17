// Temp

using UnrealBuildTool;
using System.Collections.Generic;

public class AdvancedTurnBasedTileToolTarget : TargetRules
{
	public AdvancedTurnBasedTileToolTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "AdvancedTurnBasedTileTool" } );
	}
}
