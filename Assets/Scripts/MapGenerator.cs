using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

	public Transform[] tilePrefabs;
	public Vector2 mapSize;
	public List<GameObject> savedTiles;
	//public bool resetMap;

	private Transform mapHolder;

	// The core code for this function came from Sebastian Lague's "Unity Creat a Game Series (E08, tile map)"
	public void GenerateMap()
	{
		string holderName = "Generated Map";
		if(gameObject.transform.Find(holderName))
		{
			// Ensure that we don't get a million objects in a short time
			DestroyImmediate(gameObject.transform.Find(holderName).gameObject);
		}

		mapHolder = new GameObject(holderName).transform;
		mapHolder.parent = gameObject.transform;
		mapHolder.transform.up = gameObject.transform.up;

		if(savedTiles.Capacity == 0 /*|| resetMap == true*/)
		{
			for(int x = 0; x < mapSize.x; x++)
			{
				for(int y = 0; y < mapSize.y; y++)
				{
					Vector3 tilePosition = new Vector3(-mapSize.x/2 + (.5f + x) * 2, 0, -mapSize.y/2 + (.5f + y) * 2);
					Transform newTile = Instantiate(tilePrefabs[0], tilePosition, Quaternion.identity) as Transform;
					newTile.parent = mapHolder;
				}
			}
		}
		else
		{
			foreach(GameObject tile in savedTiles)
			{
				Vector3 tilePosition = tile.transform.position;
				Transform newTile;

				// Grabbing the Tile attributes to test the Tile type for dynamic Prefab instantiaton
				Tile reference = tile.GetComponent<Tile>();
				/*if(reference.type == "")
				{
				newTile = Instantiate(tilePrefabs.Contains(name == "MountainTile"), tilePosition, Quaternion.identity) as Transform;
				}*/
				newTile = Instantiate(tilePrefabs[0], tilePosition, Quaternion.identity) as Transform;
				newTile.parent = mapHolder;
			}
		}
	}

	public void SaveTiles()
	{
		foreach(Transform child in mapHolder.transform)
		{
			savedTiles.Add(child.gameObject);
		}
	}

	void Awake()
	{
		savedTiles = new List<GameObject>();
		GenerateMap();
		SaveTiles();

	}
}
