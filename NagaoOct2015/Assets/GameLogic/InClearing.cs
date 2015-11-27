﻿using UnityEngine;
using System.Collections;

public class InClearing : StateMachineBehaviour {


    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        SoundManagerScript.audioSource.clip = SoundManagerScript.soundDictionaryManager.audioClipValue("clear");
        SoundManagerScript.audioSource.volume = 0.3f;
        SoundManagerScript.audioSource.Play();

        GameObject playerView = GameObject.Find("GameLogic").GetComponent<GameLogic>().playerView;
        GameObject clearAnimation = GameObject.Find("GameLogic").GetComponent<GameLogic>().clearAnimation;
        Transform playerTransform = playerView.GetComponent<Transform>();

        GameObject c = Instantiate(clearAnimation,playerTransform.position,playerTransform.rotation) as GameObject;
        c.GetComponent<Transform>().Translate(new Vector3(0, 3, 0));
        GameObject.Find("Player").SetActive(false);
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