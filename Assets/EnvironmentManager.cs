using UnityEngine;
using UnityEngine.Rendering.Universal;

public class EnvironmentManager : MonoBehaviour
{
    [SerializeField] private Light2D worldLight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetLightBounds(100,101);
    }

    public void SetLightBounds(float innerBound,float outerBound,float intensity = 1)
    {
        worldLight.intensity = intensity;
        worldLight.pointLightOuterRadius = outerBound;
        worldLight.pointLightInnerRadius = innerBound;
    }
}
