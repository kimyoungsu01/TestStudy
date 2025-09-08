using UnityEngine;

public class rotation : MonoBehaviour
{
    public GameObject box;
    public float num = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) 
        { 
          rotations();
        }
    }

    public void rotations() 
    {
        data data = new data(100);
        transform.Rotate(0, 90, 0);
        num += transform.rotation.y;
    }
}
