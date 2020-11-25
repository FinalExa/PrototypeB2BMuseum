using UnityEngine;

public class ObserveMode : MonoBehaviour
{
    [SerializeField] private GameObject[] reactivateGameObjects;
    [SerializeField] private GameObject[] deactivateBorder;
    private GameObject[] allGameObjects;

    private void Awake()
    {
        ActivateInteraction.startObserveMode += ObserveModeActivate;
        allGameObjects = FindObjectsOfType<GameObject>();
    }

    void ObserveModeActivate()
    {
        GameObjectActivateDeactivateOperation(false, allGameObjects);
        GameObjectActivateDeactivateOperation(true, reactivateGameObjects);
        GameObjectActivateDeactivateOperation(false, deactivateBorder);
    }


    void GameObjectActivateDeactivateOperation(bool onOff, GameObject[] arrayToOperate)
    {
        for (int i = 0; i < arrayToOperate.Length; i++)
        {
            arrayToOperate[i].SetActive(onOff);
        }
    }
}
