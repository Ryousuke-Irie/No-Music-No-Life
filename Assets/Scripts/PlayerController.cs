using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private SpriteRenderer MainSpriteRenderer;
    private Animator animator;

    public float MoveVel;
    public float PowerMag = 1.5f;
    
    public float AttackCoolTime = 0.1f;
    public float MaxTempoTime = 1.0f;
    public float TempoTimeError = 0.1f;
    public float PowerMax = 15.0f;

    public float upForce = 1000.0f;

    public float DeadZone = 0.5f;
   
    // 触っちゃダメ
    private float time;

    private float intervalTime;

    private bool attackFlag;
    private bool tempoFlag;


    public float AlphaE = 0;
    public float RedE = 255;
    public float GreenE = 255;
    public float BlueE = 0;

    private bool colFlagRight = false;
    private bool colFlagLeft = false;

    private bool jumpFlag = true;

    private float shakeTime = 0.0f;
    private bool shakeFlag = false;
    private float shakeAmount = 0.0f;

    private bool rotateFlag = false;

    private int tempoNum = 0;
    private int SnareNum = 0;

    GameObject cloneEffect;
    GameObject cloneEffect2;
    private Rigidbody2D rbody2D;

    // Start is called before the first frame update
    void Start()
    {
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        time = 0.0f;
        this.GetComponent<PlayerStatus>().isRight = true;
        this.GetComponent<PlayerStatus>().TempoTime = 0.0f;
        intervalTime = 0.0f;
        attackFlag = true;
        tempoFlag = false;
        this.GetComponent<PlayerStatus>().intervalFlag = false;
        this.GetComponent<PlayerStatus>().Power = this.GetComponent<PlayerStatus>().InitialPower;

        RedE = 255;
        GreenE = 255;
        BlueE = 0;

        rbody2D = GetComponent<Rigidbody2D>();

        GameObject effect = (GameObject)Resources.Load("nannkaEffect");
        cloneEffect = Instantiate(effect, this.transform.position + new Vector3(0.0f, 0.2f, 0.0f), Quaternion.identity);
        cloneEffect2 = Instantiate(effect, this.transform.position + new Vector3(0.0f, 0.2f, 0.0f), Quaternion.identity);
    }

    void FixedUpdate()
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, this.GetComponent<Rigidbody2D>().velocity.y);

        if (cloneEffect.transform.localScale.x > 0.0f)
        {
            cloneEffect.transform.localScale += new Vector3(0.03f, 0.03f, 0.0f);
        }

        if ((Input.GetKey(KeyCode.LeftArrow) || Gamepad.current.leftStick.ReadValue().x < -DeadZone) && !colFlagLeft)
        {
            //animator.SetBool("PlayerEvolveBool", true);

            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveVel, this.GetComponent<Rigidbody2D>().velocity.y);

            MainSpriteRenderer.flipX = false;

            this.GetComponent<PlayerStatus>().isRight = false;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) || Gamepad.current.leftStick.ReadValue().x < -DeadZone)
        {
            // animator.SetBool("PlayerEvolveBool", false);
        }

        if ((Input.GetKey(KeyCode.RightArrow) || Gamepad.current.leftStick.ReadValue().x > DeadZone) && !colFlagRight)
        {
            //animator.SetBool("PlayerEvolveBool", true);

            this.GetComponent<Rigidbody2D>().velocity = new Vector2(MoveVel, this.GetComponent<Rigidbody2D>().velocity.y);

            MainSpriteRenderer.flipX = true;

            this.GetComponent<PlayerStatus>().isRight = true;
        }

        if (Input.GetKeyUp(KeyCode.RightArrow) || Gamepad.current.leftStick.ReadValue().x > DeadZone)
        {
            //animator.SetBool("PlayerEvolveBool", false);
        }

        if (tempoFlag && !this.GetComponent<PlayerStatus>().intervalFlag)
        {
            cloneEffect2.transform.localScale += new Vector3(0.03f, 0.03f, 0.0f);
        }

        // 上下の揺れ
        if (shakeFlag && shakeAmount < 0.2f)
        {
            this.transform.localScale -= new Vector3(0.1f, 0.1f, 0.0f);
            shakeAmount += 0.1f;
        }

        if (shakeFlag && shakeAmount >= 0.2f && shakeAmount < 0.4f)
        {
            this.transform.localScale += new Vector3(0.1f, 0.1f, 0.0f);
            shakeAmount += 0.1f;
        }

        if (shakeFlag && shakeAmount >= 0.4f)
        {
            shakeFlag = false;
            shakeAmount = 0.0f;
            this.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }

        // 回転
        if(rotateFlag)
        {
            this.transform.Rotate(0.0f, 0.0f, -30.0f);
            if(this.transform.localEulerAngles.z <= 3.0f)
            {
                this.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                rotateFlag = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // コントローラー用
        if (Gamepad.current == null)
        {
            this.enabled = false;
            this.GetComponent<PlayerKey>().enabled = true;
        }

        // 上下の揺れ
        if ((Input.GetKeyDown(KeyCode.Space)
            || Gamepad.current.buttonNorth.wasPressedThisFrame
            || Gamepad.current.buttonEast.wasPressedThisFrame
            || Gamepad.current.buttonWest.wasPressedThisFrame
            || Gamepad.current.rightShoulder.wasPressedThisFrame)
            && attackFlag)
        {
            shakeFlag = true;
        }

        // エフェクト用
        cloneEffect.transform.position = this.transform.position + new Vector3(0.1f, 0.2f, 0.0f);
        cloneEffect.GetComponent<SpriteRenderer>().color = new Color32((byte)255, (byte)this.GetComponent<PlayerStatus>().Green, (byte)this.GetComponent<PlayerStatus>().Blue, (byte)AlphaE);

        cloneEffect2.transform.position = this.transform.position + new Vector3(0.1f, 0.2f, 0.0f);
        cloneEffect2.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, (byte)AlphaE);

       
        // ジャンプ
        if((Input.GetKeyDown(KeyCode.UpArrow) || Gamepad.current.buttonSouth.wasPressedThisFrame) && jumpFlag)
        {
            this.rbody2D.AddForce(transform.up * upForce);
            jumpFlag = false;
        }



        // 最初のテンポを定める
        if (tempoFlag && !this.GetComponent<PlayerStatus>().intervalFlag)
        {
            this.GetComponent<PlayerStatus>().TempoTime += Time.deltaTime;

            // 上限を超えたらなかったことになる
            if (this.GetComponent<PlayerStatus>().TempoTime > MaxTempoTime)
            {
                this.GetComponent<PlayerStatus>().TempoTime = 0.0f;
                tempoFlag = false;

                AlphaE = 0;
                RedE = 255;
            }
        }

        // テンポを刻む
        if (this.GetComponent<PlayerStatus>().intervalFlag)
        {
            intervalTime += Time.deltaTime;

            // 上限を超えたらなかったことになる
            if (intervalTime > MaxTempoTime)
            {
                this.GetComponent<PlayerStatus>().TempoTime = 0.0f;
                tempoFlag = false;
                intervalTime = 0.0f;
                this.GetComponent<PlayerStatus>().intervalFlag = false;

                this.GetComponent<PlayerStatus>().Power = this.GetComponent<PlayerStatus>().InitialPower;

                this.GetComponent<PlayerStatus>().Green = 255;
                this.GetComponent<PlayerStatus>().Blue = 255;

                AlphaE = 0;
                RedE = 255;

                tempoNum = 0;
                SnareNum = 0;
            }
        }

        // 連打でテンポを刻めるのを禁止する処理
        if ((Input.GetKeyDown(KeyCode.Space)
            || Gamepad.current.buttonNorth.wasPressedThisFrame
            || Gamepad.current.buttonEast.wasPressedThisFrame
            || Gamepad.current.buttonWest.wasPressedThisFrame
            || Gamepad.current.rightShoulder.wasPressedThisFrame)
            && !attackFlag)
        {
            if (this.GetComponent<PlayerStatus>().intervalFlag)
            {
                this.GetComponent<PlayerStatus>().TempoTime = 0.0f;
                tempoFlag = false;
                intervalTime = 0.0f;
                this.GetComponent<PlayerStatus>().intervalFlag = false;

                this.GetComponent<PlayerStatus>().Power = this.GetComponent<PlayerStatus>().InitialPower;

                this.GetComponent<PlayerStatus>().Green = 255;
                this.GetComponent<PlayerStatus>().Blue = 255;

                AlphaE = 0;
                RedE = 255;
            }

            tempoNum = 0;
            SnareNum = 0;
        }

        if (attackFlag && tempoFlag)
        {
            AlphaE = 255;
            RedE -= 0.5f;
            if(RedE < 150)
            {
                BlueE += 0.5f;
            }
        }

        if (this.GetComponent<PlayerStatus>().isAttacked)
        {
            this.GetComponent<PlayerStatus>().isAttacked = false;
        }

        // 攻撃
        if ((Input.GetKeyDown(KeyCode.Space) 
            || Gamepad.current.buttonNorth.wasPressedThisFrame
            || Gamepad.current.buttonEast.wasPressedThisFrame
            || Gamepad.current.buttonWest.wasPressedThisFrame
            || Gamepad.current.rightShoulder.wasPressedThisFrame)
            && attackFlag)
        {
            this.GetComponent<PlayerStatus>().isAttacked = true;

            RedE = 255;
            BlueE = 0;

            // 同一テンポによる火力上昇
            if (this.GetComponent<PlayerStatus>().intervalFlag)
            {
                if (this.GetComponent<PlayerStatus>().TempoTime + TempoTimeError >= intervalTime && this.GetComponent<PlayerStatus>().TempoTime - TempoTimeError <= intervalTime)
                {
                    intervalTime = 0.0f;

                    // ココの計算式は後々変更の可能性あり
                    this.GetComponent<PlayerStatus>().Power += (PowerMag * this.GetComponent<PlayerStatus>().TempoTime);

                    // パワー上限
                    if (this.GetComponent<PlayerStatus>().Power > PowerMax)
                    {
                        this.GetComponent<PlayerStatus>().Power = PowerMax;
                    }

                    this.GetComponent<PlayerStatus>().Green = 255 - this.GetComponent<PlayerStatus>().Power * 20;
                    this.GetComponent<PlayerStatus>().Blue = 255 - this.GetComponent<PlayerStatus>().Power * 20;

                    if (this.GetComponent<PlayerStatus>().Green < 0)
                    {
                        this.GetComponent<PlayerStatus>().Green = 0;
                    }

                    if (this.GetComponent<PlayerStatus>().Blue < 0)
                    {
                        this.GetComponent<PlayerStatus>().Blue = 0;
                    }

                    tempoNum += 1;
                }
                else  // 途中でのテンポ変更処理
                {
                    this.GetComponent<PlayerStatus>().TempoTime = intervalTime;

                    intervalTime = 0.0f;

                    this.GetComponent<PlayerStatus>().Power = this.GetComponent<PlayerStatus>().InitialPower;

                    this.GetComponent<PlayerStatus>().Green = 255;
                    this.GetComponent<PlayerStatus>().Blue = 255;

                    cloneEffect2.transform.localScale = cloneEffect.transform.localScale;

                    tempoNum = -2;
                    SnareNum = 0;

                    GameObject SE = (GameObject)Resources.Load("SE03");
                    GameObject cloneSE = Instantiate(SE, this.transform.position + new Vector3(2.0f, 0.0f, 0.0f), Quaternion.identity);

                    rotateFlag = true;
                }
            }

            cloneEffect.transform.localScale = new Vector3(0.3f, 0.3f, 0.0f);

            if (this.GetComponent<PlayerStatus>().isRight)
            {
                GameObject Slush = (GameObject)Resources.Load("Slush");
                GameObject cloneSlush = Instantiate(Slush, this.transform.position + new Vector3(2.0f, 0.0f, 0.0f), Quaternion.identity);
                cloneSlush.GetComponent<ParticleSystem>().startColor = new Color32(255, (byte)this.GetComponent<PlayerStatus>().Green, (byte)this.GetComponent<PlayerStatus>().Blue, 255);
            }
            if (!this.GetComponent<PlayerStatus>().isRight)
            {
                GameObject Slush = (GameObject)Resources.Load("SlushLeft");
                GameObject cloneSlush = Instantiate(Slush, this.transform.position + new Vector3(-2.0f, 0.0f, 0.0f), Quaternion.identity);
                cloneSlush.GetComponent<ParticleSystem>().startColor = new Color32(255, (byte)this.GetComponent<PlayerStatus>().Green, (byte)this.GetComponent<PlayerStatus>().Blue, 255);
            }

            if (tempoNum > -2)
            {
                GameObject SE = (GameObject)Resources.Load("SE02");
                GameObject cloneSE = Instantiate(SE, this.transform.position + new Vector3(2.0f, 0.0f, 0.0f), Quaternion.identity);
            }

            if (tempoNum >= 3)
            {
                if(SnareNum >= 1)
                {
                    GameObject SE2 = (GameObject)Resources.Load("SE01");
                    GameObject cloneSE2 = Instantiate(SE2, this.transform.position + new Vector3(2.0f, 0.0f, 0.0f), Quaternion.identity);
                    SnareNum = 0;
                }
                else
                {
                    SnareNum += 1;
                }


                tempoNum = 3;
            }

            attackFlag = false;
            time = AttackCoolTime;

            // テンポが定まったら刻み始める
            if (tempoFlag)
            {
                this.GetComponent<PlayerStatus>().intervalFlag = true;
            }

            // テンポを定め始める
            if (!tempoFlag && !this.GetComponent<PlayerStatus>().intervalFlag)
            {
                tempoFlag = true;

                cloneEffect2.transform.localScale = new Vector3(0.3f, 0.3f, 0.0f);
            }
        }

        // 攻撃のクールタイム
        if (!attackFlag)
        {
            time -= Time.deltaTime;

            if(time <= 0.0f)
            {
                time = 0.0f;
                attackFlag = true;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Floor")
        {
            jumpFlag = true;
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if(col.gameObject.tag == "Wall" || col.gameObject.tag == "Enemy")
        {
            if(this.GetComponent<PlayerStatus>().isRight)
            {
                colFlagRight = true;
            }

            if (!this.GetComponent<PlayerStatus>().isRight)
            {
                colFlagLeft = true;
            }

            if(colFlagRight && colFlagLeft)
            {
                colFlagRight = false;
                colFlagLeft = false;
            }
        }
    }
    
    void OnCollisionExit2D(Collision2D col) 
    {
        if (col.gameObject.tag == "Wall" || col.gameObject.tag == "Enemy")
        {
            colFlagRight = false;
            colFlagLeft = false;
        }
    }
}
