using UnityEngine;

public class CrearCubodeCero : MonoBehaviour
{

    GameObject objToSpawn;
    Vector3[] vertices = {
        new Vector3(0, 0, 0), // Vértice 0
        new Vector3(1, 0, 0), // Vértice 1
        new Vector3(1, 1, 0), // Vértice 2
        new Vector3(0, 1, 0), // Vértice 3
        new Vector3(0, 0, 1), // Vértice 4
        new Vector3(1, 0, 1), // Vértice 5
        new Vector3(1, 1, 1), // Vértice 6
        new Vector3(0, 1, 1)  // Vértice 7
    };

    int[] triangulos = {
        0, 2, 1, // Cara frontal
        0, 3, 2,
        1, 2, 6, // Cara derecha
        1, 6, 5,
        5, 6, 7, // Cara trasera
        5, 7, 4,
        4, 7, 3, // Cara izquierda
        4, 3, 0,
        3, 7, 6, // Cara superior
        3, 6, 2,
        4, 0, 1, // Cara inferior
        4, 1, 5
    };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objToSpawn = new GameObject("Nuestro Primer Cubo");
        objToSpawn.AddComponent<MeshFilter>();
        var meshFilter = objToSpawn.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangulos;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();
        objToSpawn.AddComponent<BoxCollider>();
        var boxCollider = objToSpawn.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        objToSpawn.AddComponent<MeshRenderer>();
        var meshRenderermaterial = objToSpawn.GetComponent<MeshRenderer>().material;
        meshRenderermaterial.color = Color.white;
        objToSpawn.transform.position = Vector3.one;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
