using UnityEngine;

public class VectorRenderer : MonoBehaviour
{

    void Start()
    {
        print(GameManager.instance.v1);
        print(GameManager.instance.v2);
        print(GameManager.instance.v3);
    }
}