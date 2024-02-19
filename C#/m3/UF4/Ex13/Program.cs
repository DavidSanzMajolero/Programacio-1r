/*Tenint en compte la següent classe:
public class Cat : Animal, Pet
{
    public Cat (float weight, string name) : base(weight,name)
    {
        this.Weight = weight;
        this.Name = name;   
    }
    public double Move (int step)
    {
        return step * 2;
    }
}
public static void Main() 
{
    Cat michi = new Cat();
}

Dona error ja que estas instanciant a la classe Cat sense passar-li els paràmetres que demana el constructor.
*/