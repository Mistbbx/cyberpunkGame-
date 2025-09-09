using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 spawnPos = this.transform.position;
        GameObject player = Resources.Load<GameObject>(charSheet.player.role.ToString());
        Instantiate(player, spawnPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
