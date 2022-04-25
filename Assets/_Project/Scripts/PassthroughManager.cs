using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassthroughManager : MonoBehaviour
{
    public OVRPassthroughLayer passthrough;
    public OVRInput.Button button;
    public OVRInput.Controller controller;
    public List<Gradient> colorMapGradient;
    public GameObject canvasPassthrough;

    private bool projectionReconstructed = true;

    // Start is called before the first frame update
    void Start()
    {
        canvasPassthrough.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(button, controller))
        {
            passthrough.hidden = !passthrough.hidden;
        }
        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            canvasPassthrough.SetActive(!canvasPassthrough.activeSelf);
        }
    }

    public void SetOpacity(float value) 
    {
        passthrough.textureOpacity = value;
    }

    public void SetColorMap(int index) 
    {
        passthrough.colorMapEditorGradient = colorMapGradient[index];
    }

    public void SetBrightness(float value)
    {
        passthrough.colorMapEditorBrightness = value;
    }

    public void SetContrast(float value)
    {
        passthrough.colorMapEditorContrast = value;
    }

    public void SetPosterize(float value)
    {
        passthrough.colorMapEditorPosterize = value;
    }

    public void SetEdgeRendering(bool value)
    {
        passthrough.edgeRenderingEnabled = value;
    }

    public void SetBlueRed(float value)
    {
        Color newColor = new Color(value, passthrough.edgeColor.g, passthrough.edgeColor.b);
        passthrough.edgeColor = newColor;
    }
}
