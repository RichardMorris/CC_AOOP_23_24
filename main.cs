using System;
using doom; // Allows use of classes in the doom namespace

class Program {
  public static void Main (string[] args) {

    AbstractMonster rat1 = new SimpleMonster("rat",3,2);
    Console.WriteLine(rat1);

    AbstractMonster orc1 = new SimpleMonster("orc",10,2);
    Console.WriteLine(orc1);

    orc1.attack(rat1);
    Console.WriteLine(rat1);
    
    orc1.attack(rat1);
    Console.WriteLine(rat1);

  }
}