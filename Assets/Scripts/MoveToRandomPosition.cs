using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToRandomPosition : MonoBehaviour
{
    public GameObject player;
    public Vector3[] positions;
    public int index;

    // Start is called before the first frame update
    void Start()
    {
        positions = CreateRandomPosition(5);
        index = CreateRandomIndex(0, positions.Length);
        player.transform.position = positions[index];

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3[] CreateRandomPosition(int number)
    {
        Vector3[] pos = new Vector3[number];

        for (int i = 0; i < number; i++)
        {
            pos[i] = new Vector3(Random.value * 50, Random.value * 50, Random.value * 50);
        }

        return pos;
    }



    int CreateRandomIndex(int min, int max)
    {
        int index = Random.Range(min, max);
        return index;
    }
}
