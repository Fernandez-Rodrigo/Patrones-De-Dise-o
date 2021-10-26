using UnityEngine;

public interface IAttacker
{
    void MakeDamage(ITargetEnemy targetEnemy);
    void AddDamage(int bonusDamage, string type);
  
    
}