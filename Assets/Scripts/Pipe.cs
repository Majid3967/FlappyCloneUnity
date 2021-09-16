using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    private Character character;

    // Use this for initialization
    void Start()
    {
        character = FindObjectOfType<Character>();
    }


    // Update is called once per frame
    void Update()
    {
        if (character.transform.position.x - transform.position.x > 30)
        {
            float xRan = Random.Range(0, 10);
            float yRan = Random.Range(-5, 5);

            Instantiate(gameObject, new Vector2(character.transform.position.x + 15 + xRan, -10 + yRan), transform.rotation);
            Destroy(gameObject);
        }
    }

}
