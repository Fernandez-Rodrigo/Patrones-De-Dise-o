using UnityEngine;

public interface IAttacker
{
    void MakeDamage(TargetEnemy targetEnemy);
    void MoveToTarget(float speed, Transform endTarget);
    
}