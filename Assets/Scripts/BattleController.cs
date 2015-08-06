using UnityEngine;
using System.Collections;

public class BattleController : MonoBehaviour {
	
	public GameObject tank;
	public int PlayerHealth = 100;
	public int PlayerDamadgeGive;
	public int PlayerDamadgeTake;
	public int [] PlayerFrags;
	public Vector3 PlayerPosition;
	
	
	void Start () {
	
	}
	
	void Update () {
		PlayerPosition = tank.transform.position;
		
		
	
	}
}
