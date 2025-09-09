
using System;
using UnityEngine;
[Serializable]
public class Character
{
    public string bio;
    public int Hp;
    public int Str;
    public int Int;
    public int Dex;
    public enum Role {littleGuy, bigGuy};
    public Role role;

}
