using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAsProjectionElement : MonoBehaviour
{
    public OVRPassthroughLayer passthrough;
    public bool updateTransform = false;

    // Start is called before the first frame update
    void Start()
    {
        passthrough.AddSurfaceGeometry(gameObject, updateTransform);
        GetComponent<MeshRenderer>().enabled = false;
    }
}
