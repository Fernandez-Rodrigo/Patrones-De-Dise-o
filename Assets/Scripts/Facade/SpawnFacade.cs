using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFacade : MonoBehaviour
{
    private CharacterFactory currentCharacFactory;
    [SerializeField] private KeySpawner keySpawner;
    [SerializeField] private HeroConfig heroConfiguration;
    [SerializeField] private WeaponConfig weaponConfiguration;

    [SerializeField] private ZombieSpawnerFactory _zombieSpawnFactory;

    private void Awake()
    {
        var heroFactory = new HeroSpawnerFactory(Instantiate(heroConfiguration));
        var weaponFactory = new WeaponFactory(Instantiate(weaponConfiguration));

      
        currentCharacFactory = new CharacterFactory(heroFactory, weaponFactory);
        
    }

 

    #region Abstrac Factory Spawner
    public void SpawnMale()
    {
        currentCharacFactory.CreateHero("Male");
      
    }
    public void SpawnFemale()
    {
        currentCharacFactory.CreateHero("Female");
    }

    public void SpawnSword1()
    {
        currentCharacFactory.CreateWeapon("Sword1");
    }
    public void SpawnSword2()
    {
        currentCharacFactory.CreateWeapon("Sword2");
    }
    public void SpawnSword3()
    {
        currentCharacFactory.CreateWeapon("Sword3");
    }
    #endregion

    #region Factory Spawner
    public void SpawnZombie()
    {
        _zombieSpawnFactory.Create("Zombie", GeneratePosition());
    }

    public void SpawnRedZombie()
    {
        _zombieSpawnFactory.Create("Red", GeneratePosition());
    }

    public void SpawnGreenZombie()
    {
        _zombieSpawnFactory.Create("Green", GeneratePosition());
    }


    private Vector3 GeneratePosition()
    {
        int posX = Random.Range(320, 600);
        int posZ = Random.Range(20, 280);


        Vector3 newPosition = new Vector3(posX, 0, posZ);

        return newPosition;
    }
    #endregion
}
