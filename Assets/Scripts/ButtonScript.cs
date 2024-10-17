using UnityEditor;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private Transform _cubeSpawner;
    [SerializeField] private Transform _sphereSpawner;
    [SerializeField] private Transform _capsuleSpawner;

    public void OnButtonClick(string type)
    {
    if (type == "Cube")
    {
    var obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
    obj.name = "Custom Cube";  
    obj.AddComponent<Rigidbody>();
    obj.AddComponent<BoxCollider>();
    obj.AddComponent<XRGrabInteractable>();
    obj.transform.localScale = new Vector3(0.333f, 0.333f, 0.333f);
    Instantiate(obj);
    obj.transform.position = _cubeSpawner.position;
    }
    else if (type == "Sphere")
    {
    var obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
    obj.name = "Custom Sphere";  
    obj.AddComponent<Rigidbody>();
    obj.AddComponent<SphereCollider>();
    obj.AddComponent<XRGrabInteractable>();
    obj.transform.localScale = new Vector3(0.333f, 0.333f, 0.333f);
    Instantiate(obj);
    obj.transform.position = _sphereSpawner.position;
    }
    else if (type == "Capsule")
    {
    var obj = GameObject.CreatePrimitive(PrimitiveType.Capsule);
    obj.name = "Custom Capsule";  
    obj.AddComponent<Rigidbody>();
    obj.AddComponent<CapsuleCollider>();
    obj.AddComponent<XRGrabInteractable>();
    obj.transform.localScale = new Vector3(0.333f, 0.333f, 0.333f);
    Instantiate(obj);
    obj.transform.position = _capsuleSpawner.position;
    }
    }
}
