using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	[Header("Background")]
	public List<Background> background;
	private Transform bgTarget;
	private int countBG = 0;

	void Awake()
	{
		bgTarget = GameObject.Find("Background").transform;
	}

	void Start()
	{
		LoadBuilding(0,0);
	}

	void Update()
	{
		if(bgTarget.childCount < 3)
		{
			
			if (++countBG >= background.Count) 
				countBG = 0;
			
			float next = bgTarget.GetChild (bgTarget.childCount - 1).transform.position.x;
			LoadBuilding (countBG,next + 11.7f);

		}
	}


	public void LoadBuilding(int index, float next)
	{
		Vector3 pos = bgTarget.position;
		pos.x += next;
		pos.y += background [index].posY;
		Instantiate (background [index].BG, pos, Quaternion.identity, bgTarget.transform);
	}

	[System.Serializable]
	public class Background
	{
		public GameObject BG;
		public float posY;
	}
		
}		

