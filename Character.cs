namespace Classes;

public class Character
{

 public string nameChar;
 public int lifePoints;
 public int attackStrength;
 public int defenseStrength;

 public bool IsAlive()
 {
    if(lifePoints > 0)
        return true;
    else
        return false;
 }

 public void Attack(Character attaquant)
 {
    lifePoints = lifePoints - (attaquant.attackStrength - defenseStrength);

 }
}
