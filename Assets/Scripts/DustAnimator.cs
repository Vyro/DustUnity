using UnityEngine;
using System.Collections;

public class DustAnimator : MonoBehaviour {
	Animator anim;
	int jumpHash = Animator.StringToHash("Jump");
	int runStateHash = Animator.StringToHash("Base Layer.Run");

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		float move = Input.GetAxis ("Vertical");
		anim.SetFloat ("Speed", move);

		AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo (0);
			if (Input.GetKeyDown (KeyCode.Space) && stateInfo.nameHash == runStateHash) {
						anim.SetTrigger (jumpHash);
						anim.SetBool ("Jump", true);
			} 
			else 
				anim.SetBool ("Jump", false);
			}
		}	