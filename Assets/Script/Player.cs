using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool attack;

    private Animator animator;
    // Start is called before the first frame update

    private void Awake()
    {
        animator = GetComponent<Animator>();
		//Attack();
	}

	void Start()
    {
	}

	// Update is called once per frame
	void Update()
    {
        //Move();

        GetInput();
        Attack();
    }
	private void FixedUpdate()
	{
	}

	void GetInput()
    {
        attack = Input.GetButton("Attack");
    }


    void Move()
	{
        //normalized->대각선으로 이동시 피타고라스 정리에 의해 일반 축으로 이동시 더 빨라지므로 노말라이즈로 속도를 일정하게 정규화 시킴(방향값이 1로 고정된 벡터)
        //moveVec = new Vector3(hAxis, 0, vAxis).normalized;

        // 회피중에는 방향전환을 하지 않음
        //      if(isDodge)
        //{
        //          moveVec = dodgeVec;
        //}

        //      if(isSwap || !isFireReady || isReload || isDead)
        //{
        //          moveVec = Vector3.zero;
        //      }
        //      if(!isBorder)
        //{
        //          transform.position += moveVec * speed * (wDown ? 0.3f : 1f) * Time.deltaTime;
        //      }

        //Vector3.zero -> 3개의 요소가 0인 벡터. 즉 캐릭터가 움직이고 있으면 isRun 아니라면 기본 설정된 idle이 애니메이터로 움직인다
        Debug.Log("Move");
        animator.SetBool("isRun", true);
        //animator.SetBool("isWalk", wDown);
    }

	void Attack()
    {
		//if (equipWeapon == null)
		//{
		//    return;
		//}

		//fireDelay += Time.deltaTime;
		//isFireReady = equipWeapon.rate < fireDelay;
		//if (fDown && isFireReady && !isDodge && !isSwap && !isShop && !isDead)
		//{
		//    equipWeapon.Use();
		//    //anim.SetTrigger("doSwing");
		//    //anim.SetTrigger(equipWeapon.type == Weapon.Type.Melee ? "doSwing" : "doShot");
		//    fireDelay = 0;
		//}
		//animator.SetBool("isCombo1", true);
		//yield return new WaitForSeconds(attackTime);
  //      Debug.Log("isCombo1 start");

        //yield return new WaitForSeconds(attackTime);
        //animator.SetBool("isCombo1", false);
        //Debug.Log("isCombo1 end");
        if(attack)
        {
            Debug.Log("Attack");
			animator.SetTrigger("doCombo1");
		}

		//yield return new WaitForSeconds(attackTime);
		//animator.SetBool("isCombo1", false);
		//animator.SetBool("isCombo2", false);
		//Debug.Log("isCombo2 end");

		//yield return new WaitForSeconds(attackTime);

	}
}
