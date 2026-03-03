// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "DMCGameMode.generated.h"

/**
 *  Simple GameMode for a third person game
 */
UCLASS(abstract)
class ADMCGameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	
	/** Constructor */
	ADMCGameMode();
};



