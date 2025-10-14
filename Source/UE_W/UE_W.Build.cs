// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UE_W : ModuleRules
{
	public UE_W(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });

        // ★ SPUD 추가 (cpp에서만 쓰면 Private에 넣는 게 권장)
        // C++에서 CommonUI 타입을 include/사용할 때 필요
        PrivateDependencyModuleNames.AddRange(new string[] {
        "SPUD",
        "CommonUI",
        "CommonInput",
        "EnhancedInput",
        "UMG",
        "Slate",
        "SlateCore"
        });

    }
}
