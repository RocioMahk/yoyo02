using UnityEngine;
using System.Collections;

public class LluviaRocas : State
{
    public State coraza;
	public State morir;
	public GameObject player;
	public GameObject jaguar;
	public GameObject prefab;
    public float speed;

	public float vida;


    void Update()
    {

		Vector2 position = new Vector2(Random.Range(-19, 3), 0);
		Instantiate(prefab, position, Quaternion.identity);

		Vector2 position2 = new Vector2(Random.Range(-19, 3), 0);
		Instantiate(prefab, position2, Quaternion.identity);

		Vector2 position3 = new Vector2(Random.Range(-19, 3), 0);
		Instantiate(prefab, position3, Quaternion.identity);

		Vector2 position4 = new Vector2(Random.Range(-19, 3), 0);
		Instantiate(prefab, position4, Quaternion.identity);
       
    }

    public override void CheckExit()
    {
		if (vida == 0) {
			stateMachine.ChangeState (morir);
		} else {
			StartCoroutine (esperar2Seg ());
		}
    }

	IEnumerator esperar2Seg()
	{
		yield return new WaitForSecondsRealtime (5);
		stateMachine.ChangeState (coraza);
	}
}



