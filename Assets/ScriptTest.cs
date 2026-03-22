using UnityEngine;

public class ScriptTest : MonoBehaviour
{
    public string playerName = "Player";

    public int health = 100;

    public int damage = 20;

    string[] enemies = {"Zombie", "Alien", "Robot", "Boss", "Potion"};

    void AttackEnemy(string enemyName) {
        enemyName = enemies[];

        Debug.Log($"First enemy to face is {enemies[0]}");

        for (int i = 0; i < enemies.Length; i++) {
            Debug.Log($"Enemy {i}: {enemies[i]}");

            health =- damage;
        }

        if (enemyName == enemies[4]) {
            Debug.Log($"You have taken the {enemies[0]}. Health has increased!");

            health += 10;
        }
    }

    CheckPlayerHealth() {
        Debug.Log($"Player health is {playerHealth}");
    }

    void Conditional() {
        if (health > 50) {
            Debug.Log("Player is strong.");
        }

        if (health <= 50) {
            Debug.Log("Player is weak.");
        }

        if (health <= 0) {
            Debug.Log("Player is dead.");
            Application.Quit();
        }
    }

    void Start() {
        AttackEnemy();

        CheckPlayerHealth();

        Conditional();
    }
}
