// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PolygonalMapGenerator : ModuleRules
{
  public PolygonalMapGenerator(ReadOnlyTargetRules ROTargetRules) : base(ROTargetRules)
  {
    PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

    PublicDependencyModuleNames.AddRange(new string[] { "Core", "GameplayTags", "ProceduralMeshComponent" });
    PrivateDependencyModuleNames.AddRange(new string[] { "Delaunator", "DualMesh", "CoreUObject", "Engine", "Slate", "SlateCore" });

  }
}
