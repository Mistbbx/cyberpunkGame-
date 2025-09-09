
using UnityEngine;

using System.IO;
public class Writer : MonoBehaviour
{
    public Character player;
    void Start()
    {
        player.bio = "I'm just a little guy";
        player.Hp = 10;
        player.Str = 1;
        player.Dex = 5;
        player.Int = 20;
        player.role = Character.Role.littleGuy;

        string json = JsonUtility.ToJson(player);
        Debug.Log(json);
        string path = "Assets/littleguy.json";
        StreamWriter t = new StreamWriter(path, false);
        t.Write(json);
        t.Close();

    }
}
