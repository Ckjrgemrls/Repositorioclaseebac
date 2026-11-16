using UnityEngine;

public class Holamundo : MonoBehaviour
{
    int x;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        x = 0;
        print("Hola Mundo");
        
        Debug.LogWarning("Algo podría estar mal");
        Debug.LogError("Algo está mal");
    }

    // Update is called once per frame
    void Update()
    {
        x = x + 1;
        Debug.Log(x);
    }
}
