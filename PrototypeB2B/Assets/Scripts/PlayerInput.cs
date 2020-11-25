using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float HorizontalX { get; set; }
    public float HorizontalZ { get; set; }
    public bool InteractionInput { get; set; }

    private void Update()
    {
        HorizontalX = Input.GetAxis("Horizontal");
        HorizontalZ = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.E)) InteractionInput = true;
        else InteractionInput = false;
    }
}
