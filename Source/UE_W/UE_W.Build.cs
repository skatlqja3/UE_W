// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UE_W : ModuleRules
{
	public UE_W(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });

        // ★ SPUD 추가 (cpp에서만 쓰면 Private에 넣는 게 권장)
        PrivateDependencyModuleNames.AddRange(new string[] {
            "SPUD"
        });
    }
}
