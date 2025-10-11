// Copyright Epic Games, Inc. All Rights Reserved.

#include "UE_WGameMode.h"
#include "UE_WCharacter.h"
#include "UObject/ConstructorHelpers.h"

AUE_WGameMode::AUE_WGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPerson/Blueprints/BP_ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
