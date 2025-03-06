using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class AddHealthEffect : UsableItem.UsageEffect
{
    public int HealthAmount;
    public override bool Use(CharacterData user)
    {
        if (user.Stats.CurrentHealth == user.Stats.baseStats.health) {
            return false;
        }
        else {
            user.Stats.ChangeHealth(HealthAmount);
         return true;
        }
    }
}
