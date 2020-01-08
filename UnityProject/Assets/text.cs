using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
	[SerializeField]
	Text t = null;
    // Start is called before the first frame update
    void Start()
    {
		t.text = "aa\naa";
    }
}
