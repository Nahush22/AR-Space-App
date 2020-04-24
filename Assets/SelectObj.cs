using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectObj : MonoBehaviour
{
    private Text label;
    private GameObject bg_label;

    // Start is called before the first frame update
    void Start()
    {
        label = GameObject.Find("Label").GetComponent<Text>();
        label.text = "";

        bg_label = GameObject.Find("BgLabel");
        bg_label.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                bg_label.SetActive(true);
                label.text = hit.transform.name.ToString();
            }
            else
            {
                bg_label.SetActive(false);
                label.text = "";
            }
        }
#elif UNITY_ANDROID
        if ((Input.GetTouch(0).phase == TouchPhase.Stationary) || (Input.GetTouch(0).phase == TouchPhase.Moved && Input.GetTouch(0).deltaPosition.magnitude < 1.2f))
        {
			Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if(hit.transform.name.ToString()!="Plane1")
                {
                    bg_label.SetActive(true);
                    label.text = hit.transform.name.ToString();
                }
                else
                {
                    bg_label.SetActive(false);
                    label.text = "";
                }
            }
            else
            {
                bg_label.SetActive(false);
                label.text = "";
            }
		}
#endif

    }
}
