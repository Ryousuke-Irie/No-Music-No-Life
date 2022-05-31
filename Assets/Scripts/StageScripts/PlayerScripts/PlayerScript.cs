using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    private Animator animator;
    private Animator gAnimator;

    // 変数
    private int Skill = 0;

    [System.NonSerialized] public int HP = 10;
    private int tempHP = 5;

    public float TempoTimeError = 1.5f;

    private float pPos = -2.0f;

    [SerializeField] GameObject B1;
    [SerializeField] GameObject B2;
    [SerializeField] GameObject B4;

    [System.NonSerialized] public int score = 0;

    [System.NonSerialized] public float dist = 0.0f;
    [System.NonSerialized] public float Nextdist = 0.0f;
    [System.NonSerialized] public float Next2dist = 0.0f;
    [System.NonSerialized] public float Next3dist = 0.0f;
    [System.NonSerialized] public float Next4dist = 0.0f;
    [System.NonSerialized] public float Next5dist = 0.0f;
    [System.NonSerialized] public float MoveLimit = 140.0f;
    private float MoveLimitPlus = 10.0f;
    public float BesideMoveAmount = 10.0f;

    private float UpperLimit = 4.0f;
    private float LowerLimit = -4.0f;
    private float VerticalMoveAmount = 4.0f;

    public float PlayerToSlush = 2.0f;
    public float PlayerToReticle = 5.0f;

    private float blinkingTime = 0.0f;
    private int blinkingMax = 3;
    private int blinkingNum = 0;

    private GameObject SE;
    private GameObject SE2;

    public GameObject BGM;
    [System.NonSerialized] public GameObject cloneBGM;

    private GameObject Effect;
    private GameObject cloneEffect;
    private GameObject cloneEffect2;

    private GameObject refCamera;

    private GameObject refGhostGirl;
    private GameObject cloneGhostGirl;

    private float ghostPosX = -2.5f;
    private float ghostPosY = 1.0f;

    private GameObject refGhostGirlEffect;
    private GameObject cloneGhostGirlEffect;
    private GameObject cloneGhostGirlEffect2;
    private GameObject cloneGhostGirlEffect3;

    private GameObject refAttackEffect;

    private GameObject refAttackEffect2;
    private GameObject cloneAttackEffect2;

    private GameObject refAttackEffect3;
    private GameObject cloneAttackEffect3;

    private GameObject refFade;

    private GameObject refGameOver;
    private GameObject cloneGameOver;

    private AudioSource audioSource;

    // フラグ用変数
    private bool rotateFlag = false;
    [System.NonSerialized] public bool blinkingFlag = false;
    private bool blinkingFlag2 = false;

    [System.NonSerialized] public bool actionFlag = false;
    [System.NonSerialized] public bool moveUpFlag = false;
    [System.NonSerialized] public bool moveDownFlag = false;
    [System.NonSerialized] public bool attackFlag = false;
    [System.NonSerialized] public bool chargeFlag = false;

    [System.NonSerialized] public bool startFlag = false;
    [System.NonSerialized] public bool goalFlag = false;
    [System.NonSerialized] public bool lastStickFlag = false;

    [System.NonSerialized] public bool deadFlag = false;

    [System.NonSerialized] public bool oneTimeFlag = false;
    private bool oneTimeFlag2 = false;

    private bool animFlag = false;

    public bool loopFlag = false;
    [System.NonSerialized] public bool loopStageFlag = false;
    [System.NonSerialized] public bool loopBackFlag = false;

    [System.NonSerialized] public bool loopBossFlag = false;
    [System.NonSerialized] public bool loopLastFlag = false;

    public bool lastStageFlag = false;

    public bool tutorialFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;

        this.transform.position = new Vector3(this.transform.position.x, pPos, this.transform.position.z);

        animator = GetComponent<Animator>();
        tempHP = HP;

        SE = (GameObject)Resources.Load("SE01");
        SE2 = (GameObject)Resources.Load("SE02");

        Effect = (GameObject)Resources.Load("nannkaEffect");

        refCamera = GameObject.Find("Main Camera");

        refFade = GameObject.Find("fade_white2");

        refGameOver = (GameObject)Resources.Load("GameOver");

        refGhostGirl = (GameObject)Resources.Load("GhostGirl");
        refGhostGirlEffect = (GameObject)Resources.Load("girlEffect");
        refAttackEffect = (GameObject)Resources.Load("AttackEffect");
        refAttackEffect2 = (GameObject)Resources.Load("AttackEffect3");
        refAttackEffect3 = (GameObject)Resources.Load("AttackEffect6");

        cloneGhostGirl = Instantiate(refGhostGirl, this.transform.position + new Vector3(ghostPosX, ghostPosY, 0.0f), Quaternion.identity);
        cloneGhostGirlEffect = Instantiate(refGhostGirlEffect, this.transform.position + new Vector3(ghostPosX, ghostPosY, 0.0f), Quaternion.identity);
        cloneGhostGirlEffect2 = Instantiate(refGhostGirlEffect, this.transform.position + new Vector3(ghostPosX, ghostPosY, 0.0f), Quaternion.identity);
        cloneGhostGirlEffect3 = Instantiate(refGhostGirlEffect, this.transform.position + new Vector3(ghostPosX, ghostPosY, 0.0f), Quaternion.identity);
        //cloneAttackEffect = Instantiate(refAttackEffect, this.transform.position + new Vector3(PlayerToSlush - 0.5f, 0.0f, 0.0f), Quaternion.identity);
        //cloneAttackEffectN = Instantiate(refAttackEffect, this.transform.position + new Vector3(PlayerToSlush - 0.5f, 0.0f, 0.0f), Quaternion.identity);
        cloneAttackEffect2 = Instantiate(refAttackEffect2, this.transform.position + new Vector3(PlayerToSlush - 1.5f, pPos, 0.0f), Quaternion.identity);
        cloneAttackEffect3 = Instantiate(refAttackEffect3, this.transform.position + new Vector3(PlayerToSlush - 0.5f, pPos, 0.0f), Quaternion.identity);

        cloneEffect = Instantiate(Effect, this.transform.position + new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        //cloneEffect2 = Instantiate(Effect, this.transform.position + new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);

        gAnimator = cloneGhostGirl.GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        // 点滅処理
        Blinking();

        // 回転処理
        Rotate();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("PlayerAttackBool", false);
        animator.SetBool("PlayerAttack2Bool", false);

        gAnimator.SetBool("TamekoBool", false);
        gAnimator.SetBool("Tameko2Bool", false);
        gAnimator.SetBool("Tameko3Bool", false);

        cloneAttackEffect2.GetComponent<Animator>().SetBool("AttackBool", false);
        cloneAttackEffect3.GetComponent<Animator>().SetBool("AttackBool", false);

        if (loopFlag && goalFlag) { return; }

        if (deadFlag)
        {
            if (cloneGameOver)
            {
                if (cloneGameOver.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
                {
                    refFade.GetComponent<FadeScript>().isFadeOut = true;

                    refFade.transform.position = new Vector3(refCamera.transform.position.x, refCamera.transform.position.y, 0.0f);
                }
            }

            if (refFade.GetComponent<FadeScript>().fadeEndFlag)
            {
                Cursor.visible = true;

                SceneManager.LoadScene("StageSelectScene");
            }

            return;
        }

        if (startFlag)
        {
            // BGMを流す
            if(!oneTimeFlag2)
            {
                cloneBGM = Instantiate(BGM, this.transform.position + new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
                cloneBGM.GetComponent<AudioSource>().volume = SoundController.value_all * SoundController.value_bgm;
                if (tutorialFlag)
                {
                    cloneBGM.GetComponent<AudioSource>().volume = 0.0f;
                }

                audioSource = cloneBGM.GetComponent<AudioSource>();

                oneTimeFlag2 = true;
            }

            // 横移動処理
            BesideMove();

            // アニメーション管理
            AnimationManager();
        }

        // 女の子
        cloneGhostGirl.transform.position = this.transform.position + new Vector3(ghostPosX, ghostPosY, 0.0f);
        cloneGhostGirlEffect.transform.position = this.transform.position + new Vector3(ghostPosX, ghostPosY, 0.0f);
        cloneGhostGirlEffect2.transform.position = this.transform.position + new Vector3(ghostPosX, ghostPosY, 0.0f);
        cloneGhostGirlEffect3.transform.position = this.transform.position + new Vector3(ghostPosX, ghostPosY, 0.0f);
        cloneGhostGirlEffect.GetComponent<Animator>().SetInteger("StateInt", Skill - 2);
        cloneGhostGirlEffect2.GetComponent<Animator>().SetInteger("StateInt", Skill - 1);
        cloneGhostGirlEffect3.GetComponent<Animator>().SetInteger("StateInt", Skill);

        // 上下移動処理
        MoveAction();

        // 攻撃処理
        AttackAction();

        // 溜め処理
        ChargeAction();

        // レティクル
        //cloneEffect2.transform.position = this.transform.position + new Vector3(PlayerToReticle, 0.0f, 0.0f);
        //cloneEffect2.transform.localScale = new Vector3(0.6f, 0.6f, 0.0f);
        //cloneEffect2.GetComponent<SpriteRenderer>().color = new Color32((byte)128, (byte)255, (byte)128, (byte)255);

        // 位置判定による処理
        PosJudge();

        // HPが減った時の処理
        Damaged();

        // HPが0になった時の処理
        Dead();

        // ゴール処理
        Goal();
    }

    private void Blinking()
    {
        // 点滅
        if (blinkingFlag)
        {
            blinkingNum = blinkingMax;
            blinkingFlag = false;
        }

        if (blinkingNum > 0 && !blinkingFlag2)
        {
            blinkingFlag2 = true;
            blinkingNum -= 1;
        }

        if (blinkingFlag2)
        {
            this.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);

            blinkingTime += 0.1f;

            if (blinkingTime > 1.0f)
            {
                this.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
                blinkingTime = 0.0f;
                blinkingFlag2 = false;
            }
        }
    }

    private void Rotate()
    {
        // 回転
        if (rotateFlag)
        {
            this.transform.Rotate(0.0f, 0.0f, -30.0f);
            if (this.transform.localEulerAngles.z <= 3.0f)
            {
                this.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                rotateFlag = false;
            }
        }
    }

    private void BesideMove()
    {
        // 横の移動
        if (this.transform.position.x < MoveLimit + MoveLimitPlus)
        {
            // this.transform.position = new Vector3(BesideMoveAmount * cloneBGM.GetComponent<AudioSource>().time, this.transform.position.y, 0.0f);

            this.transform.position += new Vector3(BesideMoveAmount, 0.0f, 0.0f) * Time.deltaTime;
            cloneBGM.transform.position = this.transform.position;
        }
    }

    private void AnimationManager()
    {
        if (this.transform.position.x < MoveLimit)
        {
            if (this.transform.position.y <= LowerLimit)
            {
                animator.SetBool("PlayerRunBool", true);
            }
        }

        if (this.transform.position.y > LowerLimit)
        {
            animator.SetBool("PlayerRunBool", false);
        }

        cloneAttackEffect2.transform.position = new Vector3(this.transform.position.x + PlayerToSlush - 1.5f, pPos, 0.0f);
        cloneAttackEffect3.transform.position = new Vector3(this.transform.position.x + PlayerToSlush - 0.5f, pPos, 0.0f);
    }

    private void MoveAction()
    {
        // 上へ移動
        if (!actionFlag && moveUpFlag)
        {
            if (this.transform.localPosition.y < UpperLimit + pPos)
            {
                rotateFlag = true;

                this.transform.position += new Vector3(0.0f, VerticalMoveAmount, 0.0f);

                GameObject cloneSE = Instantiate(SE, this.transform.position + new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
                cloneSE.GetComponent<AudioSource>().volume = SoundController.value_all * SoundController.value_se;

                actionFlag = true;
            }

            moveUpFlag = false;
        }

        // 下へ移動
        if (!actionFlag && moveDownFlag)
        {
            if (this.transform.localPosition.y > LowerLimit + pPos)
            {
                rotateFlag = true;

                this.transform.position -= new Vector3(0.0f, VerticalMoveAmount, 0.0f);

                GameObject cloneSE = Instantiate(SE, this.transform.position + new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
                cloneSE.GetComponent<AudioSource>().volume = SoundController.value_all * SoundController.value_se;

                actionFlag = true;
            }

            moveDownFlag = false;
        }
    }

    private void AttackAction()
    {
        // 攻撃
        if (!actionFlag && attackFlag)
        {
            if (!animFlag)
            {
                animator.SetBool("PlayerAttackBool", true);
                animFlag = true;
            }
            else
            {
                animator.SetBool("PlayerAttack2Bool", true);
                animFlag = false;
            }

            if (Skill < 2)
            {
                // 攻撃エフェクト(オブジェクト)生成
                GameObject Slush = (GameObject)Resources.Load("Slush");
                GameObject cloneSlush = Instantiate(Slush, this.transform.position + new Vector3(PlayerToSlush, 0.0f, 0.0f), Quaternion.identity);

                GameObject cloneAttackEffect = Instantiate(refAttackEffect, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
                cloneAttackEffect.GetComponent<Animator>().SetBool("AttackBool", true);
                cloneAttackEffect.transform.position = this.transform.position + new Vector3(PlayerToSlush + 1.5f, 0.0f, 0.0f);

                gAnimator.SetBool("TamekoBool", true);
            }

            if (Skill >= 3)
            {
                // 攻撃エフェクト(オブジェクト)生成
                GameObject Slush = (GameObject)Resources.Load("Slush");
                GameObject cloneSlush = Instantiate(Slush, new Vector3(PlayerToSlush + this.transform.position.x, 0.0f + pPos, 0.0f), Quaternion.identity);
                GameObject cloneSlush2 = Instantiate(Slush, new Vector3(PlayerToSlush + this.transform.position.x, LowerLimit + pPos, 0.0f), Quaternion.identity);
                GameObject cloneSlush3 = Instantiate(Slush, new Vector3(PlayerToSlush + this.transform.position.x, UpperLimit + pPos, 0.0f), Quaternion.identity);
                GameObject cloneSlush4 = Instantiate(Slush, new Vector3(PlayerToSlush + PlayerToSlush + this.transform.position.x, 0.0f + pPos, 0.0f), Quaternion.identity);
                GameObject cloneSlush5 = Instantiate(Slush, new Vector3(PlayerToSlush + PlayerToSlush + this.transform.position.x, LowerLimit + pPos, 0.0f), Quaternion.identity);
                GameObject cloneSlush6 = Instantiate(Slush, new Vector3(PlayerToSlush + PlayerToSlush + this.transform.position.x, UpperLimit + pPos, 0.0f), Quaternion.identity);

                cloneAttackEffect3.GetComponent<Animator>().SetBool("AttackBool", true);
                gAnimator.SetBool("Tameko3Bool", true);

                Skill = 0;
            }

            if (Skill >= 2 && Skill < 3)
            {
                // 攻撃エフェクト(オブジェクト)生成
                GameObject Slush = (GameObject)Resources.Load("Slush");
                GameObject cloneSlush = Instantiate(Slush, new Vector3(PlayerToSlush + this.transform.position.x, 0.0f + pPos, 0.0f), Quaternion.identity);
                GameObject cloneSlush2 = Instantiate(Slush, new Vector3(PlayerToSlush + this.transform.position.x, LowerLimit + pPos, 0.0f), Quaternion.identity);
                GameObject cloneSlush3 = Instantiate(Slush, new Vector3(PlayerToSlush + this.transform.position.x, UpperLimit + pPos, 0.0f), Quaternion.identity);

                cloneAttackEffect2.GetComponent<Animator>().SetBool("AttackBool", true);
                gAnimator.SetBool("Tameko2Bool", true);

                Skill = 0;
            }          

            GameObject cloneSE = Instantiate(SE, this.transform.position + new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
            cloneSE.GetComponent<AudioSource>().volume = SoundController.value_all * SoundController.value_se;

            attackFlag = false;
            actionFlag = true;
        }
    }

    private void ChargeAction()
    {
        gAnimator.SetBool("TameBool", false);
        // 溜め
        if (!actionFlag && chargeFlag)
        {
            rotateFlag = true;

            if(Skill < 3)
            {
                Skill++;
            }

            GameObject cloneSE = Instantiate(SE, this.transform.position + new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
            cloneSE.GetComponent<AudioSource>().volume = SoundController.value_all * SoundController.value_se;

            gAnimator.SetBool("TameBool", true);

            chargeFlag = false;
            actionFlag = true;
        }

        if (Skill == 0)
        {
            cloneEffect.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
        }

        if (Skill == 1)
        {
            //cloneEffect.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
            //cloneEffect.GetComponent<SpriteRenderer>().color = new Color32((byte)255, (byte)128, (byte)0, (byte)255);
        }

        if (Skill == 2)
        {
            //cloneEffect.transform.localScale = new Vector3(1.0f, 1.0f, 0.0f);
            //cloneEffect.GetComponent<SpriteRenderer>().color = new Color32((byte)255, (byte)64, (byte)0, (byte)255);
        }

        if (Skill >= 3)
        {
            //cloneEffect.transform.localScale = new Vector3(1.5f, 1.5f, 0.0f);
            //cloneEffect.GetComponent<SpriteRenderer>().color = new Color32((byte)255, (byte)0, (byte)0, (byte)255);
        }

        cloneEffect.transform.position = this.transform.position;
    }

    private void PosJudge()
    {
        // テンポに合わせてSEを鳴らす処理
        if (this.transform.position.x > dist - 1.0f && !oneTimeFlag)
        {
            oneTimeFlag = true;

            GameObject cloneSE2 = Instantiate(SE2, this.transform.position + new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
            cloneSE2.GetComponent<AudioSource>().volume = SoundController.value_all * SoundController.value_se;

            // this.transform.position = new Vector3(BesideMoveAmount * audioSource.time, this.transform.position.y, 0.0f);
        }
    }

    private void Damaged()
    {
        if(HP < tempHP)
        {
            refCamera.GetComponent<CameraScript>().Shake(0.2f, 0.1f);

            tempHP = HP;
        }

        if(tutorialFlag)
        {
            HP = 10;
            tempHP = 10;
        }
    }

    private void Dead()
    {
        // ゲームオーバー条件
        if(HP <= 0 && !deadFlag)
        {
            deadFlag = true;

            refCamera.GetComponent<PostEffect>().enabled = true;

            GameObject hibi = (GameObject)Resources.Load("Hibi");
            GameObject cloneHibi = Instantiate(hibi, new Vector3(refCamera.transform.position.x, refCamera.transform.position.y, 0.0f), Quaternion.identity);

            cloneGameOver = Instantiate(refGameOver, new Vector3(refCamera.transform.position.x, refCamera.transform.position.y, 0.0f), Quaternion.identity);
        }
    }

    private void Goal()
    {
        if (loopBackFlag)
        {
            loopBackFlag = false;
            this.transform.position = new Vector3(0.0f, this.transform.position.y, 0.0f);
            refCamera.transform.position = new Vector3(0.0f, refCamera.transform.position.y, refCamera.transform.position.z);
        }

        // ゴール条件
        if (this.transform.position.x >= MoveLimit)
        {
            if (loopFlag)
            {
                loopStageFlag = true;
                loopBackFlag = true;
                loopBossFlag = true;
                loopLastFlag = true;

                if (cloneBGM)
                {
                    Destroy(cloneBGM);
                    if (lastStageFlag)
                    {
                        if (this.GetComponent<LastStageManagerScript>().loopNum == -1)
                        {
                            this.GetComponent<LastStageManagerScript>().loopNum = 0;
                        }

                        if (this.GetComponent<LastStageManagerScript>().loopNum == 0)
                        {
                            cloneBGM = Instantiate(B1, this.transform.position + new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
                            cloneBGM.GetComponent<AudioSource>().volume = SoundController.value_all * SoundController.value_bgm;
                            audioSource = cloneBGM.GetComponent<AudioSource>();
                        }

                        if (this.GetComponent<LastStageManagerScript>().loopNum == 1)
                        {
                            cloneBGM = Instantiate(B2, this.transform.position + new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
                            cloneBGM.GetComponent<AudioSource>().volume = SoundController.value_all * SoundController.value_bgm;
                            audioSource = cloneBGM.GetComponent<AudioSource>();
                        }

                        if (this.GetComponent<LastStageManagerScript>().loopNum == 2)
                        {
                            cloneBGM = Instantiate(B1, this.transform.position + new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
                            cloneBGM.GetComponent<AudioSource>().volume = SoundController.value_all * SoundController.value_bgm;
                            audioSource = cloneBGM.GetComponent<AudioSource>();
                        }

                        if (this.GetComponent<LastStageManagerScript>().loopNum == 3)
                        {
                            cloneBGM = Instantiate(B4, this.transform.position + new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
                            cloneBGM.GetComponent<AudioSource>().volume = SoundController.value_all * SoundController.value_bgm;
                            audioSource = cloneBGM.GetComponent<AudioSource>();
                        }
                    }
                    else
                    {
                        cloneBGM = Instantiate(BGM, this.transform.position + new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
                        cloneBGM.GetComponent<AudioSource>().volume = SoundController.value_all * SoundController.value_bgm;
                        audioSource = cloneBGM.GetComponent<AudioSource>();
                    }

                    if (tutorialFlag)
                    {
                        cloneBGM.GetComponent<AudioSource>().volume = 0.0f;
                    }
                }
            }
            else
            {
                goalFlag = true;
                Cursor.visible = true;
            }
        }
    }
}
