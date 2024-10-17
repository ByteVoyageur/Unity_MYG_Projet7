using UnityEngine;

public class TeleportationManager : MonoBehaviour
{
    [SerializeField] private Material _skyboxMaterial1;
    [SerializeField] private Material _skyboxMaterial2;

    public void OnTeleport(int anchorNumber)
    {
        Debug.Log("Anchor is touched");
        switch (anchorNumber)
        {
            case 1:
                RenderSettings.skybox = _skyboxMaterial1;
                break;
            case 2:
                RenderSettings.skybox = _skyboxMaterial2;
                Debug.Log("Skybox is changed to 2.");
                break;
        }
    }
}
