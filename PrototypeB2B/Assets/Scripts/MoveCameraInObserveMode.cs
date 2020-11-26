using UnityEngine;

public class MoveCameraInObserveMode : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private ObserveMode observeMode;
    [SerializeField] private GameObject thisPaintingCamera;
    [SerializeField] private float cameraMovementSpeed;
    [SerializeField] private float cameraRotationSpeed;
    [SerializeField] private float cameraLimit;

    private void FixedUpdate()
    {
        if (observeMode.observeModeOnOff == true) CameraOperations();
    }

    void CameraOperations()
    {
        CameraMovement();
        CameraRotation();
        CameraZoom();
    }


    private void CameraMovement()
    {
        Vector3 thisCameraPos = thisPaintingCamera.transform.localPosition;
        if (playerInput.ForwardInput == true && thisCameraPos.y < cameraLimit) thisPaintingCamera.transform.position += new Vector3(0f, cameraMovementSpeed * Time.fixedDeltaTime, 0f);
        if (playerInput.BackInput == true && thisCameraPos.y > -cameraLimit) thisPaintingCamera.transform.position += new Vector3(0f, -cameraMovementSpeed * Time.fixedDeltaTime, 0f);
        if (playerInput.RightInput == true && thisCameraPos.x < cameraLimit) thisPaintingCamera.transform.position += new Vector3(cameraMovementSpeed * Time.fixedDeltaTime, 0f, 0f);
        if (playerInput.LeftInput == true && thisCameraPos.x > -cameraLimit) thisPaintingCamera.transform.position += new Vector3(-cameraMovementSpeed * Time.fixedDeltaTime, 0f, 0f);
    }

    private void CameraRotation()
    {

    }
    private void CameraZoom()
    {

    }

    bool NoInputsActive()
    {
        bool noInputStatus;
        if (playerInput.ForwardInput == false && playerInput.BackInput == false && playerInput.LeftInput == false && playerInput.RightInput == false)
        {
            noInputStatus = true;
        }
        else
        {
            noInputStatus = false;
        }
        return noInputStatus;
    }
}
