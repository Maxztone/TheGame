using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultEnemyAi : MonoBehaviour
{
    public AIBehaviour shootBehaviour, patrolBehaviour;

    [SerializeField]
    private EnemyController enemy;
    [SerializeField]
    private AIDetectorScript detector;

    private void Awake()
    {
        detector = GetComponentInChildren<AIDetectorScript>();
        enemy = GetComponentInChildren<EnemyController>();
    }

    private void Update()
    {
        if (detector.TargetVisible)
        {
            shootBehaviour.PerformAction(enemy, detector);
        }
        else
        {
            patrolBehaviour.PerformAction(enemy, detector);
        }
    }
}
