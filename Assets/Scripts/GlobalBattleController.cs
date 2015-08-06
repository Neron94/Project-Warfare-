using UnityEngine;
using System.Collections;

public class GlobalBattleController : MonoBehaviour {


   private int warCount = 3;
   public Vector3 [] PlayersPos = new Vector3[3];
   public int PlayersNumber;
   public Vector3 [] SpawnPoint;
   public BattleController [] BattleControllers = new BattleController [1];
   public int [] healthPlayer;
   public int [] PlayersDamage;
   public int [] PlayersEarnDamage;
   public int [] PlayersDestroyed;
   
   
   
	void Start () {

	
	}
	void Update(){
		
		
	}
	
	
}