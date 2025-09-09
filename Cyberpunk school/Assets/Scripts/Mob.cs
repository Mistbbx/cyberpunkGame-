using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/MonsterObject", order = 1)]
public class Mob : ScriptableObject
{

    public string mName;
    public Sprite s;
    public int maxHp;
    public int currentHp;
    public int damage;
    public string description;
}
