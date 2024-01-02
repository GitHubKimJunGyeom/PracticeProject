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
        //normalized->�밢������ �̵��� ��Ÿ��� ������ ���� �Ϲ� ������ �̵��� �� �������Ƿ� �븻������� �ӵ��� �����ϰ� ����ȭ ��Ŵ(���Ⱚ�� 1�� ������ ����)
        //moveVec = new Vector3(hAxis, 0, vAxis).normalized;

        // ȸ���߿��� ������ȯ�� ���� ����
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

        //Vector3.zero -> 3���� ��Ұ� 0�� ����. �� ĳ���Ͱ� �����̰� ������ isRun �ƴ϶�� �⺻ ������ idle�� �ִϸ����ͷ� �����δ�
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
