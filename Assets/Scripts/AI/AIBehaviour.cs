using System;
using UnityEngine;

public abstract class AIBehaviour: MonoBehaviour
{
    public abstract void PerformAction(EnemyController enemy, AIDetectorScript detector);
}