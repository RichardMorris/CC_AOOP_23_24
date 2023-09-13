using System;

namespace doom {
// Seperate out the different actions that can occur
// probably going a bit overboard on the Single-responsibility principle
// but does allow for some odd situations like an arrow trap that could deal damage, but not be hit

// Something that can attack annything that is hitable
public interface Attacker {
  void attack(Hitable m);
}

// Something that can be attacked
public interface Hitable {
  void receiveDamage(int amount);
}

// Something that can die
public interface LivingBeing {
  bool isAlive();
}

// An abstract base class upon which all other types of monster will be bassed. 
public abstract class AbstractMonster : Attacker, Hitable {
  protected int hp;

  int strength;
  bool alive = true;

  public AbstractMonster(int hitpoints, int str) {
    hp = hitpoints;
    strength = str;
  }
  
  public void attack(Hitable m) {
    m.receiveDamage(strength);
  }
  
  public void receiveDamage(int val) {
    hp -= val;
    if(hp < 0) {
      hp = 0;
      alive = false;
    }
  }

  public bool isAlive() {
    return alive;
  }
    
}

// A concrete class for simple monsters

public class SimpleMonster : AbstractMonster {
  string name;

  public SimpleMonster(string nm, int hp, int str) : base(hp,str) {
    name = nm;
  }
  
  public override string ToString() {
    return name + " " + ( isAlive() ? "alive with " + hp + " points" : "dead" ); 
  }
}

}