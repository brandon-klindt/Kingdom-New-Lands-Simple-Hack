using UnityEngine;

namespace Kingdom_Hack
{
    class Main : MonoBehaviour
    {
        public void Start()
        {
            _player = FindObjectOfType<Player>();
            _damageable = FindObjectOfType<Damageable>();
        }

        public void Update()
        {


            if (Input.GetKeyDown(KeyCode.Delete))
            {
                Loader.Unload();
            }

            if (Input.GetKeyDown(KeyCode.Keypad1))
            {
                _damageable.invulnerable = !_damageable.invulnerable;
            }

            if (Input.GetKeyDown(KeyCode.Keypad2))
            {
                _player.coins += 10;
            }
        }

        public void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 150f, 50f), "v1.0.0 by brandon-klindt\nInvulnerable: " + _damageable.invulnerable + "\nPlayer Coins : " + _player.coins);
        }
        private Player _player;
        private Damageable _damageable;

    }
}