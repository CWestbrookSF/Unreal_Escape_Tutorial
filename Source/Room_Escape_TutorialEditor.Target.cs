// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Room_Escape_TutorialEditorTarget : TargetRules
{
	public Room_Escape_TutorialEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "Room_Escape_Tutorial" } );
	}
}
