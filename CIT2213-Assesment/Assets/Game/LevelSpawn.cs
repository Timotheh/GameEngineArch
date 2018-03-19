using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawn : MonoBehaviour {
    public GameObject LevelTile;
	// Use this for initialization
	void Start ()
    {
        for (int x = 0; x <= 10; x++)
        {
            for(int z = 0; z <=10; z++)
            {
                for(int y = 0; y <=1; y++)
                {
                    Instantiate(LevelTile, new Vector3(LevelTile.transform.localPosition.x + x, LevelTile.transform.localPosition.y +y, LevelTile.transform.position.z + z), Quaternion.identity);
                }
                                  
            }
        }
        Destroy(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
