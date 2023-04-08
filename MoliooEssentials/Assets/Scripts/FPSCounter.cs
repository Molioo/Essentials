using TMPro;
using UnityEngine;

public class FPSCounter : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _fpsTextMesh=null;

    public void Update()
    {
        float fps = 1 / Time.unscaledDeltaTime;
        _fpsTextMesh.text = "" + fps;
    }
}
