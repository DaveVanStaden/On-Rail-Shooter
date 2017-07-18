using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour
{
    public Transform Bullet_Emiter;

    public GameObject Bullet;

    public float Bullet_Forward_Force;
    [SerializeField]
    private int ClipSize = 7;
    public int BulletsInClip = 7;
    private Text BulletText;
    // Use this for initialization
    void Start()
    {

    }
    public ParticleSystem Flash;
    private void Awake()
    {

        BulletText = GameObject.Find("txRelaodMessage").GetComponent<Text>();
    
    }
    private void Update()
    {
        if (BulletsInClip == 7)
        {
            BulletText.text = "Bullets Remaining: 7 ";
        }
        if (BulletsInClip == 6)
        {
            BulletText.text = "Bullets Remaining: 6 ";
        }
        if (BulletsInClip == 5)
        {
            BulletText.text = "Bullets Remaining: 5 ";
        }
        if (BulletsInClip == 4)
        {
            BulletText.text = "Bullets Remaining: 4 ";
        }
        if (BulletsInClip == 3)
        {
            BulletText.text = "Bullets Remaining: 3 ";
        }
        if (BulletsInClip == 2)
        {
            BulletText.text = "Bullets Remaining: 2 ";
        }
        if (BulletsInClip == 1)
        {
            BulletText.text = "Bullets Remaining: 1 ";
        }
        if (BulletsInClip == 0)
        {
            BulletText.text = "Bullets Remaining: 0 Press R to Reload ";
        }
    }
    public void Shoot()
    {

    


        if (BulletsInClip <= 0)
        {
            

        }
        else
        {

            Flash.Play();


            var bullet = Instantiate(Bullet, Bullet_Emiter.position, transform.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 10;
        }
        BulletsInClip--;

    }
    public void reload()
    {
        BulletsInClip = ClipSize;

    }
}
