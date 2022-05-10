using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hades : MonoBehaviour
{
    private float next1 = 0;
    private float next2 = 0;
    private float next3 = 0;
    private float next4 = 0;
    private float next5 = 0;
    private float next6 = 0;
    private float next7 = 0;
    private float next8 = 0;
    private float next9 = 0;
    private float next10 = 0;
    private float next11 = 0;
    private float next12 = 0;
    private float next13 = 0;
    private float next14 = 0;
    private float next15 = 0;
    private float next16 = 0;

    public Transform AttackPoint1;
    public Transform AttackPoint2;
    public Transform AttackPoint3;
    public Transform AttackPoint4;
    public Transform AttackPoint5;
    public Transform AttackPoint6;
    public Transform AttackPoint7;
    public Transform AttackPoint8;

  public Transform AttackPoint9;
    public Transform AttackPoint10;
    public Transform AttackPoint11;
    public Transform AttackPoint12;
    public Transform AttackPoint13;
    public Transform AttackPoint14;
    public Transform AttackPoint15;
    public Transform AttackPoint16;
    
    public AIPlayerDetector Detected;


    public GameObject abilityPrefab;
    Animator animator;
    

    // Start is called before the first frame update

    void Awake(){
        animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if(Detected.PlayerDetected == true){

        if(Time.time > next1){

                Activate1();
                next1 = Time.time + Random.Range(1,7);
            
        }
        if(Time.time > next2){

                Activate2();
                next2 = Time.time + Random.Range(1,7);
            
        }
               if(Time.time > next3){

                Activate3();
                next3 = Time.time + Random.Range(1,7);
            
        }
               if(Time.time > next4){

                Activate4();
                next4 = Time.time + Random.Range(1,7);
            
        }
               if(Time.time > next5){

                Activate5();
                next5 = Time.time + Random.Range(1,7);
            
        }
               if(Time.time > next6){

                Activate6();
                next6 = Time.time + Random.Range(1,7);
            
        }
               if(Time.time > next7){

                Activate7();
                next7 = Time.time + Random.Range(1,7);
            
        }
               if(Time.time > next8){

                Activate8();
                next8 = Time.time + Random.Range(1,7);
            
        }

          if(Time.time > next9){

                Activate9();
                next9 = Time.time + Random.Range(1,7);
            
        }
        if(Time.time > next10){

                Activate10();
                next10 = Time.time + Random.Range(1,7);
            
        }
               if(Time.time > next11){

                Activate11();
                next11 = Time.time + Random.Range(1,7);
            
        }
               if(Time.time > next12){

                Activate12();
                next12 = Time.time + Random.Range(1,7);
            
        }
               if(Time.time > next13){

                Activate13();
                next13 = Time.time + Random.Range(1,7);
            
        }
               if(Time.time > next14){

                Activate14();
                next14 = Time.time + Random.Range(1,7);
            
        }
               if(Time.time > next15){

                Activate15();
                next15 = Time.time + Random.Range(1,7);
            
        }
                     if(Time.time > next16){

                Activate16();
                next16 = Time.time + Random.Range(1,7);
            
        }
        }

    }

    void Activate1()
    {
        animator.SetTrigger("Attack");
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Enemies/Hades/Hades_Staff_Pound", GetComponent<Transform>().position);

        Instantiate(abilityPrefab, AttackPoint1.position, AttackPoint1.rotation);
    }
        void Activate2()
    {
        Instantiate(abilityPrefab, AttackPoint2.position, AttackPoint2.rotation);
    }
        void Activate3()
    {
        Instantiate(abilityPrefab, AttackPoint3.position, AttackPoint3.rotation);
    }
        void Activate4()
    {
        Instantiate(abilityPrefab, AttackPoint4.position, AttackPoint4.rotation);
    }
        void Activate5()
    {
        Instantiate(abilityPrefab, AttackPoint5.position, AttackPoint5.rotation);
    }
        void Activate6()
    {
        Instantiate(abilityPrefab, AttackPoint6.position, AttackPoint6.rotation);
    }
        void Activate7()
    {
        Instantiate(abilityPrefab, AttackPoint7.position, AttackPoint7.rotation);
    }
        void Activate8()
    {
        Instantiate(abilityPrefab, AttackPoint8.position, AttackPoint8.rotation);
    }

            void Activate9()
    {
        Instantiate(abilityPrefab, AttackPoint9.position, AttackPoint9.rotation);
    }
            void Activate10()
    {
        Instantiate(abilityPrefab, AttackPoint10.position, AttackPoint10.rotation);
    }
            void Activate11()
    {
        Instantiate(abilityPrefab, AttackPoint11.position, AttackPoint11.rotation);
    }
            void Activate12()
    {
        Instantiate(abilityPrefab, AttackPoint12.position, AttackPoint12.rotation);
    }
            void Activate13()
    {
        Instantiate(abilityPrefab, AttackPoint13.position, AttackPoint13.rotation);
    }
            void Activate14()
    {
        Instantiate(abilityPrefab, AttackPoint14.position, AttackPoint14.rotation);
    }
            void Activate15()
    {
        Instantiate(abilityPrefab, AttackPoint15.position, AttackPoint15.rotation);
    }
            void Activate16()
    {
        Instantiate(abilityPrefab, AttackPoint16.position, AttackPoint16.rotation);
    }
}