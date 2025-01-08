public class ExampleClass{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Check for zero before dividing
        if (MyProperty != 0)
        {
            int result = 10 / MyProperty; 
        }
        else
        {
            //Handle the case where MyProperty is zero.  Options include:
            //1. Throw a more informative exception
            //throw new ArgumentException("MyProperty cannot be zero");
            //2. Return a default value
            //int result = 0; 
            //3. Log a warning
            Console.WriteLine("Warning: Division by zero avoided.");
        }
    }
}