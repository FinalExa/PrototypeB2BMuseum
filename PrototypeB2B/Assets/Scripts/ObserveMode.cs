using UnityEngine;

public class ObserveMode : MonoBehaviour
{
    [SerializeField] private GameObject[] gameObjectsOfThis;
    [SerializeField] private GameObject[] border;
    [SerializeField] private GameObject[] camera;
    private bool observeModeOnOff;
    private GameObject[] allGameObjects;

    private void Awake()
    {
        ActivateInteraction.startObserveMode += ObserveModeActivate;
        allGameObjects = FindObjectsOfType<GameObject>();
        observeModeOnOff = false;
    }

    void ObserveModeActivate()
    {
        GameObjectActivateDeactivateOperation(false, allGameObjects);
        GameObjectActivateDeactivateOperation(true, gameObjectsOfThis);
        GameObjectActivateDeactivateOperation(false, border);
        observeModeOnOff = true;
    }

    void ObserveModeDeactivate()
    {
        GameObjectActivateDeactivateOperation(true, allGameObjects);
        GameObjectActivateDeactivateOperation(true, border);
        GameObjectActivateDeactivateOperation(false, camera);
        observeModeOnOff = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && observeModeOnOff == true)
        {
            ObserveModeDeactivate();
        }
    }

    void GameObjectActivateDeactivateOperation(bool onOff, GameObject[] arrayToOperate)
    {
        for (int i = 0; i < arrayToOperate.Length; i++)
        {
            arrayToOperate[i].SetActive(onOff);
        }
    }
}
