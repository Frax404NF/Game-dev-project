using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] _tiles;
    public GameObject _startTile1; // Tile tetap 1
    public GameObject _startTile2; // Tile tetap 2

    private float Index = 0;

    private void Start()
    {
        // Spawn StartTile1
        GameObject StartPlane1 = Instantiate(_startTile1, transform);
        StartPlane1.transform.position = new Vector3(7, 0, 0);

        // Spawn StartTile2
        GameObject StartPlane2 = Instantiate(_startTile2, transform);
        StartPlane2.transform.position = new Vector3(-1, 0, 0);

        // Spawn random tile berikutnya
        int randomTile = Random.Range(0, _tiles.Length);
        GameObject StartPlane3 = Instantiate(_tiles[randomTile], transform);
        StartPlane3.transform.position = new Vector3(-9, 0, 0);
    }

    private void Update()
    {
        gameObject.transform.position += new Vector3(4 * Time.deltaTime, 0, 0);

        if(transform.position.x >= Index)
        {
            int RandomInt1 = Random.Range(0, 2);

            if(RandomInt1 == 1)
            {
                int randomTile = Random.Range(0, _tiles.Length);
                GameObject TempTile = Instantiate(_tiles[randomTile], transform);
                TempTile.transform.position = new Vector3(-16, 0, 0);
            }
            else if(RandomInt1 == 0)
            {
                int randomTile = Random.Range(0, _tiles.Length);
                GameObject TempTile = Instantiate(_tiles[randomTile], transform);
                TempTile.transform.position = new Vector3(-16, 0, 0);
            }

            int RandomInt2 = Random.Range(0, 2);

            if(RandomInt2 == 1)
            {
                int randomTile = Random.Range(0, _tiles.Length);
                GameObject TempTile = Instantiate(_tiles[randomTile], transform);
                TempTile.transform.position = new Vector3(-24, 0, 0);
            }
            else if(RandomInt2 == 0)
            {
                int randomTile = Random.Range(0, _tiles.Length);
                GameObject TempTile = Instantiate(_tiles[randomTile], transform);
                TempTile.transform.position = new Vector3(-24, 0, 0);
            }

            Index = Index + 15.95f;
        }
    }
}
