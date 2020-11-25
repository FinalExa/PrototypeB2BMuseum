using UnityEngine;

public class ActivateInteraction : MonoBehaviour
{
    [SerializeField] private GameObject highlightArea;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("PaintingTag"))
        {
            highlightArea.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("PaintingTag"))
        {
            highlightArea.SetActive(false);
        }
    }
}
