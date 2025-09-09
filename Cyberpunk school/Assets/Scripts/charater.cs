using System;
using UnityEngine;
[Serializable]
public class charater
{
    public int hp;
    public int cHp;
    public int sta;
    public int cSta;
    public enum Role {Ninja, Healer, Warrior};
    public Role role;
    public String bio;
    public String assetsName;
}
