using UnityEngine;

// Klassenavnet skal matche filnavnet, f.eks. BISHBASHBOSH.cs
public class BISHBASHBOSH : MonoBehaviour
{
    // Dette kaldes én gang, når spillet starter
    void Start()
    {
        Debug.Log("Spillet starter!");
    }

    // Dette kaldes én gang per frame
    void Update()
    {
        // Her kan du f.eks. flytte en GameObject
        // transform.Translate(Vector3.forward * Time.deltaTime);
    }
}