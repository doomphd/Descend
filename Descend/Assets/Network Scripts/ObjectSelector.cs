using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector : MonoBehaviour
{
	public static GameObject SelectedObject;
	public static GameObject HighlightedObject;

	private static Camera cam;
	private static GameManager gameManager;

	// Start is called before the first frame update
	void Start()
    {
		cam = GameObject.Find("Main Camera").GetComponent<Camera>();
		gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
		Ray ray = cam.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit))
		{
			GameObject hitObject = hit.transform.gameObject;
			if (Input.GetMouseButtonUp(0))
			{
				gameManager.ProcessClick(hitObject);
			}
			else if (hitObject != HighlightedObject && hit.transform.parent.gameObject != HighlightedObject)
			{
				SetHighlightedObject(hitObject);
			}
		}
		else
		{
			SetHighlightedObject(null);
		}
	}

	public static void SetHighlightedObject(GameObject gameObject)
	{
		if (HighlightedObject)
		{
			Highlight hl = HighlightedObject.GetComponentInParent<Highlight>();
			hl.OnUnhighlight();
		}
		HighlightedObject = gameObject;
		if (HighlightedObject)
		{
			if (HighlightedObject.GetComponentInParent<Hero>())
			{
				HighlightedObject = HighlightedObject.transform.parent.gameObject;
			}
			bool enabled = gameManager.HighlightEnabled(HighlightedObject);
			Highlight hl = HighlightedObject.GetComponentInParent<Highlight>();
			hl.OnHighlight(enabled);
		}
	}

	public static void SetSelectedObject(GameObject gameObject)
	{
		if (SelectedObject)
		{
			Highlight hl = SelectedObject.GetComponentInParent<Highlight>();
			hl.OnDeselect();
		}
		SelectedObject = gameObject;
		if (SelectedObject)
		{
			if (SelectedObject.GetComponentInParent<Hero>())
			{
				SelectedObject = SelectedObject.transform.parent.gameObject;
			}
			Highlight hl = SelectedObject.GetComponentInParent<Highlight>();
			hl.OnSelect();
		}
	}
}
