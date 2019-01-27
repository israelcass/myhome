using UnityEngine;
using System.Collections;

public class ScrollingUVs_Layers : MonoBehaviour 
{
	//public int materialIndex = 0;
	public Vector2 uvAnimationRate = new Vector2( 1.0f, 0.0f );
	public string textureName = "_MainTex";
    public bool shouldLavaGoUp = true;
	
	Vector2 uvOffset = Vector2.zero;

    void LateUpdate() {
        uvOffset += (uvAnimationRate * Time.deltaTime);
        if (GetComponent<Renderer>().enabled) {
            GetComponent<Renderer>().sharedMaterial.SetTextureOffset(textureName, uvOffset);
        }
        if (shouldLavaGoUp) {
            Vector3 position = new Vector3(this.transform.position.x, this.transform.position.y + 0.001f, this.transform.position.z);
            this.transform.position = position;
        }
    }
}