using TMPro;
using UnityEngine;

public class UpdateUIText : MonoBehaviour
{
    public GameObject cubeObject; // Reference to the GameObject with the RotateCube script
    private RotateCube rotateCube; // Reference to the RotateCube script
    private TextMeshProUGUI textMeshPro;

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        rotateCube = cubeObject.GetComponent<RotateCube>(); // Initialize the rotateCube variable
    }

    void Update()
    {
        textMeshPro.text = $"Rotation Speed: {rotateCube.rotationSpeed}\nRotation Direction: {rotateCube.rotationDirection}";
    }
}