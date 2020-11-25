using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float HorizontalX { get; set; }
    public float HorizontalZ { get; set; }

    private void Update()
    {
        HorizontalX = Input.GetAxis("Horizontal");
        HorizontalZ = Input.GetAxis("Vertical");
    }
}
