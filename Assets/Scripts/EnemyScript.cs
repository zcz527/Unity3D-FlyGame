using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{
    private bool hasSpawn;
    private MoveScript moveScript;
    private WeaponScript[] weapons;

    void Awake()
    {
        weapons = GetComponentsInChildren<WeaponScript>();
        moveScript = GetComponent<MoveScript>();
    }

    void Start()
    {
        hasSpawn = false;
        GetComponent<Collider2D>().enabled = false;
        moveScript.enabled = false;
        foreach (var weapon in weapons)
        {
            weapon.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (hasSpawn == false)
        {
            if (GetComponent<Renderer>().IsVisiableFrom(Camera.main))
            {
                Spawn();
            }
        }
        else
        {
            foreach (var weapon in weapons)
            {
                if (weapon != null && weapon.CanAttack)
                {
                    weapon.Attack(true);
                    SoundEffectsHelper.instance.MakeEnemyShotSound();
                }
            }
            if (GetComponent<Renderer>().IsVisiableFrom(Camera.main) == false)
            {
                //超出摄像机界面，销毁
                Destroy(gameObject);
            }
        }

    }

    private void Spawn()
    {
        hasSpawn = true;
        GetComponent<Collider2D>().enabled = true;
        moveScript.enabled = true;
        foreach (var weapon in weapons)
        {
            weapon.enabled = false;
        }
    }
}
