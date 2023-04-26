using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public int gridWidth = 10;
    public int gridHeight = 10;
    public float tileSize = 1;

    private Transform tilesParent;

    private void Start()
    {
        GenerateLevel();
    }

    void GenerateLevel()
    {
        tilesParent = new GameObject("Tiles").transform;

        for(int x = 0; x < gridWidth; x++)
        {
            for(int y = 0; y < gridHeight; y++)
            {
                int tileIndex = Random.Range(0, tilePrefabs.Length);
                GameObject tile = Instantiate(tilePrefabs[tileIndex], new Vector3(x * tileSize, 0f, y * tileSize), Quaternion.identity, tilesParent);
            }
        }
    }
}
