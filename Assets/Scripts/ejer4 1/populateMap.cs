using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class populateMap : MonoBehaviour
{
    public string tilemapName;
    void Start()
    {
        TextAsset tilemapCSV = Resources.Load<TextAsset>(tilemapName);
        string[] tiles = tilemapCSV.text.Split(',');
        for(int i = 0; i < tiles.Length-1; i++){
            Instantiate(prefabDictionary.prefabs[tiles[i]], new Vector2(i % 35, i / 100), Quaternion.identity);
        }
    }
}
