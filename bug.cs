public class ExampleClass{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Simulate an error
        int result = 10 / MyProperty; 
    }
}