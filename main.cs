using System;

/** Things that cooked in a microwave. */
public interface Microwaveable {
    public void microwave();
}

public interface Edible {
    public bool readyToEat();
}
public class Flavour {
    string name;
    int hotness;

    public Flavour(string n, int h) {
        name = n; hotness = h;
    }

    public override string ToString() {
        return name;
    }
}
//base class
 public class Food {
    string name;
    protected Food(string n) { 
        Console.WriteLine("Base class constructor called");
        name = n; }
    public override string ToString() {
        return "Food item";
    }
}

// sub class
public class Dorito : Food, Microwaveable, Edible {
    Flavour flavour;
    bool burnt = false;
    public Dorito(Flavour f) : base("Dorito") {
        Console.WriteLine("sub class constructor called");   
        flavour = f;
    }
    public override string ToString() {
        return flavour + " dorito " + base.ToString();
    }
    public void microwave() {
        Console.WriteLine(this + " is cooking in a microwave");
        burnt = true;
    }
    public bool readyToEat() {
        return !burnt;
    }
}

class Program {
   public Program() {
        Dorito dor1 = new Dorito(new Flavour("Plain",0));
        Dorito dor2 = new Dorito(new Flavour("Cheese",0));
        Dorito dor3 = new Dorito(new Flavour("Chili",1));
        dor2.microwave();
        Edible[] items =  new Edible[] { dor1, dor2, dor3 };
        foreach (var element in items)
       {
           if(element.readyToEat()) {
               Console.WriteLine(element + " is ready");
           } else
           {
               Console.WriteLine(element + " is not ready");
               
           }
       }
    
    }
  
  public static void Main (string[] args) {
    Program myprog = new Program();
  }
}
