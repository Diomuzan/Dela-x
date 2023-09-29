using System;
class Program {
    static void Main() {
        RandomNumbers();
        BattleSimulation();
        InputValue();
        likedDish();
    }

    static void RandomNumbers() {
        Random random = new Random();
        int current;

        do {
            current = random.Next(1, 11);
            if (current >= 8) continue;
            Console.WriteLine(current);
        }
        while (current != 7);
    }

    static void BattleSimulation() {
        Random random = new Random();
        int heroHealth = 10;
        int monsterHealth = 10;

        Console.WriteLine("Let the battle begin!");

        do {
            int heroAttack = random.Next(1, 11);
            int monsterAttack = random.Next(1, 11);
            monsterHealth -= heroAttack;
            Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");

            if (monsterHealth <= 0) {
                Console.WriteLine("Hero wins!");
                break;
            }

            heroHealth -= monsterAttack;
            Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");

            if (heroHealth <= 0) {
                Console.WriteLine("Monster wins!");
                break;
            }
        }
        while (heroHealth > 0 && monsterHealth > 0);
    }

    static void InputValue() {
        string role;
        bool isValid = false;

        do {
            Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
            role = Console.ReadLine();

            if (role == "Administrator" || role == "Manager" || role == "User") {
                isValid = true;
                Console.WriteLine($"Your input value ({role}) has been accepted.");
            } else {
                Console.WriteLine($"The role name that you entered, \"{role}\", is not valid. Please try again.");
            }
        } while (!isValid);
    }

    static void likedDish() {
        string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

        foreach (string myString in myStrings) {
            int periodLocation = myString.IndexOf(".");
            if (periodLocation != -1) {
                string remainingText = myString.Substring(0, periodLocation); // Extrahiere den Text vor dem Punkt
                string[] sentences = remainingText.Split('.'); // Teile den Text in Sätze auf

                foreach (string sentence in sentences) {
                    string trimmedSentence = sentence.Trim(); // Entferne führende und nachstehende Leerzeichen
                    if (!string.IsNullOrEmpty(trimmedSentence)) {
                        Console.WriteLine(trimmedSentence);
                    }
                }
            }
        }
    }
}

    






