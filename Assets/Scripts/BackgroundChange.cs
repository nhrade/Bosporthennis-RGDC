using UnityEngine;
using System.Collections;

public class BackgroundChange : MonoBehaviour {

    Color[] colors = {new Color(0.5f, 0.75f, 0.65f),
                     Color.magenta, Color.grey, Color.cyan, Color.green};
    public int currIndex;
    private const float SMOOTH = 0.01f;
    Color bgColor;
	// Use this for initialization
	void Start () {
        camera.clearFlags = CameraClearFlags.SolidColor;
        currIndex = 0;
        bgColor = colors[0];
	}


    
    void Update()
    {

        for (int i = 0; i < colors.Length; i++)
        {
            if(bgColor == colors[i])
            {
                currIndex = i + 1 == colors.Length ? 0 : i + 1;
            }
        }

        Color nextColor = colors[currIndex];
         bgColor = Color.Lerp(bgColor, nextColor, SMOOTH);
         camera.backgroundColor = bgColor;
    }
}
