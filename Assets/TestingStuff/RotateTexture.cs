using UnityEngine;

public class RotateTexture : MonoBehaviour
{
    public float rotationSpeed = 90.0f; // Rotation speed in degrees per second

    private Material material;
    private Vector2 offset;

    void Start()
    {
        material = GetComponent<Renderer>().material;
        offset = material.mainTextureOffset;
    }

    void Update()
    {
        // Calculate the new offset to rotate the texture
        offset.x += rotationSpeed * Time.deltaTime;

        // Make sure the offset stays within the [0, 1] range to avoid issues
        offset.x %= 1.0f;

        // Update the material's main texture offset
        material.mainTextureOffset = offset;
    }
}
