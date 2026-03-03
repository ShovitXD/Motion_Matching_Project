// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class DMC : ModuleRules
{
	public DMC(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"DMC",
			"DMC/Variant_Platforming",
			"DMC/Variant_Platforming/Animation",
			"DMC/Variant_Combat",
			"DMC/Variant_Combat/AI",
			"DMC/Variant_Combat/Animation",
			"DMC/Variant_Combat/Gameplay",
			"DMC/Variant_Combat/Interfaces",
			"DMC/Variant_Combat/UI",
			"DMC/Variant_SideScrolling",
			"DMC/Variant_SideScrolling/AI",
			"DMC/Variant_SideScrolling/Gameplay",
			"DMC/Variant_SideScrolling/Interfaces",
			"DMC/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
