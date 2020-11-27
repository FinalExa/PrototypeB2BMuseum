using UnityEngine;

public class ObserveMode : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private GameObject[] gameObjectsOfThis;
    [SerializeField] private GameObject[] border;
    [SerializeField] private GameObject[] camera;
    [HideInInspector] public bool observeModeOnOff;
    private GameObject[] allGameObjects;
    private Vector3 cameraStartingPos;
    private Quaternion cameraStartingRotation;
    private void Awake()
    {
        ActivateInteraction.startObserveMode += ObserveModeActivate;
        allGameObjects = FindObjectsOfType<GameObject>();
        observeModeOnOff = false;
    }

    private void Start()
    {
        cameraStartingPos = camera[0].transform.localPosition;
        cameraStartingRotation = camera[0].transform.localRotation;
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
        camera[0].transform.localPosition = cameraStartingPos;
        camera[0].transform.localRotation = cameraStartingRotation;
        observeModeOnOff = false;
    }

    private void Update()
    {
        if (playerInput.ExitInput == true && observeModeOnOff == true)
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
