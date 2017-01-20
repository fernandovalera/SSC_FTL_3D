using UnityEngine;
using System.Collections;

public class IdleAnimationController : StateMachineBehaviour {
	private float normal_vertical_offset = 0;
	private Vector3 normal_position;

	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		Transform player_transform = animator.transform;
		Transform root_transform = player_transform.Find ("Root");
		Transform hip_transform = root_transform.Find ("Hip");
		Transform left_thigh_transform = hip_transform.Find ("Left_Thigh_Joint_01"); 
		Transform left_knee_transform = left_thigh_transform.Find ("Left_Knee_Joint_01");
		Transform left_ankle_transform = left_knee_transform.Find ("Left_Ankle_Joint_01");

		normal_vertical_offset = hip_transform.position.y - left_ankle_transform.position.y; 
		normal_position = root_transform.localPosition;
	
		
	}

	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		/*
		Transform player_transform = animator.transform;
		Transform root_transform = player_transform.Find ("Root");
		Transform hip_transform = root_transform.Find ("Hip");
		Transform left_thigh_transform = hip_transform.Find ("Left_Thigh_Joint_01"); 
		Transform left_knee_transform = left_thigh_transform.Find ("Left_Knee_Joint_01");
		Transform left_ankle_transform = left_knee_transform.Find ("Left_Ankle_Joint_01");

		float current_vertical_offset = hip_transform.position.y - left_ankle_transform.position.y; 

		Vector3 offset = new Vector3 (0, normal_vertical_offset - current_vertical_offset, 0);

		root_transform.localPosition = normal_position - offset;
		*/
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	//override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	//override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
}
